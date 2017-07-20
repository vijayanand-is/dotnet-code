namespace Composite
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
            this.btnBuildPartsList = new System.Windows.Forms.Button();
            this.listParts = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnBuildPartsList
            // 
            this.btnBuildPartsList.Location = new System.Drawing.Point(18, 18);
            this.btnBuildPartsList.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnBuildPartsList.Name = "btnBuildPartsList";
            this.btnBuildPartsList.Size = new System.Drawing.Size(256, 35);
            this.btnBuildPartsList.TabIndex = 0;
            this.btnBuildPartsList.Text = "Build Parts List";
            this.btnBuildPartsList.UseVisualStyleBackColor = true;
            this.btnBuildPartsList.Click += new System.EventHandler(this.btnBuildPartsList_Click);
            // 
            // listParts
            // 
            this.listParts.FormattingEnabled = true;
            this.listParts.ItemHeight = 20;
            this.listParts.Location = new System.Drawing.Point(18, 63);
            this.listParts.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listParts.Name = "listParts";
            this.listParts.Size = new System.Drawing.Size(256, 324);
            this.listParts.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(287, 403);
            this.Controls.Add(this.listParts);
            this.Controls.Add(this.btnBuildPartsList);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Composite Pattern";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBuildPartsList;
        private System.Windows.Forms.ListBox listParts;
    }
}

