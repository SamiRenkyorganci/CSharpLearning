using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloClass
{
     class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri = new Musteri();
            musteri.TCKimlik = "12312316885";
            musteri.ad = "Sami";
            musteri.soyad = "Renkyorganci";
            musteri.cinsiyet = 717770001;

            Musteri musteri2 = musteri;
            musteri2.ad = "murat";
            musteri.TCKimlik = "1174123522";
            Musteri m1 = new Musteri("1234567890", "Samet");

            bool kontrol = musteri.MusteriCheck();


            musteri = null;// Garbage Collection
            Console.ReadLine();
        }
    }
}
