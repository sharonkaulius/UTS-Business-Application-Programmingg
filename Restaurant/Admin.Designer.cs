
namespace Restaurant
{
    partial class Admin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.adminTabControl = new System.Windows.Forms.TabControl();
            this.menuTabPage = new System.Windows.Forms.TabPage();
            this.addButton = new System.Windows.Forms.Button();
            this.menuDGV = new System.Windows.Forms.DataGridView();
            this.menuActive = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.editCol = new System.Windows.Forms.DataGridViewButtonColumn();
            this.deleteCol = new System.Windows.Forms.DataGridViewButtonColumn();
            this.reportTabPage = new System.Windows.Forms.TabPage();
            this.searchButton = new System.Windows.Forms.Button();
            this.reportTotalLabel = new System.Windows.Forms.Label();
            this.totalLabel = new System.Windows.Forms.Label();
            this.reportDGV = new System.Windows.Forms.DataGridView();
            this.reportOrderIdCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reportDateCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reportPaymentCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reportPhoneNumberCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reportCardNumberCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reportTotalCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toDTP = new System.Windows.Forms.DateTimePicker();
            this.fromDTP = new System.Windows.Forms.DateTimePicker();
            this.adminTabControl.SuspendLayout();
            this.menuTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.menuDGV)).BeginInit();
            this.reportTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.reportDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // adminTabControl
            // 
            this.adminTabControl.Controls.Add(this.menuTabPage);
            this.adminTabControl.Controls.Add(this.reportTabPage);
            this.adminTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.adminTabControl.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminTabControl.Location = new System.Drawing.Point(0, 0);
            this.adminTabControl.Name = "adminTabControl";
            this.adminTabControl.SelectedIndex = 0;
            this.adminTabControl.Size = new System.Drawing.Size(504, 306);
            this.adminTabControl.TabIndex = 0;
            // 
            // menuTabPage
            // 
            this.menuTabPage.BackColor = System.Drawing.Color.White;
            this.menuTabPage.Controls.Add(this.addButton);
            this.menuTabPage.Controls.Add(this.menuDGV);
            this.menuTabPage.Location = new System.Drawing.Point(4, 24);
            this.menuTabPage.Name = "menuTabPage";
            this.menuTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.menuTabPage.Size = new System.Drawing.Size(496, 278);
            this.menuTabPage.TabIndex = 0;
            this.menuTabPage.Text = "MENU";
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(6, 6);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 1;
            this.addButton.Text = "Add Menu";
            this.addButton.UseVisualStyleBackColor = true;
            // 
            // menuDGV
            // 
            this.menuDGV.AllowUserToAddRows = false;
            this.menuDGV.AllowUserToDeleteRows = false;
            this.menuDGV.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.menuDGV.BackgroundColor = System.Drawing.Color.Lavender;
            this.menuDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.menuDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.menuActive,
            this.idCol,
            this.menuCol,
            this.priceCol,
            this.editCol,
            this.deleteCol});
            this.menuDGV.Location = new System.Drawing.Point(0, 32);
            this.menuDGV.Name = "menuDGV";
            this.menuDGV.ReadOnly = true;
            this.menuDGV.Size = new System.Drawing.Size(496, 212);
            this.menuDGV.TabIndex = 0;
            // 
            // menuActive
            // 
            this.menuActive.DataPropertyName = "active";
            this.menuActive.HeaderText = "ACTIVE";
            this.menuActive.Name = "menuActive";
            this.menuActive.ReadOnly = true;
            this.menuActive.Visible = false;
            // 
            // idCol
            // 
            this.idCol.DataPropertyName = "id";
            this.idCol.FillWeight = 50F;
            this.idCol.HeaderText = "ID";
            this.idCol.Name = "idCol";
            this.idCol.ReadOnly = true;
            // 
            // menuCol
            // 
            this.menuCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.menuCol.DataPropertyName = "menu";
            this.menuCol.HeaderText = "MENU";
            this.menuCol.Name = "menuCol";
            this.menuCol.ReadOnly = true;
            // 
            // priceCol
            // 
            this.priceCol.DataPropertyName = "price";
            this.priceCol.HeaderText = "PRICE";
            this.priceCol.Name = "priceCol";
            this.priceCol.ReadOnly = true;
            // 
            // editCol
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.NullValue = "EDIT";
            this.editCol.DefaultCellStyle = dataGridViewCellStyle5;
            this.editCol.HeaderText = "";
            this.editCol.Name = "editCol";
            this.editCol.ReadOnly = true;
            this.editCol.Text = "EDIT";
            this.editCol.Width = 50;
            // 
            // deleteCol
            // 
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.NullValue = "DELETE";
            this.deleteCol.DefaultCellStyle = dataGridViewCellStyle6;
            this.deleteCol.HeaderText = "";
            this.deleteCol.Name = "deleteCol";
            this.deleteCol.ReadOnly = true;
            this.deleteCol.Text = "DELETE";
            this.deleteCol.Width = 60;
            // 
            // reportTabPage
            // 
            this.reportTabPage.BackColor = System.Drawing.Color.White;
            this.reportTabPage.Controls.Add(this.searchButton);
            this.reportTabPage.Controls.Add(this.reportTotalLabel);
            this.reportTabPage.Controls.Add(this.totalLabel);
            this.reportTabPage.Controls.Add(this.reportDGV);
            this.reportTabPage.Controls.Add(this.toDTP);
            this.reportTabPage.Controls.Add(this.fromDTP);
            this.reportTabPage.Location = new System.Drawing.Point(4, 24);
            this.reportTabPage.Name = "reportTabPage";
            this.reportTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.reportTabPage.Size = new System.Drawing.Size(496, 278);
            this.reportTabPage.TabIndex = 1;
            this.reportTabPage.Text = "REPORT";
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(415, 4);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(75, 23);
            this.searchButton.TabIndex = 5;
            this.searchButton.Text = "SEARCH";
            this.searchButton.UseVisualStyleBackColor = true;
            // 
            // reportTotalLabel
            // 
            this.reportTotalLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.reportTotalLabel.Location = new System.Drawing.Point(0, 225);
            this.reportTotalLabel.Name = "reportTotalLabel";
            this.reportTotalLabel.Size = new System.Drawing.Size(493, 23);
            this.reportTotalLabel.TabIndex = 4;
            this.reportTotalLabel.Text = "Total 1000..000.000";
            this.reportTotalLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // totalLabel
            // 
            this.totalLabel.AutoSize = true;
            this.totalLabel.Location = new System.Drawing.Point(381, 230);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(0, 15);
            this.totalLabel.TabIndex = 3;
            // 
            // reportDGV
            // 
            this.reportDGV.AllowUserToAddRows = false;
            this.reportDGV.AllowUserToDeleteRows = false;
            this.reportDGV.BackgroundColor = System.Drawing.Color.Lavender;
            this.reportDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.reportDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.reportOrderIdCol,
            this.reportDateCol,
            this.reportPaymentCol,
            this.reportPhoneNumberCol,
            this.reportCardNumberCol,
            this.reportTotalCol});
            this.reportDGV.Location = new System.Drawing.Point(0, 32);
            this.reportDGV.Name = "reportDGV";
            this.reportDGV.ReadOnly = true;
            this.reportDGV.Size = new System.Drawing.Size(496, 184);
            this.reportDGV.TabIndex = 2;
            // 
            // reportOrderIdCol
            // 
            this.reportOrderIdCol.DataPropertyName = "id";
            this.reportOrderIdCol.HeaderText = "ORDER ID";
            this.reportOrderIdCol.Name = "reportOrderIdCol";
            this.reportOrderIdCol.ReadOnly = true;
            // 
            // reportDateCol
            // 
            this.reportDateCol.DataPropertyName = "date";
            this.reportDateCol.HeaderText = "DATE";
            this.reportDateCol.Name = "reportDateCol";
            this.reportDateCol.ReadOnly = true;
            // 
            // reportPaymentCol
            // 
            this.reportPaymentCol.DataPropertyName = "payment_type";
            this.reportPaymentCol.HeaderText = "PAYMENT TYPE";
            this.reportPaymentCol.Name = "reportPaymentCol";
            this.reportPaymentCol.ReadOnly = true;
            // 
            // reportPhoneNumberCol
            // 
            this.reportPhoneNumberCol.DataPropertyName = "phone_number";
            this.reportPhoneNumberCol.HeaderText = "PHONE";
            this.reportPhoneNumberCol.Name = "reportPhoneNumberCol";
            this.reportPhoneNumberCol.ReadOnly = true;
            // 
            // reportCardNumberCol
            // 
            this.reportCardNumberCol.DataPropertyName = "card_number";
            this.reportCardNumberCol.HeaderText = "CARD";
            this.reportCardNumberCol.Name = "reportCardNumberCol";
            this.reportCardNumberCol.ReadOnly = true;
            // 
            // reportTotalCol
            // 
            this.reportTotalCol.DataPropertyName = "total";
            this.reportTotalCol.HeaderText = "TOTAL";
            this.reportTotalCol.Name = "reportTotalCol";
            this.reportTotalCol.ReadOnly = true;
            // 
            // toDTP
            // 
            this.toDTP.Location = new System.Drawing.Point(212, 6);
            this.toDTP.Name = "toDTP";
            this.toDTP.Size = new System.Drawing.Size(200, 20);
            this.toDTP.TabIndex = 1;
            // 
            // fromDTP
            // 
            this.fromDTP.Location = new System.Drawing.Point(6, 6);
            this.fromDTP.Name = "fromDTP";
            this.fromDTP.Size = new System.Drawing.Size(200, 20);
            this.fromDTP.TabIndex = 0;
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Salmon;
            this.ClientSize = new System.Drawing.Size(504, 306);
            this.Controls.Add(this.adminTabControl);
            this.Name = "Admin";
            this.Text = "Admin";
            this.adminTabControl.ResumeLayout(false);
            this.menuTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.menuDGV)).EndInit();
            this.reportTabPage.ResumeLayout(false);
            this.reportTabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.reportDGV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl adminTabControl;
        private System.Windows.Forms.TabPage menuTabPage;
        private System.Windows.Forms.TabPage reportTabPage;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.DataGridView menuDGV;
        private System.Windows.Forms.Label reportTotalLabel;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.DataGridView reportDGV;
        private System.Windows.Forms.DateTimePicker toDTP;
        private System.Windows.Forms.DateTimePicker fromDTP;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn reportOrderIdCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn reportDateCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn reportPaymentCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn reportPhoneNumberCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn reportCardNumberCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn reportTotalCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn menuActive;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn menuCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceCol;
        private System.Windows.Forms.DataGridViewButtonColumn editCol;
        private System.Windows.Forms.DataGridViewButtonColumn deleteCol;
    }
}