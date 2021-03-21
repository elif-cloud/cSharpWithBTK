using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Person[] persons = new Person[3]
            {
                new Customer
                {
                    FirtName="Elif"
                }, new Student
                {
                    FirtName="Safiye"
                }, new Person
                {
                    FirtName="Şahin"
                }
            };
            foreach (var Person in persons)
            {
                Console.WriteLine(Person.FirtName);
            }

            Console.ReadLine();
        }

        class Person
        {
            public int Id { get; set; }
            public string FirtName { get; set; }
            public string LastName { get; set; }
        }
         
        class Customer:Person
        {
            public string City { get; set; }      
        }

        class Student:Person
        {
            public String Department { get; set; }
        }
    }
}
