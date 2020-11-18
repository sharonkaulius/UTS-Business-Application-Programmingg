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
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
            adminTabControl.SelectedIndexChanged += OnAdminTabSelectedIndexChanged;
            menuDGV.CellContentClick += OnMenuCellContentClicked;
            RefreshMenuTable();
            RefreshReportTable();
            addButton.Click += OnAddMenuClick;
            searchButton.Click += OnSearchButtonClick;
        }

        private void OnSearchButtonClick(object sender, EventArgs e)
        {
            RefreshReportTable();
        }

        private void OnAdminTabSelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshMenuTable();
            RefreshReportTable();
        }

        private void OnAddMenuClick(object sender, EventArgs e)
        {
            Form form = new AddOrEditMenuForm();
            form.FormClosing += OnAddOrEditMenuFormClose;
            form.ShowDialog();
        }

        private void OnAddOrEditMenuFormClose(object sender, FormClosingEventArgs e)
        {
            RefreshMenuTable();
        }

        void RefreshReportTable()
        {
            SqlConnection connection = new SqlConnection(Settings.DB_DATA_CONNECTION_STRING);
            string sql = @"SELECT * FROM " + Settings.TABLE_ORDER + 
                @" WHERE date >= @fromDate and date <= @toDate";
            SqlCommand sqlCommand = new SqlCommand(sql, connection);
            DateTime toDtv = toDTP.Value.Date.AddHours(23).AddMinutes(50).AddSeconds(59).AddMilliseconds(999);
            DateTime fromDtv = fromDTP.Value.Date.AddHours(0).AddMinutes(0).AddSeconds(0).AddMilliseconds(0);
            sqlCommand.Parameters.Add("@fromDate", SqlDbType.DateTime).Value = fromDtv;
            sqlCommand.Parameters.Add("@toDate", SqlDbType.DateTime).Value = toDtv;
            SqlDataAdapter dataAdapter = new SqlDataAdapter(sqlCommand);
            DataSet ds = new DataSet();
            connection.Open();
            dataAdapter.Fill(ds, Settings.TABLE_ORDER);
            connection.Close();
            reportDGV.ReadOnly = true;
            reportDGV.DataSource = ds;
            reportDGV.DataMember = Settings.TABLE_ORDER;

            reportDGV.Columns["reportOrderIdCol"].DisplayIndex = 0;
            reportDGV.Columns["reportDateCol"].DisplayIndex = 1;
            reportDGV.Columns["reportPaymentCol"].DisplayIndex = 2;
            reportDGV.Columns["reportPhoneNumberCol"].DisplayIndex = 3;
            reportDGV.Columns["reportCardNumberCol"].DisplayIndex = 4;
            reportDGV.Columns["reportTotalCol"].DisplayIndex = 5;

            int total = 0;
            for(int i = 0; i < reportDGV.Rows.Count; i++)
            {
                total += (int)reportDGV.Rows[i].Cells["reportTotalCol"].Value;
            }

            reportTotalLabel.Text = "TOTAL : " + total;
        }

        void RefreshMenuTable()
        {
            SqlConnection connection = new SqlConnection(Settings.DB_DATA_CONNECTION_STRING);
            string sql = "SELECT * FROM " + Settings.TABLE_MENU + " WHERE active=1";
            SqlDataAdapter dataAdapter = new SqlDataAdapter(sql, connection);
            DataSet ds = new DataSet();
            connection.Open();
            dataAdapter.Fill(ds, Settings.TABLE_MENU);
            connection.Close();
            menuDGV.ReadOnly = true;
            menuDGV.DataSource = ds;
            menuDGV.DataMember = Settings.TABLE_MENU;
            menuDGV.Columns["idCol"].DisplayIndex = 0;
            menuDGV.Columns["menuCol"].DisplayIndex = 1;
            menuDGV.Columns["priceCol"].DisplayIndex = 2;
            menuDGV.Columns["editCol"].DisplayIndex = 3;
            menuDGV.Columns["deleteCol"].DisplayIndex = 4;
        }
        private void OnMenuCellContentClicked(object sender, DataGridViewCellEventArgs e)
        {
            if (menuDGV.Columns["editCol"].Index == e.ColumnIndex &&
                !string.IsNullOrEmpty(menuDGV.Rows[e.RowIndex].Cells["idCol"].Value.ToString()))
            {
                Form form = new AddOrEditMenuForm(
                    (int)menuDGV.Rows[e.RowIndex].Cells["idCol"].Value,
                    (string)menuDGV.Rows[e.RowIndex].Cells["menuCol"].Value,
                    (int)menuDGV.Rows[e.RowIndex].Cells["priceCol"].Value
                    );
                form.FormClosing += OnAddOrEditMenuFormClose;
                form.ShowDialog();
            }
            else if(menuDGV.Columns["deleteCol"].Index == e.ColumnIndex && 
               !string.IsNullOrEmpty(menuDGV.Rows[e.RowIndex].Cells["idCol"].Value.ToString()))
            {
                    SqlConnection connection = new SqlConnection(Settings.DB_DATA_CONNECTION_STRING);
                    SqlCommand cmd = new SqlCommand(@"UPDATE " + Settings.TABLE_MENU + 
                        @" SET active=0 WHERE id=@id", connection);
                    connection.Open();
                    cmd.Parameters.Add("@id", SqlDbType.Int).Value = (int)menuDGV.Rows[e.RowIndex].Cells["idCol"].Value;
                    try
                    {
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("delete success");
                        RefreshMenuTable();
                    }
                    catch(SqlException ex)
                    {
                        MessageBox.Show("delete failed - " + ex.Message.ToString());
                    }
            }
        }
    }
}
