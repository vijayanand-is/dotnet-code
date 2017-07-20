using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Configuration;
using System.Data;
using System.Data.OleDb;

namespace Builder
{
    class OleDbDatabaseBuilder : IDatabaseBuilder 
    {
        private Database _Database;

        public OleDbDatabaseBuilder()
        {
            _Database = new OleDbDatabase();
        }

        public void BuildConnection()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["SQLServerConnectionString"].ConnectionString;
            _Database.Connection = new OleDbConnection(connectionString);
        }

        public void BuildCommand()
        {
            _Database.Command = new OleDbCommand();
            _Database.Command.Connection = _Database.Connection;
        }

        public void SetSettings()
        {
            _Database.Command.CommandTimeout = 360;
            _Database.Command.CommandType = CommandType.Text;
        }

        public Database Database
        {
            get { return _Database; }
        }

    }
}
