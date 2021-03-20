using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            //InterfacesIntro();

            //Demo();

            ICustomerDal[] customerDals = new ICustomerDal[3]
            {
                new OracleCustomerDal(),
                new SqlServerCustomerDal(),
                new MySqlCustomerDal()
            };
            foreach (var customerDal in customerDals)
            {
                customerDal.Add();
            }

            Console.ReadLine();
        }

        private static void Demo()
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(new OracleCustomerDal());
        }

        private static void InterfacesIntro()
        {
            PersonManager manager = new PersonManager();
            Customer customer = new Customer
            {
                Id = 1,
                FirstName = "Elif",
                LastName = "Cancı",
                Address = "Sakarya"
            };
            manager.Add(customer);
        }
    }

    interface IPerson //interfaceler new lenemez çünkü tek başına anlamı yoktur.Çünkü soyut nesne.
    {
        int Id { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }
    }

    class Customer : IPerson
    {
        public int Id { get ; set; }
        public string FirstName { get ; set ; }
        public string LastName { get; set ; }
        public string Address { get; set; }
    }

    class Student : IPerson
    {
        public int Id { get; set; }
        public string FirstName { get ; set ; }
        public string LastName { get ; set; }
        public string Departmant { get; set; }
    }

    class PersonManager
    {
        public void Add (Customer customer)
        {
            Console.WriteLine(customer.FirstName);
        }
    }
}
