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

        private static string[] yenidenboyutlandır(string[] dizi, int limit)
        {
            string[] temp = new string[limit];

            for (int i = 0; i < dizi.Length; i++)
            {
                temp[i] = dizi[i];

            }

            return temp;
        }



        static void Main(string[] args)
        {
            Program cl = new Program();
            string[] isimler = new string[5];
            isimler[0] = "sami";
            isimler[1] = "mehmet";
            isimler[2] = "murat";
            isimler[3] = "selma";
            isimler[4] = "hatice";
            //isimler = yenidenboyutlandır(isimler, isimler.Length + 1);
            //cl.tersyazdir();
            //cl.kelimebul();
            //cl.metot1();

            //Varlık Kontrolü

            bool kontrol = Array.Exists(isimler, I => I == "hatice");

            if (kontrol)
            {
                Console.WriteLine("Aradığınız değer koleksiyonda vardır.");
                string deger = Array.Find(isimler, I => I == "sami");
                Console.WriteLine("Array find  : "+deger);
                int bulunanindex = Array.IndexOf(isimler, "mehmet");
                Console.WriteLine("Indexof  : " + bulunanindex);
                Array.Sort(isimler);//a-z ye sıralar 

                Array.Reverse(isimler);//son indexten ilk indexe doğru sıralar
            }






            Console.ReadLine();

        }
      




    }
}
