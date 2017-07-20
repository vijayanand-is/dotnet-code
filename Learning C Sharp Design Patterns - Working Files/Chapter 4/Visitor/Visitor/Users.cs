using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor
{
    public class Users
    {
        private List<User> UsersList = new List<User>();

        public void Attach(User user)
        {
            UsersList.Add(user);
        }

        public void Detach(User user)
        {
            UsersList.Remove(user);
        }

        public void Accept(IVisitor visitor)
        {
            foreach (User e in UsersList)
            {
                e.Accept(visitor);
            }
        }

    }
}
