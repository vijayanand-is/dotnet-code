namespace Observer
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblObserver1 = new System.Windows.Forms.Label();
            this.numPrice = new System.Windows.Forms.NumericUpDown();
            this.btnSetNewPrice = new System.Windows.Forms.Button();
            this.lblObserver2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numPrice)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Price";
            // 
            // lblObserver1
            // 
            this.lblObserver1.AutoSize = true;
            this.lblObserver1.Location = new System.Drawing.Point(18, 182);
            this.lblObserver1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblObserver1.Name = "lblObserver1";
            this.lblObserver1.Size = new System.Drawing.Size(90, 20);
            this.lblObserver1.TabIndex = 1;
            this.lblObserver1.Text = "Observer 1:";
            // 
            // numPrice
            // 
            this.numPrice.DecimalPlaces = 2;
            this.numPrice.Location = new System.Drawing.Point(74, 18);
            this.numPrice.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.numPrice.Name = "numPrice";
            this.numPrice.Size = new System.Drawing.Size(180, 26);
            this.numPrice.TabIndex = 2;
            this.numPrice.Value = new decimal(new int[] {
            525,
            0,
            0,
            131072});
            // 
            // btnSetNewPrice
            // 
            this.btnSetNewPrice.Location = new System.Drawing.Point(74, 82);
            this.btnSetNewPrice.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSetNewPrice.Name = "btnSetNewPrice";
            this.btnSetNewPrice.Size = new System.Drawing.Size(180, 35);
            this.btnSetNewPrice.TabIndex = 3;
            this.btnSetNewPrice.Text = "Set New Price";
            this.btnSetNewPrice.UseVisualStyleBackColor = true;
            this.btnSetNewPrice.Click += new System.EventHandler(this.btnSetNewPrice_Click);
            // 
            // lblObserver2
            // 
            this.lblObserver2.AutoSize = true;
            this.lblObserver2.Location = new System.Drawing.Point(18, 257);
            this.lblObserver2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblObserver2.Name = "lblObserver2";
            this.lblObserver2.Size = new System.Drawing.Size(90, 20);
            this.lblObserver2.TabIndex = 4;
            this.lblObserver2.Text = "Observer 2:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(327, 305);
            this.Controls.Add(this.lblObserver2);
            this.Controls.Add(this.btnSetNewPrice);
            this.Controls.Add(this.numPrice);
            this.Controls.Add(this.lblObserver1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Observer Pattern";
            ((System.ComponentModel.ISupportInitialize)(this.numPrice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblObserver1;
        private System.Windows.Forms.NumericUpDown numPrice;
        private System.Windows.Forms.Button btnSetNewPrice;
        private System.Windows.Forms.Label lblObserver2;
    }
}

