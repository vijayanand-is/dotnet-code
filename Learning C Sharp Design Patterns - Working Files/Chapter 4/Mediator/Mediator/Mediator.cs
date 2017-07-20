using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
    public class Mediator : IMediator
    {
        private List<Colleague> ColleagueList = new List<Colleague>();

        public List<Colleague> Colleagues
        {
            get { return ColleagueList; }
        }

        public void Register(Colleague colleague)
        {
            ColleagueList.Add(colleague);
        }

        public void PostMessage(Colleague sender, string message)
        {
            foreach (Colleague c in ColleagueList)
            {
                if (c != sender)
                {
                    c.ReceiveMessage(message, sender.Name);
                }
            }
        }

    }
}
