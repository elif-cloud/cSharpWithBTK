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
            Console.WriteLine("---------------------");

            string sentence = "My name is elif canci.";

            var result = sentence.Length;
            var result2 = sentence.Clone();
            bool result3 = sentence.EndsWith("i");
            bool result4 = sentence.StartsWith("My name");
            var result5 = sentence.IndexOf("name"); //Bulamazsa -1 döndürür
            var result6 = sentence.IndexOf(" ");
            var result7 = sentence.LastIndexOf(" ");
            var result8 = sentence.Insert(0, "Hello, ");
            var result9 = sentence.Substring(3,4); //3. chardan itivaren 4 tane al
            var result10 = sentence.ToUpper();
            var result11 = sentence.ToLower();
            var result12 = sentence.Remove(2,3);
            var result13 = sentence.Replace(" ", "-");



            Console.WriteLine(result12);

            Console.ReadLine();

        }
    }
}
