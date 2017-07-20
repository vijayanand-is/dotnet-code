namespace Facade
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
            this.btnFollowSomeone = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnFollowSomeone
            // 
            this.btnFollowSomeone.Location = new System.Drawing.Point(18, 18);
            this.btnFollowSomeone.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnFollowSomeone.Name = "btnFollowSomeone";
            this.btnFollowSomeone.Size = new System.Drawing.Size(390, 35);
            this.btnFollowSomeone.TabIndex = 0;
            this.btnFollowSomeone.Text = "Follow Someone";
            this.btnFollowSomeone.UseVisualStyleBackColor = true;
            this.btnFollowSomeone.Click += new System.EventHandler(this.btnFollowSomeone_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 166);
            this.Controls.Add(this.btnFollowSomeone);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Facade Pattern";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnFollowSomeone;
    }
}

