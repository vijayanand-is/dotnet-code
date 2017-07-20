using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    public class Notification
    {
        public bool NotifyUser(User user, string message)
        {
            // code for notification
            // might be an SMS, email, internal app messaging, etc.

            return true;
        }

    }
}
