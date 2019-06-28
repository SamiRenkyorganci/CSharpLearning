using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamplesClass
{
  public  class Araclar
    {
        public Araclar()
        {

        }
        public Araclar(string _marka, string _model)
        {
            marka = _marka;
            model = _model;
        }
        public Araclar(string _marka, string _model , int modelyil)
        {
            marka = _marka;
            model = _model;
            yil = modelyil;

        }

        public Araclar(string _marka, string _model, int modelyil,decimal _km)
        {
            marka = _marka;
            model = _model;
            yil = modelyil;
            km = _km;
        }





        public string marka;
        public string model;
        public int yil;
        public decimal km;
        public int yakit;
        public int vites;
        public decimal alisfiyat;
        public decimal satisfiyat;
        public decimal maxindirimtutar;
        public decimal fiyat;

        public void BilgiGoruntule()
        {

            Console.WriteLine("Marka :{0}  -  Model: {1}  -  Model Yil: {2} ", marka, model, yil);

        }
        public void FiyatAta(decimal fyt)
        {
            decimal oran = satisfiyat - maxindirimtutar;

            if(fyt<oran)
            {
                Console.WriteLine("Geçersiz Fiyat girişi");
            }
            else
            {
                this.fiyat = fyt;
                Console.WriteLine("Fiayt Güncellendi");
            }

        }



    }
}
