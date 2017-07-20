using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChainOfResponsibility
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnApprove_Click(object sender, EventArgs e)
        {
            Material material = new Material
            {
                MaterialID = Guid.NewGuid(),
                Name = txtName.Text,
                PartNumber = txtPartNumber.Text,
                DrawingNumber = txtDrawingNumber.Text,
                Budget = decimal.Parse(txtBudget.Text)
            };

            Approver bob = new EngineeringApprover();
            Approver ted = new PurchasingApprover();
            Approver alice = new FinanceApprover();

            bob.SetNextApprover(ted);
            ted.SetNextApprover(alice);

            string reason = "";
            if (bob.ApproveMaterial(material, ref reason))
            {
                reason = "Approved. " + reason;
            }
            else
            {
                reason = "Disapproved. " + reason;
            }

            txtResult.Text = reason;
        }

    }
}
