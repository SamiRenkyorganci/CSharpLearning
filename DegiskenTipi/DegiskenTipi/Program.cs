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

            //IF ELSE

            int x = 22;
            int y = 15;

            if (x > y)
            {
                Console.WriteLine("x büyüktür y");
            }
            else
                Console.WriteLine("y büyüktür x");

            Console.WriteLine("-----------------");
            //ELSE IF
            x = 10;
            y = 10;
            if (x > y)
            {
                Console.WriteLine("x büyüktür y");
            }
            else if (x == y)
            {
                Console.WriteLine("y eşittir x");
            }
            else
                Console.WriteLine("y büyüktür x");
            //Switch Case

            Console.WriteLine("-------------------------------");

            int z = 12;

            switch (z)
            {
                case 1:
                    Console.WriteLine("1");
                 break;
                case 4:
                    Console.WriteLine("4");
                    break;
                case 5:
                    Console.WriteLine("5");
                    break;
                case 6:
                case 7:
                case 8:
                    Console.WriteLine("6-7-8");
                    break;
                case 12:
                    Console.WriteLine("Sayi bulundu");
                    break;

                default:
                    break;

            }
            Console.ReadLine();


        }
    }
}
