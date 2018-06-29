using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_Çalismalari
{
    class Program
    {
        public void tersyazdir()
        {//Girilen kelime veya cümlenin tersini yazdıran methot
            Console.WriteLine("Lutfen bir kelime giriniz");
            string kelime = Console.ReadLine();

            Console.WriteLine("Kelimeniz : {0}", kelime);


            for (int i = kelime.Length - 1; i >= 0; i--)
            {

                Console.Write(kelime[i]);

            }

        }
        public void kelimebul()
        {//Girilen cümledeki kelime sayısını bulan metot
            
            Console.WriteLine("Lutfen bir cünle giriniz");
            string cumle = Console.ReadLine();

            string[] kelimeler = cumle.Split(' ');
            Console.WriteLine("Kelime sayısı : {0} ",kelimeler.Length);




        }
         public void metot1()
        {//Klavyeden girilen sayıları okuyan ve sayıların toplamı 21'den 
         //büyük veya eşit olduğu zaman duran programın kodlarını yazınız


            int toplam = 0;
            do
            {
                Console.WriteLine("Lutfen sayı giriniz ");
                int sayi = Int32.Parse(Console.ReadLine());
                toplam += sayi;
                Console.WriteLine("Toplam :{0} ", toplam);

            } while (toplam<=21);

            Console.WriteLine("Toplam 21'e ulaştığı için sayı girmenize gerek yoktur.");
            }



        



        static void Main(string[] args)
        {

            Program cl = new Program();
            //cl.tersyazdir();
            //cl.kelimebul();
            cl.metot1();






            Console.ReadLine();

        }

       
    }
}
