using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Example.Contracts;
using System.ServiceModel;

namespace Example.Client
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "WcfLogPrints example - client";

            Example1();

            Example2();

            Example3();

            Example4();

            Example5();
        }

        private static void Example5()
        {
            Console.WriteLine("Example 5: Using differnt logging strategy in the code.");

            ChannelFactory<IMyThirdService> factory = new ChannelFactory<IMyThirdService>("myThirdServiceEp");
            IMyThirdService proxy = factory.CreateChannel();

            proxy.MyOperation(25);

            CloseProxy(proxy as IClientChannel);

            Console.WriteLine("The log-prints have been printed to C:\\Example.txt");
        }

        private static void Example4()
        {
            Console.WriteLine("Example 4: Using LoggingBehavior in the configuration file. Using differnt logging strategy in the configuration file.");

            ChannelFactory<IMySecondService> factory = new ChannelFactory<IMySecondService>("mySecondServiceEp");
            IMySecondService proxy = factory.CreateChannel();

            proxy.MyOperation(15);

            CloseProxy(proxy as IClientChannel);

            Console.WriteLine("The log-prints have been printed to C:\\Example.txt");
        }


        private static void Example3()
        {
            Console.WriteLine("Example 3: Using LoggingContext.");
            ChannelFactory<IMyService> factory = new ChannelFactory<IMyService>("myServiceEp");
            IMyService proxy = factory.CreateChannel();

            proxy.MyThirdOperation(3);

            CloseProxy(proxy as IClientChannel);
        }

        private static void Example2()
        {
            Console.WriteLine("Example 2: Operation with specific LoggingBehavior settings.");

            ChannelFactory<IMyService> factory = new ChannelFactory<IMyService>("myServiceEp");
            IMyService proxy = factory.CreateChannel();

            proxy.MySecondOperation(2);

            CloseProxy(proxy as IClientChannel);
        }

        private static void Example1()
        {
            Console.WriteLine("Example 1: Operation with complex argument.");

            ChannelFactory<IMyService> factory = new ChannelFactory<IMyService>("myServiceEp");
            IMyService proxy = factory.CreateChannel();

            List<Person> family1Children = new List<Person>();

            family1Children.Add(new Person
            {
                FirstName = "first name 2",
                LastName = "last name 2",
                Address = new Address
                {
                    Country = "country 2",
                    City = "city 2",
                    Street = "street 2",
                    HomeNumber = 22
                }
            });

            List<Person> person3Children = new List<Person>();
            person3Children.Add(new Person
            {
                FirstName = "first name 4",
                LastName = "last name 4",
                Address = new Address
                {
                    Country = "country 4",
                    City = "city 4",
                    Street = "street 4",
                    HomeNumber = 44
                }
            });

            person3Children.Add(new Person
            {
                FirstName = "first name 5",
                LastName = "last name 5",
                Address = new Address
                {
                    Country = "country 5",
                    City = "city 5",
                    Street = "street 5",
                    HomeNumber = 55
                }
            });

            family1Children.Add(new Person
            {
                FirstName = "first name 3",
                LastName = "last name 3",
                Address = new Address
                {
                    Country = "country 3",
                    City = "city 3",
                    Street = "street 3",
                    HomeNumber = 33
                },
                Children = person3Children
            });

            List<Person> family2Children = new List<Person>();

            family2Children.Add(new Person
            {
                FirstName = "first name 7",
                LastName = "last name 7",
                Address = new Address
                {
                    Country = "country 7",
                    City = "city 7",
                    Street = "street 7",
                    HomeNumber = 77
                }
            });

            family2Children.Add(new Person
            {
                FirstName = "first name 8",
                LastName = "last name 8",
                Address = new Address
                {
                    Country = "country 8",
                    City = "city 8",
                    Street = "street 8",
                    HomeNumber = 88
                }
            });

            List<Family> families = new List<Family>();
            families.Add(new Family
            {
                Description = "The first family",
                HeadOfFamily = new Person
                {
                    FirstName = "first name 1",
                    LastName = "last name 1",
                    Address = new Address
                    {
                        Country = "country 1",
                        City = "city 1",
                        Street = "street 1",
                        HomeNumber = 11
                    },
                    Children = family1Children
                }
            });

            families.Add(new Family
            {
                Description = "The second family",
                HeadOfFamily = new Person
                {
                    FirstName = "first name 6",
                    LastName = "last name 6",
                    Address = new Address
                    {
                        Country = "country 6",
                        City = "city 6",
                        Street = "street 6",
                        HomeNumber = 66
                    },
                    Children = family2Children
                }
            });

            string result;
            proxy.MyOperation(10, families, out result);

            CloseProxy(proxy as IClientChannel);
        }

        private static void CloseProxy(IClientChannel proxy)
        {
            if (proxy == null)
            {
                return;
            }

            try
            {
                proxy.Close();
            }
            catch
            {
                proxy.Abort();
            }
        }

    }
}
