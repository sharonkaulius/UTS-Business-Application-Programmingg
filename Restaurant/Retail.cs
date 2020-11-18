using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurant
{
    public partial class Retail : Form
    {
        int total = 0;
        public Retail()
        {
            InitializeComponent();
            this.Load += OnFormLoad;
            this.retailTabControl.SelectedIndexChanged += OnSelectedIndexChanged;
            this.amountPaidNumeric.ValueChanged += OnAmountPaidValueChanged;
            this.submitOrderButton.Click += OnSubmitButtonClicked;
            this.paymentComboBox.SelectedIndexChanged += OnPaymentSelectedIndexChanged;
            this.paymentComboBox.SelectedIndex = 0;
        }

        private void OnPaymentSelectedIndexChanged(object sender, EventArgs e)
        {
            UpdatePayment();
        }

        private void OnAmountPaidValueChanged(object sender, EventArgs e)
        {
            int amountPaid = 0;
            if(total > 0 && int.TryParse(this.amountPaidNumeric.Value.ToString(), out amountPaid))
            {
                changeLabel.Text = (amountPaid - total) + "";
            }
        }

        private void OnSubmitButtonClicked(object sender, EventArgs e)
        {
            SubmitOrder();
        }

        private void OnSelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateConfirmOrder();
            UpdatePayment();
        }

        private void SubmitOrder()
        {
            int totalBeforeTax = 0;
            List<Order> orders = new List<Order>();
            for (int i = 0; i < menuDGV.Rows.Count; i++)
            {
                int quantity, price;
                if (menuDGV.Rows[i].Cells["quantityCol"].Value != null && int.TryParse(menuDGV.Rows[i].Cells["quantityCol"].Value.ToString(), out quantity) &&
                    menuDGV.Rows[i].Cells["priceCol"].Value != null && int.TryParse(menuDGV.Rows[i].Cells["priceCol"].Value.ToString(), out price))
                {
                    int subtotal = quantity * price;
                    totalBeforeTax += subtotal;
                    Order order = new Order();
                    order.menuId = (int)menuDGV.Rows[i].Cells["idCol"].Value;
                    order.price = price;
                    order.quantity = quantity;
                    orders.Add(order);
                    orderSummaryDGV.Rows.Add(new object[]
                    {
                        menuDGV.Rows[i].Cells["idCol"].Value,
                        menuDGV.Rows[i].Cells["menuCol"].Value,
                        menuDGV.Rows[i].Cells["priceCol"].Value,
                        menuDGV.Rows[i].Cells["quantityCol"].Value,
                        subtotal
                    });
                }
            }
            if(totalBeforeTax == 0)
            {
                return;
            }
            int tax = (int)(totalBeforeTax * 0.1f);
            int total = (totalBeforeTax + tax);
            switch (this.paymentComboBox.SelectedIndex)
            {
                case 0:
                    if (this.amountPaidNumeric.Value < total)
                        return;
                    break;
                case 1:
                    if (string.IsNullOrEmpty(this.cardNumbeTextbox.Text))
                        return;
                    break;
                case 2:
                    if (string.IsNullOrEmpty(this.phoneNumberTextbox.Text))
                        return;
                    break;
            }

            SqlConnection connection = new SqlConnection(Settings.DB_DATA_CONNECTION_STRING);
            string sql = @"INSERT INTO " + Settings.TABLE_ORDER +
                @"(total, payment_type, phone_number, card_number) output INSERTED.ID VALUES(@total,@payment_type,@phone_number,@card_number)";
            SqlCommand cmd = new SqlCommand(sql, connection);
            cmd.Parameters.Add("@total", SqlDbType.Int).Value = total;
            cmd.Parameters.Add("@payment_type", SqlDbType.VarChar, 50).Value = paymentComboBox.Text;
            if(paymentComboBox.SelectedIndex == 2)
            {
                cmd.Parameters.AddWithValue("@phone_number", phoneNumberTextbox.Text);
                cmd.Parameters.AddWithValue("@card_number", DBNull.Value);
            }
            else if(paymentComboBox.SelectedIndex == 1)
            {
                cmd.Parameters.AddWithValue("@card_number", cardNumbeTextbox.Text);
                cmd.Parameters.AddWithValue("@phone_number", DBNull.Value);
            }
            else
            {
                cmd.Parameters.AddWithValue("@card_number", DBNull.Value);
                cmd.Parameters.AddWithValue("@phone_number", DBNull.Value);
            }
            connection.Open();

            try
            {
                int id = (int)cmd.ExecuteScalar();
                for(int i = 0; i < orders.Count; i++)
                {
                    cmd = new SqlCommand(@"INSERT INTO " + Settings.TABLE_TRANSACTION +
                        @"(orderId, menuId, price, quantity) VALUES (@orderId, @menuId, @price, @quantity)", connection);
                    cmd.Parameters.Add("@orderId", SqlDbType.Int).Value = id;
                    cmd.Parameters.Add("@menuId", SqlDbType.Int).Value = orders[i].menuId;
                    cmd.Parameters.Add("@price", SqlDbType.Int).Value = orders[i].price;
                    cmd.Parameters.Add("@quantity", SqlDbType.Int).Value = orders[i].quantity;
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Order submitted");
                    this.Close();
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Failed submitted order - " + ex.Message.ToString());
            }
        }
        private void UpdatePayment()
        {
            amountDueLabel.Text = totalLabel.Text;
            switch(paymentComboBox.SelectedIndex)
            {
                case 0:
                    cashGroup.Visible = true;
                    ovoGroup.Visible = cardGroup.Visible = false;
                    break;
                case 1:
                    cardGroup.Visible = true;
                    cardGroup.Location = cashGroup.Location;
                    ovoGroup.Visible = cashGroup.Visible = false;
                    break;
                case 2:
                    ovoGroup.Visible = true;
                    ovoGroup.Location = cashGroup.Location;
                    cashGroup.Visible = cardGroup.Visible = false;
                    break;
            }
        }
        private void UpdateConfirmOrder()
        {
            orderSummaryDGV.Rows.Clear();
            int totalBeforeTax = 0;
            for(int i = 0; i < menuDGV.Rows.Count; i++)
            {
                int quantity, price;
                if (menuDGV.Rows[i].Cells["quantityCol"].Value != null && int.TryParse(menuDGV.Rows[i].Cells["quantityCol"].Value.ToString(), out quantity) &&
                    menuDGV.Rows[i].Cells["priceCol"].Value != null && int.TryParse(menuDGV.Rows[i].Cells["priceCol"].Value.ToString(), out price))
                {
                    int total = quantity * price;
                    totalBeforeTax += total;
                    orderSummaryDGV.Rows.Add(new object[]
                    {
                        menuDGV.Rows[i].Cells["idCol"].Value,
                        menuDGV.Rows[i].Cells["menuCol"].Value,
                        menuDGV.Rows[i].Cells["priceCol"].Value,
                        menuDGV.Rows[i].Cells["quantityCol"].Value,
                        total
                    });
                }
            }
            amountBeforeTaxLabel.Text = "AMOUNT BEFORE TAX : " + totalBeforeTax;
            int tax = (int)(totalBeforeTax * 0.1f);
            total = (totalBeforeTax + tax);
            taxLabel.Text = "TAX (10%) : " + tax;
            totalLabel.Text = "TOTAL : " + total + "";
        }

        private void OnFormLoad(object sender, EventArgs e)
        {
            GetMenu();
        }

        void GetMenu()
        {
            SqlConnection connection = new SqlConnection(Settings.DB_DATA_CONNECTION_STRING);
            string sql = "SELECT * FROM " + Settings.TABLE_MENU + " WHERE active=1";
            SqlDataAdapter dataAdapter = new SqlDataAdapter(sql, connection);
            DataSet ds = new DataSet();
            connection.Open();
            dataAdapter.Fill(ds, Settings.TABLE_MENU);
            connection.Close();
            menuDGV.DataSource = ds;
            menuDGV.DataMember = Settings.TABLE_MENU;
            menuDGV.Columns["idCol"].DisplayIndex = 0;
            menuDGV.Columns["menuCol"].DisplayIndex = 1;
            menuDGV.Columns["priceCol"].DisplayIndex = 2;
            menuDGV.Columns["quantityCol"].DisplayIndex = 3;
        }

        private void menuDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
