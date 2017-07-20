using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace State
{
    public partial class Form1 : Form
    {
        private User user = new User("KW");

        public Form1()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            user.Login();
            txtNextPage.Text = user.NextPage;
        }

        private void btnUpgrade_Click(object sender, EventArgs e)
        {
            user.Upgrade();
            txtNextPage.Text = user.NextPage;
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            user.Logout();
            txtNextPage.Text = user.NextPage;
        }
    }
}
