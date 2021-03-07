using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{ //DON'T REPEAT YOURSELF!!!
    class Program
    {
        static void Main(string[] args)
        {
            Add();
            var result = Add2(9,7);

            int number1 = 10;
            int number2 = 20;
            var result2 = Add3(ref number1, number2);
            Console.WriteLine(result2);
            Console.WriteLine(number1);

            Console.WriteLine(Multiply(4,8));
            Console.WriteLine(Multiply(4,9,2));

            Console.WriteLine(Add4(1,2,3,4,5,6));
            Console.ReadLine();
        }
        static void Add()
        {
            Console.WriteLine("Added!!");
        }
        static int Add2(int number1=10, int number2=50) //eşitlediğimizde default değer olarak çalışır!!!
        {
            var result=  number1 + number2;
            return result;
        
        }
        static int Add3(ref int number1, int number2)
        {   
            number1 = 40; //number1 1 kereliğine 40 değerini almıştır ama asıl değri 10dur.
            return number1 + number2;
        }
        static int Multiply(int number1, int number2)
        {
            return number1 * number2;
        }
        static int Multiply(int number1, int number2,int number3) //Overloading = aşırı yükleme
        {
            return number1 * number2 * number3;
        }
        static int Add4(params int[] numbers) //çokça aynı tipte parametreyi art arda işlem yapmak için kullanılır.
        { //params dan önce parametre gelebilir ama sonra parametre gelemez.
          //en son parametrenin params olması lazım...(int number,params int[] numbers)

            return numbers.Sum(); //sum hazır fonksiyondur.
        }

    }
}
