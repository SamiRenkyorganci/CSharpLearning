using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverloading
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Sami Renkyorganci");//String 
            Console.WriteLine(true);//boolen

            sum("as", "bs");//string
            sum(1, 3);//int

            Console.ReadLine();
        }

        static void sum(int a, int b)
        {
            int result = a + b;
            Console.WriteLine(result);

        }
        static void sum(decimal a, decimal b)
        {
            decimal result = a + b;
            Console.WriteLine(result);

        }
        static void sum(string a, string b)
        {
            string result = a + b;
            Console.WriteLine(result);

        }
    }
}
