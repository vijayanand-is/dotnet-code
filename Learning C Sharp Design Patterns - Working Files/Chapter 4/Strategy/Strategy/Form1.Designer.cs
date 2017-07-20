namespace Strategy
{
    partial class Form1
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
            this.chkStudent = new System.Windows.Forms.CheckBox();
            this.numTotalSale = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.btnApplyDiscounts = new System.Windows.Forms.Button();
            this.lblFinalPrice = new System.Windows.Forms.Label();
            this.chkLoyalty = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.numTotalSale)).BeginInit();
            this.SuspendLayout();
            // 
            // chkStudent
            // 
            this.chkStudent.AutoSize = true;
            this.chkStudent.Location = new System.Drawing.Point(18, 18);
            this.chkStudent.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chkStudent.Name = "chkStudent";
            this.chkStudent.Size = new System.Drawing.Size(152, 24);
            this.chkStudent.TabIndex = 0;
            this.chkStudent.Text = "Student Discount";
            this.chkStudent.UseVisualStyleBackColor = true;
            // 
            // numTotalSale
            // 
            this.numTotalSale.DecimalPlaces = 2;
            this.numTotalSale.Location = new System.Drawing.Point(110, 132);
            this.numTotalSale.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.numTotalSale.Name = "numTotalSale";
            this.numTotalSale.Size = new System.Drawing.Size(180, 26);
            this.numTotalSale.TabIndex = 1;
            this.numTotalSale.Value = new decimal(new int[] {
            1999,
            0,
            0,
            131072});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 135);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Total Sale";
            // 
            // btnApplyDiscounts
            // 
            this.btnApplyDiscounts.Location = new System.Drawing.Point(110, 195);
            this.btnApplyDiscounts.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnApplyDiscounts.Name = "btnApplyDiscounts";
            this.btnApplyDiscounts.Size = new System.Drawing.Size(180, 35);
            this.btnApplyDiscounts.TabIndex = 3;
            this.btnApplyDiscounts.Text = "Apply Discounts";
            this.btnApplyDiscounts.UseVisualStyleBackColor = true;
            this.btnApplyDiscounts.Click += new System.EventHandler(this.btnApplyDiscounts_Click);
            // 
            // lblFinalPrice
            // 
            this.lblFinalPrice.AutoSize = true;
            this.lblFinalPrice.Location = new System.Drawing.Point(105, 266);
            this.lblFinalPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFinalPrice.Name = "lblFinalPrice";
            this.lblFinalPrice.Size = new System.Drawing.Size(82, 20);
            this.lblFinalPrice.TabIndex = 4;
            this.lblFinalPrice.Text = "Final Price";
            // 
            // chkLoyalty
            // 
            this.chkLoyalty.AutoSize = true;
            this.chkLoyalty.Location = new System.Drawing.Point(18, 69);
            this.chkLoyalty.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chkLoyalty.Name = "chkLoyalty";
            this.chkLoyalty.Size = new System.Drawing.Size(144, 24);
            this.chkLoyalty.TabIndex = 5;
            this.chkLoyalty.Text = "Loyalty Discount";
            this.chkLoyalty.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(347, 403);
            this.Controls.Add(this.chkLoyalty);
            this.Controls.Add(this.lblFinalPrice);
            this.Controls.Add(this.btnApplyDiscounts);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numTotalSale);
            this.Controls.Add(this.chkStudent);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Strategy Pattern";
            ((System.ComponentModel.ISupportInitialize)(this.numTotalSale)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chkStudent;
        private System.Windows.Forms.NumericUpDown numTotalSale;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnApplyDiscounts;
        private System.Windows.Forms.Label lblFinalPrice;
        private System.Windows.Forms.CheckBox chkLoyalty;
    }
}

