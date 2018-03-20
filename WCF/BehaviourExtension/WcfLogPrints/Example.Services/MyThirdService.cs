using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Example.Contracts;
using WcfLogPrints;

namespace Example.Services
{
    [LoggingBehavior(LoggingStrategyType = typeof(FileLoggingStrategy))]
    public class MyThirdService : IMyThirdService
    {
        public int MyOperation(int myArg)
        {
            return 5;
        }
    }
}
