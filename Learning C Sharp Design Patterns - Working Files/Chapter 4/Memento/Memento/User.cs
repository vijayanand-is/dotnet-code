using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento
{
    // Originator
    public class User
    {
        public int UserID { get; set; }
        public string Name { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

        public void RestoreState(UserMemento userMemento)
        {
            UserID = userMemento.UserID;
            Name = userMemento.Name;
            Username = userMemento.Username;
            Password = userMemento.Password;
        }
        public UserMemento SaveState()
        {
            return new UserMemento(UserID, Name, Username, Password);
        }
    }

}
