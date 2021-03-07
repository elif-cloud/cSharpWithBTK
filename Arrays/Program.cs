using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] students = new string[5];
            students[0] = "Elif";
            students[1] = "Sena";
            students[2] = "Şule";
            students[3] = "Mert";
            students[4] = "Merve";
            
            string[] students2 = { "Elif", "Sena", "Şule", "Mert", "Merve" };
           

            foreach (var student in students)
            {
                Console.WriteLine(student);
            }

            Console.WriteLine();

            string[,] regions = new string[5,3]
            {
                {"İstanbul", "İzmit","Sakarya" },
                {"Ankara","Konya","Kırıkkale" },
                {"Antalya", "Adana", "Mersin" },
                {"Rize", "Trabzon", "Samsun" },
                {"İzmir", "Muğla", "Manisa" },
            };
            //satırlar 0. daimontation sütunlar 1. daimontation.
            for (int i = 0; i <= regions.GetUpperBound(0); i++)
            {
                for (int j = 0; j <= regions.GetUpperBound(1); j++)
                {
                    Console.WriteLine(regions[i,j]);
                }
                Console.WriteLine("**********");
            }

            Console.ReadLine();
        }
    }
}
