using System;

namespace RecapDemo2
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer();
            customer.Logger = new DatabaseLogger();

            customer.Add();

            Console.ReadLine();
        }

        interface ILogger
        {
            void Log();
        }

        class Customer
        {
            public ILogger Logger { get; set; }
            public void Add()
            {
                Console.WriteLine("Customer Added.");
                Logger.Log();

            }
        }

        class DatabaseLogger : ILogger
        {
            public void Log()
            {
                Console.Write("Database Logged in : ");
                DateTime time = DateTime.Now;
                Console.WriteLine(time);
            }
        }

        class SmsLogger : ILogger
        {
            public void Log()
            {
                Console.Write("Sms Logged in : ");
                DateTime time = DateTime.Now;
                Console.WriteLine(time);
            }
        }

        class TxtLogger : ILogger
        {
            public void Log()
            {
                Console.Write("Txt Logged in : ");
                DateTime time = DateTime.Now;
                Console.WriteLine(time);
            }
        }


        /*{
            
            CustomerManager customerManager = new CustomerManager();
            customerManager.Logger = new SmsLogger();
            customerManager.Add();
            Console.ReadLine();
        }
    }
    

    class CustomerManager
    {
        public ILogger Logger { get; set; }
        public void Add()
        {
           
            Logger.Log();
            Console.WriteLine("Added");
        }
    }

    class DatabaseLogger : ILogger
    {
        public void Log()
        {
            Console.WriteLine("Database Logged!");
        }
    }

    class SmsLogger : ILogger
    {
        public void Log()
        {
            Console.Write("Sms Logged! in : ");
            DateTime time = DateTime.Now;
            Console.WriteLine(time);
        }
    }

    class TxtLogger : ILogger
    {
        public void Log()
        {
            Console.WriteLine("Txt Logged");
        }
    }

    interface ILogger
    {
        void Log();
    }*/
    }
}
