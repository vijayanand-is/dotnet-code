using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Template
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private FileDataLogger fileLogger = new FileDataLogger();
        private WindowsEventLogger windowsLogger = new WindowsEventLogger();

        private void btnWriteLog_Click(object sender, EventArgs e)
        {
            string message = txtMessage.Text;

            fileLogger.LogData(message);
            windowsLogger.LogData(message);
        }
    }
}
