using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator
{
    public interface IIterator
    {
        User First { get; }
        User Next { get; }
        User Current { get; }
        bool IsDone { get; }
    }
}
