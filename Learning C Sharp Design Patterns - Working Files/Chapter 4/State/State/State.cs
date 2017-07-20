using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    /// <summary>
    /// The 'State' abstract class
    /// </summary>
    abstract class State
    {
        protected User user;
        protected string nextPage;

        protected int level;

        public User User
        {
            get { return user; }
            set { user = value; }
        }

        public string NextPage
        {
            get { return nextPage; }
            set { nextPage = value; }
        }

        public abstract void Login();
        public abstract void Logout();
        public abstract void Upgrade();
    }


}
