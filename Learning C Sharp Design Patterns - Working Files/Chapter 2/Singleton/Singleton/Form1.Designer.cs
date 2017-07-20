namespace Singleton
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
            this.btnDoSomethingBad = new System.Windows.Forms.Button();
            this.btnGoToForm2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnDoSomethingBad
            // 
            this.btnDoSomethingBad.Location = new System.Drawing.Point(12, 12);
            this.btnDoSomethingBad.Name = "btnDoSomethingBad";
            this.btnDoSomethingBad.Size = new System.Drawing.Size(260, 23);
            this.btnDoSomethingBad.TabIndex = 0;
            this.btnDoSomethingBad.Text = "Do Something Bad";
            this.btnDoSomethingBad.UseVisualStyleBackColor = true;
            this.btnDoSomethingBad.Click += new System.EventHandler(this.btnDoSomethingBad_Click);
            // 
            // btnGoToForm2
            // 
            this.btnGoToForm2.Location = new System.Drawing.Point(12, 83);
            this.btnGoToForm2.Name = "btnGoToForm2";
            this.btnGoToForm2.Size = new System.Drawing.Size(260, 23);
            this.btnGoToForm2.TabIndex = 1;
            this.btnGoToForm2.Text = "Go to Form 2";
            this.btnGoToForm2.UseVisualStyleBackColor = true;
            this.btnGoToForm2.Click += new System.EventHandler(this.btnGoToForm2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.btnGoToForm2);
            this.Controls.Add(this.btnDoSomethingBad);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Form 1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDoSomethingBad;
        private System.Windows.Forms.Button btnGoToForm2;
    }
}

