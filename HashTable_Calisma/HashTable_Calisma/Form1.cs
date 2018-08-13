using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;


namespace HashTable_Calisma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Hashtable sehirler = new Hashtable();
     
        public void Listele()
        {
            ListViewItem item = new ListViewItem();
            ICollection kod = sehirler.Keys;
            listView1.Clear();

            //Kolon Başlıkları ve Genişlikleri
            listView1.Columns.Add("İl Kodu", 60);
            listView1.Columns.Add("İl Adı", 120);

            listView1.View = View.Details;
            listView1.GridLines = true;

            foreach (String eleman in kod)
            {
                item = listView1.Items.Add(eleman);
                item.SubItems.Add(sehirler[eleman].ToString());
            }
            //Küçükten büyüğe sıralama 
            
            listView1.Sorting = SortOrder.Ascending;

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            //Hashtable değer ekleme.
            sehirler.Add("322", "ADANA");
            sehirler.Add("416", "ADIYAMAN");
            sehirler.Add("272", "AFYON");
            sehirler.Add("472", "AĞRI");
            sehirler.Add("382", "AKSARAY");
            Listele();
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            sehirler.Add(textBox1.Text, textBox2.Text); //Değer Ekleme
            textBox1.Text = "";
            textBox2.Text = "";
            Listele();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Ara butonu
            string anahtar = textBox3.Text;
            label3.Text = sehirler[anahtar].ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            sehirler.Remove(textBox4.Text);
            textBox4.Text = "";
            Listele();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }
    }
}
