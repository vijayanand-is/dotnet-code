namespace Visitor
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
            this.btnAddCredits = new System.Windows.Forms.Button();
            this.btnUpdateExpiration = new System.Windows.Forms.Button();
            this.lblGregStatus = new System.Windows.Forms.Label();
            this.lblRichardStatus = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAddCredits
            // 
            this.btnAddCredits.Location = new System.Drawing.Point(18, 42);
            this.btnAddCredits.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAddCredits.Name = "btnAddCredits";
            this.btnAddCredits.Size = new System.Drawing.Size(390, 35);
            this.btnAddCredits.TabIndex = 0;
            this.btnAddCredits.Text = "Add Credits";
            this.btnAddCredits.UseVisualStyleBackColor = true;
            this.btnAddCredits.Click += new System.EventHandler(this.btnAddCredits_Click);
            // 
            // btnUpdateExpiration
            // 
            this.btnUpdateExpiration.Location = new System.Drawing.Point(18, 110);
            this.btnUpdateExpiration.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnUpdateExpiration.Name = "btnUpdateExpiration";
            this.btnUpdateExpiration.Size = new System.Drawing.Size(390, 35);
            this.btnUpdateExpiration.TabIndex = 1;
            this.btnUpdateExpiration.Text = "Update Expiration";
            this.btnUpdateExpiration.UseVisualStyleBackColor = true;
            this.btnUpdateExpiration.Click += new System.EventHandler(this.btnUpdateExpiration_Click);
            // 
            // lblGregStatus
            // 
            this.lblGregStatus.AutoSize = true;
            this.lblGregStatus.Location = new System.Drawing.Point(14, 183);
            this.lblGregStatus.Name = "lblGregStatus";
            this.lblGregStatus.Size = new System.Drawing.Size(96, 20);
            this.lblGregStatus.TabIndex = 2;
            this.lblGregStatus.Text = "Greg Status";
            // 
            // lblRichardStatus
            // 
            this.lblRichardStatus.AutoSize = true;
            this.lblRichardStatus.Location = new System.Drawing.Point(14, 220);
            this.lblRichardStatus.Name = "lblRichardStatus";
            this.lblRichardStatus.Size = new System.Drawing.Size(115, 20);
            this.lblRichardStatus.TabIndex = 3;
            this.lblRichardStatus.Text = "Richard Status";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 249);
            this.Controls.Add(this.lblRichardStatus);
            this.Controls.Add(this.lblGregStatus);
            this.Controls.Add(this.btnUpdateExpiration);
            this.Controls.Add(this.btnAddCredits);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Visitor Pattern";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddCredits;
        private System.Windows.Forms.Button btnUpdateExpiration;
        private System.Windows.Forms.Label lblGregStatus;
        private System.Windows.Forms.Label lblRichardStatus;
    }
}

