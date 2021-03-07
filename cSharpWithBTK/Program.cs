using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharpWithBTK
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello world");
            char character = 'A';
            string city = "Ben bir metinim :) "; //karakterleren oluşan bir dizidir yani referans tiptir!!
            bool condition = false;
            double number5 = 5.655;       //64 bit
            decimal number6 = 9.444545m; //tam sayı aldığında m/M harfi konulmaz. Double a göre daha hassas.
            byte number4 = 255;          //8 bit 0-255 arasında
            short number3 = -5455;       //16 bit
            int number1 = 10;            //32 bit
            long number2 = 1000545;      //64 bit
            var number7 = 10;
            number7 = 'B'; //number7 artık hep int tutar!!!
            Console.WriteLine("Number: {0}", number1);
            Console.WriteLine("Number: {0}", number2);
            Console.WriteLine("Number: {0}", number3);
            Console.WriteLine("Number: {0}", number4);
            Console.WriteLine("Number: {0}", number5);
            Console.WriteLine("Number: {0}", number6);
            Console.WriteLine("Number: {0}", number7);
            Console.WriteLine("Number: {0}", condition);
            Console.WriteLine("Number: {0}", city);
            Console.WriteLine("Character: {0}", (int)character);
            Console.WriteLine((int)Days.Friday);
            Console.ReadLine();
        }
    }
    enum Days
    {
        Monday, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday
        //Alt alta stringsel ifadeler için kolaylık sağlar

    }
}
