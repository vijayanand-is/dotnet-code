﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WcfLogPrints
{
    public class LoggingExceptionData
    {
        public Exception Exception { get; set; }

        public override string ToString()
        {
            return ObjectToStringConverter.ConvertExceptionToString(Exception);
        }
    }
}
