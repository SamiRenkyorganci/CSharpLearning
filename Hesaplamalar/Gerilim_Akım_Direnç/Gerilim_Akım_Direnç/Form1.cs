using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gerilim_Akım_Direnç
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double gerilim = 0;
        double akim = 0;
        double direnc = 0;

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }
        /*
         * Gerilim (V) = Akım (I) x Direnç (R)
           Akım (I) = Gerilim (V) / Direnç (R)
           Direnç (R) = Gerilim (V) / Akım (I)*/



        private void button1_Click(object sender, EventArgs e)
        {//Gerilim Hesaplaması

            akim = Convert.ToDouble(textBox1.Text);//Textboxt textini double ye çeviriyoruz.
            direnc = Convert.ToDouble(textBox2.Text);
            gerilim = akim * direnc;
            gerilimdegeri.Text = Math.Round(gerilim, 2).ToString();
            //Degeri yuvarlıyoruz.
            textBox1.Text = "";
            textBox2.Text = "";//Textboxların içlerini boşaltıyoruz.
        }

        private void button2_Click(object sender, EventArgs e)
        {//Akımın Hesaplanması
            gerilim = Convert.ToDouble(textBox4.Text);
            direnc = Convert.ToDouble(textBox3.Text);
            akim = gerilim / direnc;
            akimdegeri.Text = Math.Round(akim, 2).ToString();
            textBox3.Text = "";
            textBox4.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Direncin Hesaplanması
            gerilim = Convert.ToDouble(textBox6.Text);
            akim = Convert.ToDouble(textBox5.Text);
            direnc = gerilim / akim;
            direncdegeri.Text = Math.Round(direnc, 2).ToString();
            textBox5.Text = "";
            textBox6.Text = "";
        }
    }
    
}
