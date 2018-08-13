using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace ogrenciler
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            griddoldur();
            con = new SqlConnection("Data Source =.; Initial Catalog = ogrenci; Integrated Security = true");
        }
        SqlConnection con;
        SqlDataAdapter da;
        SqlCommand cmd;
        DataSet ds;
        
        private void label1_Click(object sender, EventArgs e)
        {

        }
    
         void griddoldur()
        {
            con = new SqlConnection("Data Source =.; Initial Catalog = ogrenci; Integrated Security = true");
            da = new SqlDataAdapter("Select *From ogrenciler", con);
            ds = new DataSet();
            con.Open();
            da.Fill(ds, "ogrenciler");
            dataGridView1.DataSource = ds.Tables["ogrenciler"];
            con.Close();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            griddoldur();
            
        }
        private void button1_Click(object sender, EventArgs e)//EKLE BUTTONU
        {
            
            cmd = new SqlCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "insert into ogrenciler(ogrenci_no,ogrenci_ad,ogrenci_soyad,ogrenci_sehir) values (" + textBox1.Text + ",'" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "')";
            cmd.ExecuteNonQuery(); 
            con.Close();
            griddoldur();
        }

        private void button2_Click(object sender, EventArgs e)//GÜNCELLE BUTTONU
        {
            cmd = new SqlCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "update ogrenciler set ogrenci_ad='" + textBox2.Text + "',ogrenci_soyad='" + textBox3.Text + "',ogrenci_sehir='" + textBox4.Text + "' where ogrenci_no=" + textBox1.Text + "";
            cmd.ExecuteNonQuery();
            con.Close();
            griddoldur();
        }

        private void button3_Click(object sender, EventArgs e)//SİL BUTTONU
        {
            cmd = new SqlCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "delete from ogrenciler where ogrenci_no=" + textBox1.Text + "";
            cmd.ExecuteNonQuery();
            con.Close();
            griddoldur();
        }
    }
}
