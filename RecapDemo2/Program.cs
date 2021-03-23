using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace RecapDemo2
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.Logger = new SmsLogger();  //burayı DatabaseLogger diye değiştirebilirsin.BURASI ÖNEMLİ!!!
            customerManager.Add();
            Console.ReadLine();
        }
    }

    class CustomerManager
    {
        public ILogger Logger { get; set; }      //public property
        public void Add()
        {
            Logger.Log();
            Console.WriteLine("Customer added!");
           
        }
    }

    interface ILogger
    {
        void Log();
    }

    class DatabaseLogger:ILogger
    {
        public void Log()
        {
            Console.WriteLine("Logged to database!");
        }
    }

    class FileLogger:ILogger
    {
        public void Log()
        {
            Console.WriteLine("Logged to file!");
        }
    }

    class SmsLogger:ILogger
    {
        public void Log()
        {
            Console.WriteLine("Logged to sms!");
        }
    }
}
