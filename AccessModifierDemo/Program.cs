using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccessModifiers;

namespace AccessModifierDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Course course = new Course();
        }
    }
}
// Ben bu Course classını başka bir projeden eklemek için:
// 1. referans -> add referans hangi classı istiyosam o projeyi ekle.
// 2. kullanacağın projede isim uzayı olarak referans projenin adını yaz.
// 3. kullanacağın referans classı "public" olması lazım ki erişebilesin.

//Erişim bildirgecini yernde minimum kullan(LİST PRİVALAGE).
//Yoksa güvenlik açığına, okunabilirliğin azalmasına neden olur.
