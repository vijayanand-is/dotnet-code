using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight
{
    public class User
    {
        public Guid UserID { get; set; }
        public string Username { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public List<User> Followers { get; set; }

        public static User GetUser(Guid userID)
        {
            // get user from the database

            // demo user with random id
            return new User
            {
                UserID = Guid.NewGuid()
            };
        }

    }
}
