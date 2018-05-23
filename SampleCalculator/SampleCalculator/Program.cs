using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            // İki deger kullanıcıdan alınacak
            // toplama, çıkarma, bölme ve çarpma işlemi seçtirilecek.

            int sayi1, sayi2;
            double sonuc;

            Console.Write("Sayı 1 i giriniz : ");
            sayi1 = int.Parse(Console.ReadLine());
            Console.Write("Sayı 2 i giriniz : ");
            sayi2 = int.Parse(Console.ReadLine());

          
            int secim;
            Console.WriteLine(" Toplama İşlemi 1 \n Çıkarma İşlemi 2 \n Çarpma İşlemi 3 \n Bölme İşlemi 4 \n \n : ");
            secim = int.Parse(Console.ReadLine());

            
           

            switch (secim)
            {
                case 1:
                    
                  sonuc = (double)sayi1 + (double)sayi2;
                    Console.Write("İşlem Sonucu : {0}", sonuc);
                    break;
                case 2:
                    if (sayi1 > sayi2)
                    {
                        sonuc = (double)sayi1 - (double)sayi2;
                        Console.Write("İşlem Sonucu : {0}", sonuc);
                    }
                    else
                    {
                      
                        sonuc = (double)sayi2 - (double)sayi1;
                        Console.Write("İşlem Sonucu : {0}", sonuc);
                    }
                        
                    break;
                case 3:
                    
                    sonuc = (double)sayi1 * (double)sayi2;
                    Console.Write("İşlem Sonucu : {0}", sonuc);
                    break;
                case 4:
                    if (sayi1 > sayi2)
                    {
                        
                        sonuc = (double)sayi1 / (double)sayi2;
                        Console.Write("İşlem Sonucu : {0}", sonuc);
                    }
                    else
                    {
                       
                        sonuc = (double)sayi2 / (double)sayi1;
                        Console.Write("İşlem Sonucu : {0}", sonuc);
                    }
                    break;


            }

            Console.ReadLine();

           



        }
    }
}
