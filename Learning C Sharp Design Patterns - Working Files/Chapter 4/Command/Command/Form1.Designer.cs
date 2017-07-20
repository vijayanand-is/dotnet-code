namespace Command
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
            this.btnSetBackgroundColor = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.btnSetForegroundColor = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSetBackgroundColor
            // 
            this.btnSetBackgroundColor.Location = new System.Drawing.Point(12, 54);
            this.btnSetBackgroundColor.Name = "btnSetBackgroundColor";
            this.btnSetBackgroundColor.Size = new System.Drawing.Size(402, 37);
            this.btnSetBackgroundColor.TabIndex = 0;
            this.btnSetBackgroundColor.Text = "Set Background Color";
            this.btnSetBackgroundColor.UseVisualStyleBackColor = true;
            this.btnSetBackgroundColor.Click += new System.EventHandler(this.btnSetBackgroundColor_Click);
            // 
            // btnSetForegroundColor
            // 
            this.btnSetForegroundColor.Location = new System.Drawing.Point(12, 128);
            this.btnSetForegroundColor.Name = "btnSetForegroundColor";
            this.btnSetForegroundColor.Size = new System.Drawing.Size(402, 37);
            this.btnSetForegroundColor.TabIndex = 1;
            this.btnSetForegroundColor.Text = "Set Foreground Color";
            this.btnSetForegroundColor.UseVisualStyleBackColor = true;
            this.btnSetForegroundColor.Click += new System.EventHandler(this.btnSetForegroundColor_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 225);
            this.Controls.Add(this.btnSetForegroundColor);
            this.Controls.Add(this.btnSetBackgroundColor);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Command Pattern";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSetBackgroundColor;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button btnSetForegroundColor;
    }
}

