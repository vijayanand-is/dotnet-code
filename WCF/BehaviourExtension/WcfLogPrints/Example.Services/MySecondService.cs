using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Example.Contracts;

namespace Example.Services
{
    public class MySecondService : IMySecondService
    {
        public int MyOperation(int myArg)
        {
            return 5;
        }
    }
}
