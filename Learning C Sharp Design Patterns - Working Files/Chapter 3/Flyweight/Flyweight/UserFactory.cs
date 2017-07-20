using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight
{
    public class UserFactory
    {
        public static int UsersCount = 0;
        private Dictionary<Guid, User> Users = new Dictionary<Guid, User>();

        public User GetUser(Guid userID)
        {
            if (Users.ContainsKey(userID))
                return Users[userID];

            User user = User.GetUser(userID);
            Users.Add(userID, user);
            UsersCount++;
            return user;
        }

    }
}
