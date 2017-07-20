using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
    public class Colleague
    {
        public string Name { get; set; }

        public Colleague(string name)
        {
            Name = name;
        }

        public void SendMessage(IMediator mediator, string message)
        {
            mediator.PostMessage(this, message);
        }

        public void ReceiveMessage(string message, string sender)
        {
            Console.WriteLine(Name + ", message from: " + sender + ": " + message);
        }
    }

}
