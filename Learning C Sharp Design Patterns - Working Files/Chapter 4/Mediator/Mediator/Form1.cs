using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mediator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            Colleague colleagueBob = new Colleague("Bob");
            Colleague colleagueSue = new Colleague("Sue");
            Colleague colleagueChris = new Colleague("Chris");
            Colleague colleagueDonna = new Colleague("Donna");

            IMediator mediator1 = new Mediator();

            mediator1.Register(colleagueBob);
            mediator1.Register(colleagueSue);
            mediator1.Register(colleagueChris);

            colleagueBob.SendMessage(mediator1, "Hi folks!");

            IMediator mediator2 = new Mediator();

            mediator2.Register(colleagueSue);
            mediator2.Register(colleagueDonna);
            
            colleagueSue.SendMessage(mediator2, "A more private message.");
        }
    }
}
