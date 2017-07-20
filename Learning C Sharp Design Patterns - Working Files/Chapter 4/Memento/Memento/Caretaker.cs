using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento
{
    public class Caretaker
    {
        private UserMemento userMemento;

        public UserMemento UserMemento
        {
            set { userMemento = value; }
            get { return userMemento; }
        }
    }

}
