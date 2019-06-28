using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloClass
{
    public class Musteri
    {
        /*
         * TCKimlik No
         * İsim
         * Soyisim
         * Cinsiyet
         */
        public Musteri()//Yapıcı Metot - Constructors  Mthod
        {

        }
        public Musteri(string tcno)
        {
            TCKimlik = tcno;
        }
        public Musteri(string tcno , string isim)
        {
            TCKimlik = tcno;
            ad = isim;
        }




        public string TCKimlik;
        public string ad;
        public string soyad;
        public int cinsiyet; // 717770001 :Bay 717770002 : Bayan

        public bool MusteriCheck()
        {
            //e.g ( Musteri class'ında MusteriCheck adlı musteri kontrol eden bir metot.)
            bool control = MusteriDatabase(TCKimlik);
            return control;
        }
        private bool MusteriDatabase(string tcno)
        {
            //e.g Database Check 
            return true;

        }

    }
}
