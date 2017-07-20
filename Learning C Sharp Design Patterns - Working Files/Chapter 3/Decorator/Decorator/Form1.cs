using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Decorator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            DisplayPrice();
        }

        private void option_CheckedChanged(object sender, EventArgs e)
        {
            DisplayPrice();
        }

        private void DisplayPrice()
        {
            ComputerBase computer = new ComputerBase()
            {
                Model = "ExtremeXPC"
            };

            ComputerDecorator ramDecorator;
            if (rad8RAM.Checked)
            {
                ramDecorator = new Memory8Option(computer);
            }
            else
            {
                ramDecorator = new Memory16Option(computer);
            }

            ComputerDecorator ssdDecorator;
            if (rad128SSD.Checked)
            {
                ssdDecorator = new SSD128Option(ramDecorator);
            }
            else if (rad256SSD.Checked)
            {
                ssdDecorator = new SSD256Option(ramDecorator);
            }
            else
            {
                ssdDecorator = new SSD512Option(ramDecorator);
            }

            ComputerDecorator decorator;
            if (chkApplyDiscount.Checked)
            {
                decorator = new DiscountDecorator(ssdDecorator);
            }
            else
            {
                decorator = ssdDecorator;
            }

            lblModel.Text = decorator.Model + "-" + decorator.GetOptionCode();
            lblTotal.Text = decorator.GetPrice().ToString("C");
        }
    }
}
