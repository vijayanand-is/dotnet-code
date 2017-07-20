using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento
{
    public class UserMemento
    {
        public int UserID { get; set; }
        public string Name { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

        public UserMemento(int userID, string name, string username, string password)
        {
            UserID = userID;
            Name = name;
            Username = username;
            Password = password;
        }
    }

}
