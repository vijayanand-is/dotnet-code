using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
    public interface IMediator
    {
        List<Colleague> Colleagues { get; }

        void PostMessage(Colleague sender, string message);

        void Register(Colleague colleague);
    }

}
