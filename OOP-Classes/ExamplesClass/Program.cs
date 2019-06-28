using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamplesClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Araclar A1 = new Araclar("Opel", "Corsa", 2010, 52000);
            A1.alisfiyat = 28000;
            A1.satisfiyat = 32000;
            A1.maxindirimtutar = 1500;
            A1.FiyatAta(31000);//Fiyatlar metodu
            A1.BilgiGoruntule();

            Console.ReadLine();


        }
    }
}
