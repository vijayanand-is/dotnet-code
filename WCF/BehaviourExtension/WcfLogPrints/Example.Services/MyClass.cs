using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WcfLogPrints;

namespace Example.Services
{
    public class MyClass
    {
        public void MyMethod()
        {
            LoggingContext.Current.LogInformation("This is a log-print" +
                " from a different method in a diffetrent class." +
                " The operation's details that connected to this log are" +
                " the details of the service's operation.");
        }
    }
}
