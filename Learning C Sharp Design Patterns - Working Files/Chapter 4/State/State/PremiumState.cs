using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    /// <summary>
    /// A 'ConcreteState' class
    /// </summary>
    class PremiumState : State
    {
        public PremiumState(State state)
        {
            this.nextPage = "Premium Main Page";
            this.user = state.User;
            Initialize();
        }

        private void Initialize()
        {
            level = 0;
        }

        public override void Login()
        {
            level = 1;
            StateChangeCheck();
        }

        public override void Logout()
        {
            level = 0;
            StateChangeCheck();
        }

        public override void Upgrade()
        {
            level = 2;
            StateChangeCheck();
        }

        private void StateChangeCheck()
        {
            switch (level)
            {
                case 0:
                    user.State = new LoggedOutState(this);
                    break;
                case 1:
                    user.State = new StandardState(this);
                    break;
                case 2:
                    user.State = this;
                    break;
            }
        }
    }

}
