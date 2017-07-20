using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public interface IDatabaseBuilder
    {
        void BuildConnection();
        void BuildCommand();
        void SetSettings();
        Database Database { get; }
    }
}
