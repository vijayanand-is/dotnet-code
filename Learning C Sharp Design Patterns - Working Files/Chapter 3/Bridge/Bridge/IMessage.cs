using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    /// <summary>
    /// Implementer in Bridge pattern
    /// </summary>
    public interface IMessage
    {
        void SendMessage(string to, string message);
    }
}
