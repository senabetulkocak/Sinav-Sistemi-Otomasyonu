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
using System.IO;

namespace Yazılım_yapımı_proje
{
    
    public partial class Sinav_Sorumlusu_Ekran : Form
    {
        public Sinav_Sorumlusu_Ekran()
        {
            InitializeComponent();
        }
        //sena SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-52OSE7G;Initial Catalog=sınav_sistemi;Integrated Security=True");
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-56SRHAG;Initial Catalog=sınav_sistemi;Integrated Security=True");
        string imagepath;
        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FileStream filestream = new FileStream(imagepath, FileMode.Open, FileAccess.Read);
            BinaryReader binaryreader = new BinaryReader(filestream);
            byte[] resim = binaryreader.ReadBytes((int)filestream.Length);
            binaryreader.Close();
            filestream.Close();

            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into tblSorular (soru_metni,soru_resmi,a_sikki,b_sikki,c_sikki,d_sikki,ders_adi,unite_adi,konu_adi,sinif_duzeyi,unite_no,konu_no,soru_no,kod_no,cevap) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@p10,@p11,@p12,@p13,@p14,@p15)",baglanti);
            komut.Parameters.AddWithValue("@p1", txtmetin.Text);
            komut.Parameters.Add("@p2", SqlDbType.Image, resim.Length).Value = resim;
            komut.Parameters.AddWithValue("@p3", txtasikki.Text);
            komut.Parameters.AddWithValue("@p4", txtbsikki.Text);
            komut.Parameters.AddWithValue("@p5", txtcsikki.Text);
            komut.Parameters.AddWithValue("@p6", txtdsikki.Text);
            komut.Parameters.AddWithValue("@p7", txtders.Text);
            komut.Parameters.AddWithValue("@p8", txtunite.Text);
            komut.Parameters.AddWithValue("@p9", txtkonu.Text);
            komut.Parameters.AddWithValue("@p10", txtsinif.Text);
            komut.Parameters.AddWithValue("@p11", txtuniteno.Text);
            komut.Parameters.AddWithValue("@p12", txtkonuno.Text);
            komut.Parameters.AddWithValue("@p13", txtsoruno.Text);
            komut.Parameters.AddWithValue("@p14", txtkodno.Text);
            komut.Parameters.AddWithValue("@p15", txtcevap.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Soru başarıyla eklendi.");
        }
       
        private void btnsecme_Click(object sender, EventArgs e)
        {
            openFileDialog1.Title = "Resim Seç";
            openFileDialog1.Filter = "Png dosyaları (*.png)|*.png";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);
                imagepath = openFileDialog1.FileName;
                txtresim.Text = openFileDialog1.FileName;
            }


        }


        private void btntemizle_Click(object sender, EventArgs e)
        {
            txtmetin.Clear();
            txtasikki.Clear();
            txtbsikki.Clear();
            txtcsikki.Clear();
            txtdsikki.Clear();
            txtcevap.Clear();
            txtresim.Clear();
        }

        private void Sinav_Sorumlusu_Ekran_Load(object sender, EventArgs e)
        {

        }
    }
}
