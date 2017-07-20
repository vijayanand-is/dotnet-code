using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    /// <summary>
    /// The 'Context' class
    /// </summary>
    class User
    {
        private State state;
        private string name;

        public User(string name)
        {
            this.name = name;
            this.state = new LoggedOutState(this);
        }

        public string NextPage
        {
            get { return state.NextPage; }
        }

        public State State
        {
            get { return state; }
            set { state = value; }
        }

        public void Login()
        {
            state.Login();
        }

        public void Logout()
        {
            state.Logout();
        }

        public void Upgrade()
        {
            state.Upgrade();
        }

    }

}
