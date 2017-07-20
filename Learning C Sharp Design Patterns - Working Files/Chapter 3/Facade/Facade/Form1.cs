using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Facade
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnFollowSomeone_Click(object sender, EventArgs e)
        {
            User me = new User();
            me.UserName = "KDub";

            User userIWantToFollow = new User();
            userIWantToFollow.UserName = "James Page";

            Follower follower = new Follower();
            if (follower.Follow(me, userIWantToFollow))
            {
                MessageBox.Show("You have successfully followed " + userIWantToFollow.UserName);
            }
            else
            {
                MessageBox.Show("Sorry, something went wrong.");
            }
        }
    }
}
