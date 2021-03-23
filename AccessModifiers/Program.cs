using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifiers
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    class Customer
    {
        private int Id; //Tanımlandığı blokta kullanılır.
        protected int Yas; //inheritance ile kullanıldığında başka classlarda kullanılabilir.

        public void Save()
        {
            
        }

        public void Delete()
        {

        }
    }

    class Student:Customer
    {
        public void Save2()
        {
            Customer customer = new Customer();
            
        }
    }
    //ASSEMBLY : Montaj, meclis demek.
    //Bir class ya internal olur ya da Public olur.Özel durumlar hariç.

    public class Course //Classın defaultı İNTERNALdır.
    {
        public string Name { get; set; }
    }
}
