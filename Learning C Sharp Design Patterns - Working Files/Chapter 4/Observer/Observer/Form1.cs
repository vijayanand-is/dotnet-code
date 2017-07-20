using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Observer
{
    public partial class Form1 : Form
    {
        private BigStorePrice price;

        public Form1()
        {
            InitializeComponent();

            price = new BigStorePrice();
            price.ProductPrice = numPrice.Value;

            PriceWatcher observer1 = new PriceWatcher("Observer 1");
            price.Subscribe(observer1);
            observer1.PriceChanged += observer1_PriceChanged;

            PriceWatcher observer2 = new PriceWatcher("Observer 2");
            price.Subscribe(observer2);
            observer2.PriceChanged += observer2_PriceChanged;
        }

        private void btnSetNewPrice_Click(object sender, EventArgs e)
        {
            price.ProductPrice = numPrice.Value;
        }

        void observer1_PriceChanged(object sender, decimal e)
        {
            lblObserver1.Text = ((PriceWatcher)sender).Name + ": " + e.ToString("C");
        }

        void observer2_PriceChanged(object sender, decimal e)
        {
            lblObserver2.Text = ((PriceWatcher)sender).Name + ": " + e.ToString("C");
        }

    }
}
