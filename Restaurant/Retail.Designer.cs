
namespace Restaurant
{
    partial class Retail
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.retailTabControl = new System.Windows.Forms.TabControl();
            this.placeOrderTab = new System.Windows.Forms.TabPage();
            this.menuDGV = new System.Windows.Forms.DataGridView();
            this.activeCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.confirmOrderTab = new System.Windows.Forms.TabPage();
            this.amountBeforeTaxLabel = new System.Windows.Forms.Label();
            this.taxLabel = new System.Windows.Forms.Label();
            this.totalLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.orderSummaryDGV = new System.Windows.Forms.DataGridView();
            this.summaryIDCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.summaryMenuCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.summaryPriceCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.summaryQuantityCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.summaryTotalCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paymentTab = new System.Windows.Forms.TabPage();
            this.ovoGroup = new System.Windows.Forms.GroupBox();
            this.phoneNumberTextbox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cardGroup = new System.Windows.Forms.GroupBox();
            this.cardNumbeTextbox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.submitOrderButton = new System.Windows.Forms.Button();
            this.amountDueLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cashGroup = new System.Windows.Forms.GroupBox();
            this.changeLabel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.amountPaidNumeric = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.paymentComboBox = new System.Windows.Forms.ComboBox();
            this.retailTabControl.SuspendLayout();
            this.placeOrderTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.menuDGV)).BeginInit();
            this.confirmOrderTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.orderSummaryDGV)).BeginInit();
            this.paymentTab.SuspendLayout();
            this.ovoGroup.SuspendLayout();
            this.cardGroup.SuspendLayout();
            this.cashGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.amountPaidNumeric)).BeginInit();
            this.SuspendLayout();
            // 
            // retailTabControl
            // 
            this.retailTabControl.Controls.Add(this.placeOrderTab);
            this.retailTabControl.Controls.Add(this.confirmOrderTab);
            this.retailTabControl.Controls.Add(this.paymentTab);
            this.retailTabControl.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.retailTabControl.Location = new System.Drawing.Point(12, 12);
            this.retailTabControl.Name = "retailTabControl";
            this.retailTabControl.SelectedIndex = 0;
            this.retailTabControl.Size = new System.Drawing.Size(496, 294);
            this.retailTabControl.TabIndex = 1;
            // 
            // placeOrderTab
            // 
            this.placeOrderTab.BackColor = System.Drawing.Color.White;
            this.placeOrderTab.Controls.Add(this.menuDGV);
            this.placeOrderTab.Controls.Add(this.label2);
            this.placeOrderTab.Location = new System.Drawing.Point(4, 24);
            this.placeOrderTab.Name = "placeOrderTab";
            this.placeOrderTab.Padding = new System.Windows.Forms.Padding(3);
            this.placeOrderTab.Size = new System.Drawing.Size(488, 266);
            this.placeOrderTab.TabIndex = 0;
            this.placeOrderTab.Text = "PLACE YOUR ORDER";
            // 
            // menuDGV
            // 
            this.menuDGV.AllowUserToAddRows = false;
            this.menuDGV.AllowUserToDeleteRows = false;
            this.menuDGV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.menuDGV.BackgroundColor = System.Drawing.Color.Lavender;
            this.menuDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.menuDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.activeCol,
            this.idCol,
            this.menuCol,
            this.priceCol,
            this.quantityCol});
            this.menuDGV.Location = new System.Drawing.Point(0, 19);
            this.menuDGV.Name = "menuDGV";
            this.menuDGV.Size = new System.Drawing.Size(488, 226);
            this.menuDGV.TabIndex = 3;
            this.menuDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.menuDGV_CellContentClick);
            // 
            // activeCol
            // 
            this.activeCol.DataPropertyName = "active";
            this.activeCol.HeaderText = "ACTIVE";
            this.activeCol.Name = "activeCol";
            this.activeCol.Visible = false;
            // 
            // idCol
            // 
            this.idCol.DataPropertyName = "id";
            this.idCol.HeaderText = "ID";
            this.idCol.Name = "idCol";
            this.idCol.Visible = false;
            // 
            // menuCol
            // 
            this.menuCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.menuCol.DataPropertyName = "menu";
            this.menuCol.HeaderText = "Menu";
            this.menuCol.Name = "menuCol";
            this.menuCol.ReadOnly = true;
            // 
            // priceCol
            // 
            this.priceCol.DataPropertyName = "price";
            this.priceCol.HeaderText = "Price";
            this.priceCol.Name = "priceCol";
            this.priceCol.ReadOnly = true;
            // 
            // quantityCol
            // 
            dataGridViewCellStyle3.NullValue = "0";
            this.quantityCol.DefaultCellStyle = dataGridViewCellStyle3;
            this.quantityCol.HeaderText = "Quantity";
            this.quantityCol.Name = "quantityCol";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "MENU";
            // 
            // confirmOrderTab
            // 
            this.confirmOrderTab.Controls.Add(this.amountBeforeTaxLabel);
            this.confirmOrderTab.Controls.Add(this.taxLabel);
            this.confirmOrderTab.Controls.Add(this.totalLabel);
            this.confirmOrderTab.Controls.Add(this.label1);
            this.confirmOrderTab.Controls.Add(this.orderSummaryDGV);
            this.confirmOrderTab.Location = new System.Drawing.Point(4, 24);
            this.confirmOrderTab.Name = "confirmOrderTab";
            this.confirmOrderTab.Padding = new System.Windows.Forms.Padding(3);
            this.confirmOrderTab.Size = new System.Drawing.Size(488, 266);
            this.confirmOrderTab.TabIndex = 1;
            this.confirmOrderTab.Text = "CONFIRM YOUR ORDER";
            this.confirmOrderTab.UseVisualStyleBackColor = true;
            // 
            // amountBeforeTaxLabel
            // 
            this.amountBeforeTaxLabel.Location = new System.Drawing.Point(6, 194);
            this.amountBeforeTaxLabel.Name = "amountBeforeTaxLabel";
            this.amountBeforeTaxLabel.Size = new System.Drawing.Size(476, 23);
            this.amountBeforeTaxLabel.TabIndex = 4;
            this.amountBeforeTaxLabel.Text = "AMOUNT BEFORE TAX: 0";
            this.amountBeforeTaxLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // taxLabel
            // 
            this.taxLabel.Location = new System.Drawing.Point(6, 217);
            this.taxLabel.Name = "taxLabel";
            this.taxLabel.Size = new System.Drawing.Size(476, 23);
            this.taxLabel.TabIndex = 3;
            this.taxLabel.Text = "TAX (10%): 0";
            this.taxLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // totalLabel
            // 
            this.totalLabel.Location = new System.Drawing.Point(6, 240);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(476, 23);
            this.totalLabel.TabIndex = 2;
            this.totalLabel.Text = "TOTAL : 0";
            this.totalLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "ORDER SUMMARY";
            // 
            // orderSummaryDGV
            // 
            this.orderSummaryDGV.AllowUserToAddRows = false;
            this.orderSummaryDGV.AllowUserToDeleteRows = false;
            this.orderSummaryDGV.BackgroundColor = System.Drawing.Color.Lavender;
            this.orderSummaryDGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.orderSummaryDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.orderSummaryDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.summaryIDCol,
            this.summaryMenuCol,
            this.summaryPriceCol,
            this.summaryQuantityCol,
            this.summaryTotalCol});
            this.orderSummaryDGV.Location = new System.Drawing.Point(6, 19);
            this.orderSummaryDGV.Name = "orderSummaryDGV";
            this.orderSummaryDGV.ReadOnly = true;
            this.orderSummaryDGV.Size = new System.Drawing.Size(476, 173);
            this.orderSummaryDGV.TabIndex = 0;
            // 
            // summaryIDCol
            // 
            this.summaryIDCol.HeaderText = "ID";
            this.summaryIDCol.Name = "summaryIDCol";
            this.summaryIDCol.ReadOnly = true;
            this.summaryIDCol.Visible = false;
            // 
            // summaryMenuCol
            // 
            this.summaryMenuCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.summaryMenuCol.HeaderText = "MENU";
            this.summaryMenuCol.Name = "summaryMenuCol";
            this.summaryMenuCol.ReadOnly = true;
            // 
            // summaryPriceCol
            // 
            this.summaryPriceCol.HeaderText = "PRICE";
            this.summaryPriceCol.Name = "summaryPriceCol";
            this.summaryPriceCol.ReadOnly = true;
            // 
            // summaryQuantityCol
            // 
            this.summaryQuantityCol.HeaderText = "QUANTITY";
            this.summaryQuantityCol.Name = "summaryQuantityCol";
            this.summaryQuantityCol.ReadOnly = true;
            // 
            // summaryTotalCol
            // 
            this.summaryTotalCol.HeaderText = "TOTAL";
            this.summaryTotalCol.Name = "summaryTotalCol";
            this.summaryTotalCol.ReadOnly = true;
            // 
            // paymentTab
            // 
            this.paymentTab.Controls.Add(this.ovoGroup);
            this.paymentTab.Controls.Add(this.cardGroup);
            this.paymentTab.Controls.Add(this.submitOrderButton);
            this.paymentTab.Controls.Add(this.amountDueLabel);
            this.paymentTab.Controls.Add(this.label4);
            this.paymentTab.Controls.Add(this.cashGroup);
            this.paymentTab.Controls.Add(this.label3);
            this.paymentTab.Controls.Add(this.paymentComboBox);
            this.paymentTab.Location = new System.Drawing.Point(4, 24);
            this.paymentTab.Name = "paymentTab";
            this.paymentTab.Padding = new System.Windows.Forms.Padding(3);
            this.paymentTab.Size = new System.Drawing.Size(488, 266);
            this.paymentTab.TabIndex = 2;
            this.paymentTab.Text = "MAKE PAYMENT";
            this.paymentTab.UseVisualStyleBackColor = true;
            // 
            // ovoGroup
            // 
            this.ovoGroup.Controls.Add(this.phoneNumberTextbox);
            this.ovoGroup.Controls.Add(this.label8);
            this.ovoGroup.Location = new System.Drawing.Point(266, 66);
            this.ovoGroup.Name = "ovoGroup";
            this.ovoGroup.Size = new System.Drawing.Size(251, 121);
            this.ovoGroup.TabIndex = 4;
            this.ovoGroup.TabStop = false;
            this.ovoGroup.Text = "OVO";
            // 
            // phoneNumberTextbox
            // 
            this.phoneNumberTextbox.Location = new System.Drawing.Point(110, 25);
            this.phoneNumberTextbox.Name = "phoneNumberTextbox";
            this.phoneNumberTextbox.Size = new System.Drawing.Size(100, 20);
            this.phoneNumberTextbox.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 29);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 15);
            this.label8.TabIndex = 0;
            this.label8.Text = "PHONE  NUMBER";
            // 
            // cardGroup
            // 
            this.cardGroup.Controls.Add(this.cardNumbeTextbox);
            this.cardGroup.Controls.Add(this.label9);
            this.cardGroup.Location = new System.Drawing.Point(392, 66);
            this.cardGroup.Name = "cardGroup";
            this.cardGroup.Size = new System.Drawing.Size(251, 121);
            this.cardGroup.TabIndex = 5;
            this.cardGroup.TabStop = false;
            this.cardGroup.Text = "DEBIT/CREDIT";
            // 
            // cardNumbeTextbox
            // 
            this.cardNumbeTextbox.Location = new System.Drawing.Point(113, 26);
            this.cardNumbeTextbox.Name = "cardNumbeTextbox";
            this.cardNumbeTextbox.Size = new System.Drawing.Size(100, 20);
            this.cardNumbeTextbox.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(9, 30);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(80, 15);
            this.label9.TabIndex = 2;
            this.label9.Text = "CARD NUMBER";
            // 
            // submitOrderButton
            // 
            this.submitOrderButton.BackColor = System.Drawing.Color.LightBlue;
            this.submitOrderButton.Location = new System.Drawing.Point(11, 193);
            this.submitOrderButton.Name = "submitOrderButton";
            this.submitOrderButton.Size = new System.Drawing.Size(104, 23);
            this.submitOrderButton.TabIndex = 5;
            this.submitOrderButton.Text = "SUBMIT ORDER";
            this.submitOrderButton.UseVisualStyleBackColor = false;
            // 
            // amountDueLabel
            // 
            this.amountDueLabel.AutoSize = true;
            this.amountDueLabel.Location = new System.Drawing.Point(136, 15);
            this.amountDueLabel.Name = "amountDueLabel";
            this.amountDueLabel.Size = new System.Drawing.Size(12, 15);
            this.amountDueLabel.TabIndex = 4;
            this.amountDueLabel.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "AMOUNT DUE";
            // 
            // cashGroup
            // 
            this.cashGroup.Controls.Add(this.changeLabel);
            this.cashGroup.Controls.Add(this.label6);
            this.cashGroup.Controls.Add(this.amountPaidNumeric);
            this.cashGroup.Controls.Add(this.label5);
            this.cashGroup.Location = new System.Drawing.Point(9, 66);
            this.cashGroup.Name = "cashGroup";
            this.cashGroup.Size = new System.Drawing.Size(251, 121);
            this.cashGroup.TabIndex = 2;
            this.cashGroup.TabStop = false;
            this.cashGroup.Text = "CASH";
            // 
            // changeLabel
            // 
            this.changeLabel.Location = new System.Drawing.Point(130, 56);
            this.changeLabel.Name = "changeLabel";
            this.changeLabel.Size = new System.Drawing.Size(121, 13);
            this.changeLabel.TabIndex = 3;
            this.changeLabel.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 56);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 15);
            this.label6.TabIndex = 2;
            this.label6.Text = "CHANGE";
            // 
            // amountPaidNumeric
            // 
            this.amountPaidNumeric.Location = new System.Drawing.Point(131, 25);
            this.amountPaidNumeric.Maximum = new decimal(new int[] {
            1215752191,
            23,
            0,
            0});
            this.amountPaidNumeric.Name = "amountPaidNumeric";
            this.amountPaidNumeric.Size = new System.Drawing.Size(120, 20);
            this.amountPaidNumeric.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 15);
            this.label5.TabIndex = 0;
            this.label5.Text = "AMOUNT PAID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 15);
            this.label3.TabIndex = 1;
            this.label3.Text = "PAYMENT METHOD";
            // 
            // paymentComboBox
            // 
            this.paymentComboBox.FormattingEnabled = true;
            this.paymentComboBox.Items.AddRange(new object[] {
            "CASH",
            "CREDIT/DEBIT",
            "OVO"});
            this.paymentComboBox.Location = new System.Drawing.Point(139, 38);
            this.paymentComboBox.Name = "paymentComboBox";
            this.paymentComboBox.Size = new System.Drawing.Size(121, 23);
            this.paymentComboBox.TabIndex = 0;
            // 
            // Retail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Salmon;
            this.ClientSize = new System.Drawing.Size(520, 318);
            this.Controls.Add(this.retailTabControl);
            this.Name = "Retail";
            this.Text = "Retail";
            this.retailTabControl.ResumeLayout(false);
            this.placeOrderTab.ResumeLayout(false);
            this.placeOrderTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.menuDGV)).EndInit();
            this.confirmOrderTab.ResumeLayout(false);
            this.confirmOrderTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.orderSummaryDGV)).EndInit();
            this.paymentTab.ResumeLayout(false);
            this.paymentTab.PerformLayout();
            this.ovoGroup.ResumeLayout(false);
            this.ovoGroup.PerformLayout();
            this.cardGroup.ResumeLayout(false);
            this.cardGroup.PerformLayout();
            this.cashGroup.ResumeLayout(false);
            this.cashGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.amountPaidNumeric)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl retailTabControl;
        private System.Windows.Forms.TabPage placeOrderTab;
        private System.Windows.Forms.TabPage confirmOrderTab;
        private System.Windows.Forms.TabPage paymentTab;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView menuDGV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView orderSummaryDGV;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.Label amountBeforeTaxLabel;
        private System.Windows.Forms.Label taxLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn summaryIDCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn summaryMenuCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn summaryPriceCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn summaryQuantityCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn summaryTotalCol;
        private System.Windows.Forms.Button submitOrderButton;
        private System.Windows.Forms.Label amountDueLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox cashGroup;
        private System.Windows.Forms.GroupBox ovoGroup;
        private System.Windows.Forms.GroupBox cardGroup;
        private System.Windows.Forms.TextBox cardNumbeTextbox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox phoneNumberTextbox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label changeLabel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown amountPaidNumeric;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox paymentComboBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn activeCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn menuCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityCol;
    }
}