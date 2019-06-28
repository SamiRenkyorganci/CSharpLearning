using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrtalamaHesaplaMethod
{
   public class Ogrenci
    {
        public void OgrenciPuanHesapla(string ad , string soyad , int not1 , int not2, int not3 = 45 /*not3ün değeri girilmesi zorunlu değil default 45 değeri alır */)
        {
            double ortalama = 0;

            ortalama = (double) (not1 + not2 + not3) / 3;

            if (ortalama < 45 )
            {
                Console.WriteLine("{0} {1} adlı ogrencinin Ortalama Notu : {2}", ad, soyad, Math.Round(ortalama, 2));
                Console.WriteLine("KALDI!!");
            }
            else
            {
                Console.WriteLine("{0} {1} adlı ogrencinin Ortalama Notu : {2}", ad, soyad, Math.Round(ortalama, 2));
                Console.WriteLine("GEÇTİ !");
            }


        }

    }
}
