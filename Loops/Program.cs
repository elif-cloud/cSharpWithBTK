using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 100; i+=5)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("Finished!!");

            //-----------------------------------
            int number = 100;

            while(number>=0)
            {
                Console.WriteLine(number);
                number-=5;
            }
            Console.WriteLine("Finished!!!");

            //----------------------------------

            int number1 = 10;
            do
            {
                Console.WriteLine(number1);
                number1--;

            } while (number1>=0);

            //-----------------------------------

            string[] students = { "Elif", "Sena", "Şule", "Mert", "Merve" };

            foreach (var student in students) //foreach ile döndüğün elemanları bloğun içinde değiştiremezsin!!!
            {
                Console.WriteLine(student);
            }
            //Dizi temelli dataları dolaşır.

            //-----------------------------------

            Console.WriteLine();

            if (IsPrimeNumber(7))
            {
                Console.WriteLine("tis is a prime number");
            }
            else
            {
                Console.WriteLine("this is not a prime number");
            }
            

            Console.ReadLine();

        }
        
        private static bool IsPrimeNumber(int number3)
        {
            bool result = true;

            for (int i = 2; i < number3-1; i++)
            {
                if (number3%i == 0)
                {
                    result = false;
                    i = number3;
                }
            }
            return result;

            Console.ReadLine();
        }
        
    }
}
