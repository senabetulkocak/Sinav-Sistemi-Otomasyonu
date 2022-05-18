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
    public partial class Sinava_gir : Form
    {
        public Sinava_gir()
        {
            InitializeComponent();
        }

        private void grpbx_sinavSorusu_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Sınavınız sonlandırıldı.");
            Ogrenci_Giris_Ekrani ogr = new Ogrenci_Giris_Ekrani();
            ogr.Show();
            this.Close();
        }
         SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-56SRHAG;Initial Catalog=sınav_sistemi;Integrated Security=True");
     //sena SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-52OSE7G;Initial Catalog=sınav_sistemi;Integrated Security=True");
        private void Sinava_gir_Load(object sender, EventArgs e)
        {         
            randomSoruGetir();

            

        }
                    
            
        public void randomSoruGetir()
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select TOP 1 soru_id,soru_metni,soru_resmi,a_sikki,b_sikki,c_sikki,d_sikki,ders_adi,unite_adi,konu_adi,sinif_duzeyi,unite_no,konu_no,soru_no,kod_no,cevap from tblSorular order by NEWID()", baglanti);
            SqlCommand cmd = new SqlCommand("insert into tblSonuclar (soru_id) values (@p1)", baglanti);   
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                lbl_sinifDuzeyi.Text = read["sinif_duzeyi"].ToString();
                lbl_uniteNo.Text = read["unite_no"].ToString();
                lbl_konuNo.Text = read["konu_no"].ToString();
                lbl_soruNo.Text = read["soru_no"].ToString();
                lbl_kodNo.Text = read["kod_no"].ToString();
                lbl_dersinAdi.Text = read["ders_adi"].ToString();
                lbl_uniteAdi.Text = read["unite_adi"].ToString();
                lbl_konuAdi.Text = read["konu_adi"].ToString();
                txtbox_soru.Text = read["soru_metni"].ToString();
                lbl_cevapA.Text = read["a_sikki"].ToString();
                lbl_cevapB.Text = read["b_sikki"].ToString();
                lbl_cevapC.Text = read["c_sikki"].ToString();
                lbl_cevapD.Text = read["d_sikki"].ToString();
                cmd.Parameters.AddWithValue("@p1", read["soru_id"].ToString());//soruid'i sonuçlar tablosuna atmak için yazıldı ama işe yaramadı
                if (read["soru_resmi"] != null && read["soru_resmi"] != DBNull.Value)
                {
                    Byte[] data = new Byte[0];
                    data = (Byte[])(read["soru_resmi"]);
                    MemoryStream mem = new MemoryStream(data);
                    picbox_soru.Image = Image.FromStream(mem);
                }
                 
             /* Radiobutton kontrollerini yapmaya çalıştık ama olmadı.
              * if (rdiobtn_A.Checked==true)
              {
                    if (read["cevap"].ToString() == "A")
                    {
                        MessageBox.Show("A cevabı doğru");
                    }
              }

               else if (rdiobtn_B.Checked == true)
                {
                    if (read["cevap"].ToString() == "B")
                    {
                        MessageBox.Show("B cevabı doğru");
                    }
                }

               else if (rdiobtn_C.Checked == true)
                {
                    if (read["cevap"].ToString() == "C")
                    {
                        MessageBox.Show("C cevabı doğru");
                    }
                }

               else if (rdiobtn_D.Checked == true)
                {
                    if (read["cevap"].ToString() == "D")
                    {
                        MessageBox.Show("D cevabı doğru");
                    }
                }*/

            }

            baglanti.Close();
        }

        int sayac = 1;
        private void btn_sonrakiSoru_Click(object sender, EventArgs e)
        {
            if (sayac < 10)
            {
                randomSoruGetir();
                sayac++;
            }
            else
            {
                MessageBox.Show("Sınavınız bitmiştir.");
                Ogrenci_Giris_Ekrani ogr_ = new Ogrenci_Giris_Ekrani();
                ogr_.Show();
                this.Close();

            }

        }
        

        private void lbl_ogrenci_adSoyad_Click(object sender, EventArgs e)
        {
            
        }

        /*Radiobutton kontrollerini yapmaya çalıştık ama olmadı.*/
          private void rdiobtn_A_CheckedChanged(object sender, EventArgs e)
        {
            /*baglanti.Open();
            SqlCommand komut = new SqlCommand("select TOP 1 soru_id,soru_metni,soru_resmi,a_sikki,b_sikki,c_sikki,d_sikki,ders_adi,unite_adi,konu_adi,sinif_duzeyi,unite_no,konu_no,soru_no,kod_no,cevap from tblSorular order by NEWID()", baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
            if (rdiobtn_A.Checked == true)
            {
                if (read["cevap"].ToString() == "A")
                {
                    MessageBox.Show("A cevabı doğru");
                }
            }
            }
            
            baglanti.Close();*/
        }

        private void rdiobtn_B_CheckedChanged(object sender, EventArgs e)
        {
           /* baglanti.Open();
            SqlCommand komut = new SqlCommand("select TOP 1 soru_id,soru_metni,soru_resmi,a_sikki,b_sikki,c_sikki,d_sikki,ders_adi,unite_adi,konu_adi,sinif_duzeyi,unite_no,konu_no,soru_no,kod_no,cevap from tblSorular order by NEWID()", baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
            if (rdiobtn_B.Checked == true)
            {
                if (read["cevap"].ToString() == "B")
                {
                    MessageBox.Show("B cevabı doğru");
                }
            }
            }
            
            baglanti.Close();*/
        }

        private void rdiobtn_C_CheckedChanged(object sender, EventArgs e)
        {
           /* baglanti.Open();
            SqlCommand komut = new SqlCommand("select TOP 1 soru_id,soru_metni,soru_resmi,a_sikki,b_sikki,c_sikki,d_sikki,ders_adi,unite_adi,konu_adi,sinif_duzeyi,unite_no,konu_no,soru_no,kod_no,cevap from tblSorular order by NEWID()", baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
            if (rdiobtn_C.Checked == true)
            {
                if (read["cevap"].ToString() == "C")
                {
                    MessageBox.Show("C cevabı doğru");
                }
            }
            }
            
            baglanti.Close();*/
        }

        private void rdiobtn_D_CheckedChanged(object sender, EventArgs e)
        {
           /* baglanti.Open();
            SqlCommand komut = new SqlCommand("select TOP 1 soru_id,soru_metni,soru_resmi,a_sikki,b_sikki,c_sikki,d_sikki,ders_adi,unite_adi,konu_adi,sinif_duzeyi,unite_no,konu_no,soru_no,kod_no,cevap from tblSorular order by NEWID()", baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
            if (rdiobtn_D.Checked == true)
            {
                if (read["cevap"].ToString() == "D")
                {
                    MessageBox.Show("D cevabı doğru");
                }
            }
            }
            
            baglanti.Close();*/
        }
    }
}
    

