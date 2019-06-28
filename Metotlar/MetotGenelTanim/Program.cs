using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            HelloMethod();
            Ogrenci o1 = new Ogrenci();
            o1.SelamlaOgrenci();
            Console.ReadLine();
        }

        static void HelloMethod()
        {
            Console.WriteLine("Hello Method");
        }
    }
}
