using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DegiskenTipi
{
    class Program
    {
        static void Main(string[] args)
        {

            string value = "Sami Renkyorganci";
            int number1 = 12;//Değer tipli değişken
            int number2 = 8;
            int number3 = number1; //Stack bölgede saklanırlar. 

            Console.WriteLine(number1);
            Console.WriteLine(number2);
            Console.WriteLine(number3);
            number3 = 44;

            Console.WriteLine("Number1 {0}", number1);
            Console.WriteLine("Number3 {0}", number3);

            Console.ReadLine();


        }
    }
}
