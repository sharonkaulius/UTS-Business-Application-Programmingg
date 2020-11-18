
namespace Restaurant
{
    partial class AddOrEditMenuForm
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
            this.idLabel = new System.Windows.Forms.Label();
            this.idLabelValue = new System.Windows.Forms.Label();
            this.menuLabel = new System.Windows.Forms.Label();
            this.priceLabel = new System.Windows.Forms.Label();
            this.saveButton = new System.Windows.Forms.Button();
            this.menuTextbox = new System.Windows.Forms.TextBox();
            this.priceNum = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.priceNum)).BeginInit();
            this.SuspendLayout();
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idLabel.Location = new System.Drawing.Point(35, 20);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(16, 14);
            this.idLabel.TabIndex = 0;
            this.idLabel.Text = "ID";
            // 
            // idLabelValue
            // 
            this.idLabelValue.AutoSize = true;
            this.idLabelValue.Location = new System.Drawing.Point(99, 20);
            this.idLabelValue.Name = "idLabelValue";
            this.idLabelValue.Size = new System.Drawing.Size(0, 13);
            this.idLabelValue.TabIndex = 1;
            // 
            // menuLabel
            // 
            this.menuLabel.AutoSize = true;
            this.menuLabel.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuLabel.Location = new System.Drawing.Point(35, 46);
            this.menuLabel.Name = "menuLabel";
            this.menuLabel.Size = new System.Drawing.Size(33, 14);
            this.menuLabel.TabIndex = 2;
            this.menuLabel.Text = "Menu";
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceLabel.Location = new System.Drawing.Point(35, 73);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(31, 14);
            this.priceLabel.TabIndex = 3;
            this.priceLabel.Text = "Price";
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(38, 100);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 4;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            // 
            // menuTextbox
            // 
            this.menuTextbox.Location = new System.Drawing.Point(116, 43);
            this.menuTextbox.Name = "menuTextbox";
            this.menuTextbox.Size = new System.Drawing.Size(100, 20);
            this.menuTextbox.TabIndex = 5;
            // 
            // priceNum
            // 
            this.priceNum.Location = new System.Drawing.Point(116, 71);
            this.priceNum.Maximum = new decimal(new int[] {
            -1530494977,
            232830,
            0,
            0});
            this.priceNum.Name = "priceNum";
            this.priceNum.Size = new System.Drawing.Size(100, 20);
            this.priceNum.TabIndex = 7;
            // 
            // AddOrEditMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(279, 169);
            this.Controls.Add(this.priceNum);
            this.Controls.Add(this.menuTextbox);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.priceLabel);
            this.Controls.Add(this.menuLabel);
            this.Controls.Add(this.idLabelValue);
            this.Controls.Add(this.idLabel);
            this.Name = "AddOrEditMenuForm";
            this.Text = "AddOrEditMenuForm";
            ((System.ComponentModel.ISupportInitialize)(this.priceNum)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.Label idLabelValue;
        private System.Windows.Forms.Label menuLabel;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.TextBox menuTextbox;
        private System.Windows.Forms.NumericUpDown priceNum;
    }
}