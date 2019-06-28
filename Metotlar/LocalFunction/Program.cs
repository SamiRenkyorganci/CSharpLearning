using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocalFunction
{
    class Program
    {
        static void Main(string[] args)
        {
            LFMethod(11, 12);
            //sum(1,2); Çalışmaz. Ömrü LFMethod içersinde olduğu kadardır localdir.
           

        }

         static void LFMethod(int sayi1, int sayi2)// .Net Framework 4.7*
        {
            int sum(int a , int b )
            {
                return a + b;

            }
            int result = sum(sayi1, sayi1);
            Console.WriteLine(result);


        }
    }
}
