namespace Decorator
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rad16RAM = new System.Windows.Forms.RadioButton();
            this.rad8RAM = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rad512SSD = new System.Windows.Forms.RadioButton();
            this.rad256SSD = new System.Windows.Forms.RadioButton();
            this.rad128SSD = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblModel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.chkApplyDiscount = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rad16RAM);
            this.groupBox1.Controls.Add(this.rad8RAM);
            this.groupBox1.Location = new System.Drawing.Point(18, 18);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(372, 108);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Memory";
            // 
            // rad16RAM
            // 
            this.rad16RAM.AutoSize = true;
            this.rad16RAM.Location = new System.Drawing.Point(9, 63);
            this.rad16RAM.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rad16RAM.Name = "rad16RAM";
            this.rad16RAM.Size = new System.Drawing.Size(152, 24);
            this.rad16RAM.TabIndex = 1;
            this.rad16RAM.TabStop = true;
            this.rad16RAM.Text = "16 GBytes ($150)";
            this.rad16RAM.UseVisualStyleBackColor = true;
            this.rad16RAM.CheckedChanged += new System.EventHandler(this.option_CheckedChanged);
            // 
            // rad8RAM
            // 
            this.rad8RAM.AutoSize = true;
            this.rad8RAM.Checked = true;
            this.rad8RAM.Location = new System.Drawing.Point(9, 29);
            this.rad8RAM.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rad8RAM.Name = "rad8RAM";
            this.rad8RAM.Size = new System.Drawing.Size(134, 24);
            this.rad8RAM.TabIndex = 0;
            this.rad8RAM.TabStop = true;
            this.rad8RAM.Text = "8 GBytes ($70)";
            this.rad8RAM.UseVisualStyleBackColor = true;
            this.rad8RAM.CheckedChanged += new System.EventHandler(this.option_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rad512SSD);
            this.groupBox2.Controls.Add(this.rad256SSD);
            this.groupBox2.Controls.Add(this.rad128SSD);
            this.groupBox2.Location = new System.Drawing.Point(18, 136);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Size = new System.Drawing.Size(372, 145);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Storage";
            // 
            // rad512SSD
            // 
            this.rad512SSD.AutoSize = true;
            this.rad512SSD.Location = new System.Drawing.Point(8, 106);
            this.rad512SSD.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rad512SSD.Name = "rad512SSD";
            this.rad512SSD.Size = new System.Drawing.Size(191, 24);
            this.rad512SSD.TabIndex = 4;
            this.rad512SSD.TabStop = true;
            this.rad512SSD.Text = "512 GByte SSD ($223)";
            this.rad512SSD.UseVisualStyleBackColor = true;
            this.rad512SSD.CheckedChanged += new System.EventHandler(this.option_CheckedChanged);
            // 
            // rad256SSD
            // 
            this.rad256SSD.AutoSize = true;
            this.rad256SSD.Location = new System.Drawing.Point(8, 72);
            this.rad256SSD.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rad256SSD.Name = "rad256SSD";
            this.rad256SSD.Size = new System.Drawing.Size(191, 24);
            this.rad256SSD.TabIndex = 3;
            this.rad256SSD.TabStop = true;
            this.rad256SSD.Text = "256 GByte SSD ($120)";
            this.rad256SSD.UseVisualStyleBackColor = true;
            this.rad256SSD.CheckedChanged += new System.EventHandler(this.option_CheckedChanged);
            // 
            // rad128SSD
            // 
            this.rad128SSD.AutoSize = true;
            this.rad128SSD.Checked = true;
            this.rad128SSD.Location = new System.Drawing.Point(8, 38);
            this.rad128SSD.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rad128SSD.Name = "rad128SSD";
            this.rad128SSD.Size = new System.Drawing.Size(182, 24);
            this.rad128SSD.TabIndex = 2;
            this.rad128SSD.TabStop = true;
            this.rad128SSD.Text = "128 GByte SSD ($74)";
            this.rad128SSD.UseVisualStyleBackColor = true;
            this.rad128SSD.CheckedChanged += new System.EventHandler(this.option_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 331);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Total:";
            // 
            // lblTotal
            // 
            this.lblTotal.Location = new System.Drawing.Point(318, 331);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(72, 20);
            this.lblTotal.TabIndex = 2;
            this.lblTotal.Text = "$0";
            this.lblTotal.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblModel
            // 
            this.lblModel.AutoSize = true;
            this.lblModel.Location = new System.Drawing.Point(22, 388);
            this.lblModel.Name = "lblModel";
            this.lblModel.Size = new System.Drawing.Size(52, 20);
            this.lblModel.TabIndex = 4;
            this.lblModel.Text = "Model";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 368);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Model #:";
            // 
            // chkApplyDiscount
            // 
            this.chkApplyDiscount.AutoSize = true;
            this.chkApplyDiscount.Location = new System.Drawing.Point(27, 289);
            this.chkApplyDiscount.Name = "chkApplyDiscount";
            this.chkApplyDiscount.Size = new System.Drawing.Size(134, 24);
            this.chkApplyDiscount.TabIndex = 5;
            this.chkApplyDiscount.Text = "Apply Discount";
            this.chkApplyDiscount.UseVisualStyleBackColor = true;
            this.chkApplyDiscount.CheckedChanged += new System.EventHandler(this.option_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 417);
            this.Controls.Add(this.chkApplyDiscount);
            this.Controls.Add(this.lblModel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Decorator Pattern";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rad16RAM;
        private System.Windows.Forms.RadioButton rad8RAM;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rad512SSD;
        private System.Windows.Forms.RadioButton rad256SSD;
        private System.Windows.Forms.RadioButton rad128SSD;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblModel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox chkApplyDiscount;
    }
}

