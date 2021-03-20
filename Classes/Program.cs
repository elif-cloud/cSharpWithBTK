using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add();
            customerManager.Update();

            Customer customer = new Customer();
            customer.City = "Sakarya";
            customer.Id = 1;
            customer.FirstName = "Elif";
            customer.LastName = "Cancı";

            Customer customer2 = new Customer
            {
                Id = 2,
                City = "İstanbul",
                FirstName = "Deniz",
                LastName = "Demir"
            };

            Console.WriteLine(customer2.FirstName);
            Console.ReadLine();
        }
    }

    class CustomerManager
    {
        public void Add()
        {
            Console.WriteLine("Customer Added!!!");
        }

        public void Update()
        {
            Console.WriteLine("Customer Updated!!!");
        }
    }
}
