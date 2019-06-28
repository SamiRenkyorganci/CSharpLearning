using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basit_Not_Hesaplama
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--NOT HESAPLAMA UYGULAMASI ");

            Console.WriteLine("Lütfen Vize Notunuzu giriniz : ");
            int vize = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Lütfen Final Notunuzu giriniz : ");
            int final = Int32.Parse(Console.ReadLine());
            double ort = (vize * 40 / 100) + (final * 60 / 100);

            if (vize > 100 || vize < 0 || final > 100 || final < 0)
            {
                Console.WriteLine("Girdiğiniz not 0-100 arasında bir değer olmalıdır...");

            }

            //Kullanıcıdan int değerli not istediğimiz için int parse yapıyoruz.

            Console.WriteLine("Not Ortalmanız : {0}", ort);

            //if-else ile yapımı
            if (final < 30)
            {
                Console.WriteLine("Ne yazıkki FF final notunuz çok düşük!");
            }

            if (ort >= 85)
            {
                Console.WriteLine("Mükemmel ! AA ile geçtiniz");

            }
            else if (75 <= ort && ort < 85)
            {
                Console.WriteLine("Süpersin ! BA ile geçtiniz");

            }
            else if (70 <= ort && ort < 75)
            {
                Console.WriteLine("Tebrikler ! BB ile geçtiniz");

            }
            else if (65 <= ort && ort < 70)
            {
                Console.WriteLine("OO güzel ! CB ile geçtiniz");

            }
            else if (50 <= ort && ort < 65)
            {
                Console.WriteLine("Hadi iyisin ! CC ile geçtiniz");

            }
            else if (45 <= ort && ort < 50)
            {
                Console.WriteLine("Malesef ! DC ile aldınız");

            }
            else if (40 <= ort && ort < 45)
            {
                Console.WriteLine("Malesef ! DD ile alıdınız");

            }
            else if (0 <= ort && ort < 40)
            {
                Console.WriteLine("FF ile kaldınız :(");

            }


            else
            {
                Console.WriteLine("Galiba yanlış bir değer girdin...");
            }



            Console.ReadLine();
        }
    }
}
