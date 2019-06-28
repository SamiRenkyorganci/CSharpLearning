using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrtalamaHesaplaMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            string ad , soyad;
            int  not1 , not2 ,not3;
            Console.Write("Adınızı Giriniz: ");
            ad = Console.ReadLine();
            Console.Write("Soyadınızı Giriniz: ");
            soyad = Console.ReadLine();

            Console.Write("1. Sınav Notunuzu Giriniz: ");
            not1 = int.Parse(Console.ReadLine());
            Console.Write("2. Sınav Notunuzu Giriniz: ");
            not2 = int.Parse(Console.ReadLine());
            Console.Write("3. Sınav Notunuzu Giriniz: ");
            not3 = int.Parse(Console.ReadLine());

            Ogrenci o1 = new Ogrenci();
            o1.OgrenciPuanHesapla(ad, soyad, not1, not2, not3);

            Console.ReadLine();


        }
    }
}
