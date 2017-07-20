using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.Common;

namespace Builder
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGetDatabase_Click(object sender, EventArgs e)
        {
            Director director = new Director();
            IDatabaseBuilder builder;

            if (radUseSqlServer.Checked)
            {
                builder = new SqlServerDatabaseBuilder();
            }
            else
            {
                builder = new OleDbDatabaseBuilder();
            }

            director.Build(builder);
            Database database = builder.Database;

            DbCommand command = database.Command;
            // now, we can do something, like:
            //command.CommandText = "SELECT * FROM Customers";
            //command.Connection.Open();
            //DbDataReader reader = command.ExecuteReader();

            //reader.Close();
            //command.Connection.Close();

        }
    }
}
