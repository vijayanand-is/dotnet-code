using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Command
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSetBackgroundColor_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                UpdateBackColor updateBackColor = new UpdateBackColor()
                {
                    UI = this,
                    Color = colorDialog1.Color
                };
                ColorInvoker invoker = new ColorInvoker();
                invoker.Invoke(updateBackColor);
            }
        }

        private void btnSetForegroundColor_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                UpdateForeColor updateForeColor = new UpdateForeColor()
                {
                    UI = this,
                    Color = colorDialog1.Color
                };
                ColorInvoker invoker = new ColorInvoker();
                invoker.Invoke(updateForeColor);
            }
        }
    }
}
