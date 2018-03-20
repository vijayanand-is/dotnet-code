using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Example.Contracts;
using WcfLogPrints;

namespace Example.Services
{
    [LoggingBehavior]
    public class MyService : IMyService
    {
        public int MyOperation(int myArg, List<Family> families, out string myResult)
        {
            myResult = "There are " + families.Count + " families.";

            return 5;
        }

        [LoggingBehavior(LogBeforeCall = false)]
        public int MySecondOperation(int myArg)
        {
            return 10;
        }

        public void MyThirdOperation(int i)
        {
            LoggingContext.Current.LogInformation("In MyThirdOperation");

            MyClass c = new MyClass();
            c.MyMethod();
        }
    }
}
