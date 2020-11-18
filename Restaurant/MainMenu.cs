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
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
            if(!CheckDatabaseExists("DB_DATA"))
            {
                CreateDataBase("DB_DATA");
            }
            if (!CheckIfTableExists(Settings.TABLE_MENU))
            {
                CreateMenuTable();
            }
            if(!CheckIfTableExists(Settings.TABLE_ORDER))
            {
                CreateOrderTable();
            }
            if(!CheckIfTableExists(Settings.TABLE_TRANSACTION))
            {
                CreateTransactionTable();
            }
            retailButton.Click += OnRetailButtonClick;
            adminButton.Click += OnAdminButtonClick;
        }

        private void OnAdminButtonClick(object sender, EventArgs e)
        {
            var frm = new Admin();
            frm.Location = this.Location;
            frm.StartPosition = FormStartPosition.Manual;
            frm.FormClosing += delegate { this.Show(); };
            frm.Show();
            this.Hide();
        }

        private void OnRetailButtonClick(object sender, EventArgs e)
        {
            var frm = new Retail();
            frm.Location = this.Location;
            frm.StartPosition = FormStartPosition.Manual;
            frm.FormClosing += delegate { this.Show(); };
            frm.Show();
            this.Hide();
        }

        private static void CreateMenuTable()
        {
            SqlConnection connection = new SqlConnection(Settings.DB_DATA_CONNECTION_STRING);
            connection.Open();
            SqlCommand cmd = new SqlCommand(@"CREATE TABLE " + Settings.TABLE_MENU + @"(
                id INT PRIMARY KEY IDENTITY (1,1),
                menu VARCHAR(100) NOT NULL,
                price INT NOT NULL,
                active INT DEFAULT 1)", connection);
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch(SqlException ex)
            {
                MessageBox.Show("menu - " + ex.Message.ToString());
            }
        }

        private static void CreateOrderTable()
        {
            SqlConnection connection = new SqlConnection(Settings.DB_DATA_CONNECTION_STRING);
            connection.Open();
            SqlCommand cmd = new SqlCommand(@"CREATE TABLE " + Settings.TABLE_ORDER + @"(
                id INT PRIMARY KEY IDENTITY (1,1),
                total INT NOT NULL,
                payment_type VARCHAR(50) NOT NULL,
                date DATETIME NOT NULL DEFAULT CURRENT_TIMESTAMP,
                phone_number VARCHAR(50),
                card_number VARCHAR(50))", connection);
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("order -" + ex.Message.ToString());
            }
        }

        private static void CreateTransactionTable()
        {
            SqlConnection connection = new SqlConnection(Settings.DB_DATA_CONNECTION_STRING);
            connection.Open();
            SqlCommand cmd = new SqlCommand(@"CREATE TABLE " + Settings.TABLE_TRANSACTION + @"(
                id INT PRIMARY KEY IDENTITY (1,1),
                orderId INT NOT NULL,
                menuId INT NOT NULL,
                price INT NOT NULL,
                quantity INT NOT NULL,
                date DATETIME NOT NULL DEFAULT CURRENT_TIMESTAMP,
                FOREIGN KEY (menuId) REFERENCES " + Settings.TABLE_MENU + @"(id),
                FOREIGN KEY (orderId) REFERENCES " + Settings.TABLE_ORDER + @"(id))", connection);
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("transaction -" + ex.Message.ToString());
            }
        }

        private static bool CheckIfTableExists(string tblName)
        {
            SqlConnection connection = new SqlConnection(Settings.DB_DATA_CONNECTION_STRING);
            connection.Open();
            SqlCommand cmd = new SqlCommand(@"IF EXISTS(
              SELECT 1 FROM INFORMATION_SCHEMA.TABLES 
              WHERE TABLE_NAME = @table) 
              SELECT 1 ELSE SELECT 0", connection);
            cmd.Parameters.Add("@table", SqlDbType.NVarChar).Value = tblName;
            try
            {
                int exists = (int)cmd.ExecuteScalar();
                return exists == 1;
            }
            catch(SqlException ex)
            {
                MessageBox.Show(ex.ToString(), "Program", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
        }

        private static bool CreateDataBase(string dbName)
        {
            SqlConnection connection = new SqlConnection(Settings.MASTER_CONNECTION_STRING);
            string str = "CREATE DATABASE " + dbName;
            SqlCommand myCommand = new SqlCommand(str, connection);
            try
            {
                connection.Open();
                myCommand.ExecuteNonQuery();
                return true;
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Program", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }

        public static bool CheckDatabaseExists(string databaseName)
        {
            using (var connection = new SqlConnection(Settings.MASTER_CONNECTION_STRING))
            {
                using (var command = new SqlCommand($"SELECT db_id('{databaseName}')", connection))
                {
                    connection.Open();
                    return (command.ExecuteScalar() != DBNull.Value);
                }
            }
        }
    }
}
