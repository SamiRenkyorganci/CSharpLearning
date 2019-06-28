using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            paramskullanımı(2, 3, 5, 5);//Değişken sayıda parametre alabiliriz.
            paramskullanımı(2, 3, 78);
            Console.ReadLine();
        }

        static void paramskullanımı(params int[] sayilar)//son parametre olmalıdır.
        {

            int toplam = 0;

            for (int i = 0; i < sayilar.Length; i++)
            {
                toplam += sayilar[i];
            }
            Console.WriteLine("Toplam = {0}", toplam);
         }
    }
}
