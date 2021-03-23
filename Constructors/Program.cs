using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager(23);
            customerManager.List();

            Product product = new Product {Id = 1, Name = "Laptop"};
            Product product2 = new Product(2,"Computer"); //ÖNEMLİ

            Console.ReadLine();
        }
    }
    // ctor tab
    //private bir field _ ile başlatılır.
    class CustomerManager
    {
        private int _count=15;  //default olarak 15 atar.
        public CustomerManager(int count)
        {
            _count = count;
        }

        public CustomerManager()
        {
            
        }
        public void List()
        {
            Console.WriteLine("Listed {0} items", _count);
        }

        public void Add()
        {
            Console.WriteLine("Added!");
        }
    }

    class Product
    {
        public Product()
        {
            
        }

        private int _id;
        private string _name;

        public Product(int id, string name)
        {
            _id = id;
            _name = name;
        }
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
