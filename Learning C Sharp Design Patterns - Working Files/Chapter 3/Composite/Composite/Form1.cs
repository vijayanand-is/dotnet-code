using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Composite
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnBuildPartsList_Click(object sender, EventArgs e)
        {
            Assembly topWidget = new Assembly("Main Assembly", 1);
            Assembly chassis = new Assembly("Chassis", 1);
            Assembly display = new Assembly("Display", 1);
            Assembly powerSupply = new Assembly("Power Supply", 1);
            Part bolt = new Part("Bolt", 24);
            Part mainCase = new Part("Case", 1);
            Part screen = new Part("Screen", 3);
            Part displayElectronics = new Part("Display Electronics", 3);
            Part transformer = new Part("Transformer", 1);
            Part powerBoard = new Part("Power Board", 1);
            Part ductTape = new Part("Duct Tape", 5);
            Part gum = new Part("Bubble Gum", 25);

            topWidget.Add(chassis);
            topWidget.Add(display);
            topWidget.Add(powerSupply);
            chassis.Add(mainCase);
            chassis.Add(bolt);
            display.Add(screen);
            display.Add(displayElectronics);
            powerSupply.Add(transformer);
            powerSupply.Add(powerBoard);
            topWidget.Add(ductTape);
            topWidget.Add(gum);

            DisplayPartsList(topWidget);
        }

        private void DisplayPartsList(Assembly topWidget)
        {
            List<string> partsList = new List<string>();
            topWidget.WritePartsList(partsList);

            listParts.Items.Clear();
            listParts.Items.AddRange(partsList.ToArray());
        }
    }
}
