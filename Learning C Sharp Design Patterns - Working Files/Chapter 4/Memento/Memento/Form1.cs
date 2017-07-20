using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Memento
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            User.UserID = 1;
            User.Name = "Keith";
            User.Username = "kdub";
            User.Password = "moose";
            DisplayUser();
        }

        private User User = new User();
        private Caretaker Caretaker = new Caretaker();

        private void btnEdit_Click(object sender, EventArgs e)
        {
            Caretaker.UserMemento = User.SaveState();

            int userID;
            if (int.TryParse(txtUserID.Text, out userID))
            {
                User.UserID = userID;
            }
            User.Name = txtName.Text;
            User.Username = txtUsername.Text;
            User.Password = txtPassword.Text;
        }

        private void btnUndo_Click(object sender, EventArgs e)
        {
            User.RestoreState(Caretaker.UserMemento);
            DisplayUser();
        }

        private void DisplayUser()
        {
            txtUserID.Text = User.UserID.ToString();
            txtName.Text = User.Name;
            txtUsername.Text = User.Username;
            txtPassword.Text = User.Password;
        }
    }
}
