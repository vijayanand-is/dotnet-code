using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    /// <summary>
    /// Concrete Implementor in Bridge pattern
    /// </summary>
    public class EmailMessage : IMessage
    {
        public void SendMessage(string to, string message)
        {
            // send email
        }
    }
}
