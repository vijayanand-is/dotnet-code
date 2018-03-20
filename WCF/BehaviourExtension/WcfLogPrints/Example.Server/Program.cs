using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;
using Example.Services;

namespace Example.Server
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "WcfLogPrints example - server";

            Console.WriteLine("Starting services...");

            ServiceHost myFirstServiceHost = new ServiceHost(typeof(MyService));
            myFirstServiceHost.Open();

            ServiceHost mySecondServiceHost = new ServiceHost(typeof(MySecondService));
            mySecondServiceHost.Open();

            ServiceHost myThirdServiceHost = new ServiceHost(typeof(MyThirdService));
            myThirdServiceHost.Open();

            Console.WriteLine("Press <Enter> to stop.");
            Console.ReadLine();

            myFirstServiceHost.Close();
            mySecondServiceHost.Close();
            myThirdServiceHost.Close();
        }
    }
}
