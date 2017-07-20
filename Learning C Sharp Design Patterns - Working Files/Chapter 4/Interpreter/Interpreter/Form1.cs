using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interpreter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnInterpret_Click(object sender, EventArgs e)
        {
            string context = txtInputText.Text;
            Parser parser = new Parser();
            Expression expression = parser.Parse(context);
            lblResult.Text = expression.Interpret().ToString();
        }

    }
}
