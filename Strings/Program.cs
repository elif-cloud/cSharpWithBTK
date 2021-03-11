using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string city = "Ankara"; //Stringler char array'dir.
            Console.WriteLine(city[0]);

            foreach (var item in city)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();
            string city2 = "İstanbul";
            //string result = city + city2;
            //Console.WriteLine(result);

            Console.WriteLine(string.Format("{0} {1}", city,city2));

            Console.ReadLine();

        }
    }
}
