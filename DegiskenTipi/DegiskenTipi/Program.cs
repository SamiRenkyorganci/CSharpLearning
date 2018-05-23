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
            Console.Clear();//Consolu temizler.

            //Tür Dönüşümü (Parse)

            // Bilinçli Tür Dönüşümü (Conscious Species Transformation)
            decimal variable = 21;
            int variable2 = (int)variable;

            // Bilinçsiz Tür Dönüşümü (Unconscious Species Transformation)

            int a = 2;

            decimal b = a;

           




            Console.ReadLine();


        }
    }
}
