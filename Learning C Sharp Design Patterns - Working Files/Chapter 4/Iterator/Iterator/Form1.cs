using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Iterator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            Aggregate aggregate = new Aggregate();

            aggregate[0] = new User { UserID = 1, Name = "Bob" };
            aggregate[1] = new User { UserID = 2, Name = "Bill" };
            aggregate[2] = new User { UserID = 3, Name = "Tom" };
            aggregate[3] = new User { UserID = 4, Name = "Rob" };
            aggregate[4] = new User { UserID = 5, Name = "Dan" };

            IIterator iterator = aggregate.GetIterator();

            string s = iterator.First.Name;
            while (!iterator.IsDone)
            {
                User user = iterator.Next;
                if (user != null)
                {
                    s += ", " + user.Name;
                }
            }
            lblUsers.Text = s;

        }
    }
}
