using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WcfLogPrints
{
    public interface ILoggingStrategy
    {
        bool Log(LoggingArgument arg);
    }
}
