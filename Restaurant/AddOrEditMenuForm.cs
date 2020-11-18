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
    public partial class AddOrEditMenuForm : Form
    {
        int id = -1;
        string menu = "";
        int price = 0;
        public AddOrEditMenuForm()
        {
            Init();
        }

        public AddOrEditMenuForm(int id, string menu, int price)
        {
            this.id = id;
            this.menu = menu;
            this.price = price;
            Init();
        }

        private void Init()
        {
            InitializeComponent();
            saveButton.Click += OnSaveButtonClick;
            this.Load += OnFormLoaded;
        }
        private void OnFormLoaded(object sender, EventArgs e)
        {
            if(this.id == -1)
            {
                idLabel.Visible = false;
                idLabelValue.Visible = false;
            }
            else
            {
                idLabelValue.Text = this.id + "";
                menuTextbox.Text = this.menu;
                priceNum.Value = this.price;
            }
        }

        private void OnSaveButtonClick(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(menuTextbox.Text.Trim()) &&
                priceNum.Value <= 0)
            {
                MessageBox.Show("Invalid form input", "Invalid");
                return;
            }
            if(this.id == -1)
            {
                SqlConnection connection = new SqlConnection(Settings.DB_DATA_CONNECTION_STRING);
                SqlCommand cmd = new SqlCommand(@"INSERT INTO " + Settings.TABLE_MENU + 
                    @" (menu, price) VALUES(@menu, @price)", connection);
                connection.Open();
                cmd.Parameters.Add("@menu", SqlDbType.VarChar, 50).Value = menuTextbox.Text.Trim();
                cmd.Parameters.Add("@price", SqlDbType.Int).Value = priceNum.Value;
                try
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Save succes");
                    this.Close();
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Add new menu failed - " + ex.Message.ToString());
                }
            }
            else
            {
                SqlConnection connection = new SqlConnection(Settings.DB_DATA_CONNECTION_STRING);
                SqlCommand cmd = new SqlCommand(@"UPDATE " + Settings.TABLE_MENU + 
                    @" SET menu=@menu, price=@price WHERE id=@id", connection);
                connection.Open();
                cmd.Parameters.Add("@menu", SqlDbType.VarChar, 50).Value = menuTextbox.Text.Trim();
                cmd.Parameters.Add("@price", SqlDbType.Int).Value = priceNum.Value;
                cmd.Parameters.Add("@id", SqlDbType.Int).Value = this.id;
                try
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Save succes");
                    this.Close();
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Update menu failed - " + ex.Message.ToString());
                }
            }
        }
    }
}
