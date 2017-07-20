using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    class Memory8Option : ComputerDecorator
    {
        public Memory8Option(Computer computer)
            : base(computer)
        {
            OptionCode = "8RAM";
            Price = 70.0M;
        }
    }

    class Memory16Option : ComputerDecorator
    {
        public Memory16Option(Computer computer)
            : base(computer)
        {
            OptionCode = "16RAM";
            Price = 150.0M;
        }
    }

    class SSD128Option : ComputerDecorator
    {
        public SSD128Option(Computer computer)
            : base(computer)
        {
            OptionCode = "128SSD";
            Price = 74.0M;
        }
    }

    class SSD256Option : ComputerDecorator
    {
        public SSD256Option(Computer computer)
            : base(computer)
        {
            OptionCode = "256SSD";
            Price = 120.0M;
        }
    }

    class SSD512Option : ComputerDecorator
    {
        public SSD512Option(Computer computer)
            : base(computer)
        {
            OptionCode = "512SSD";
            Price = 223.0M;
        }
    }

}