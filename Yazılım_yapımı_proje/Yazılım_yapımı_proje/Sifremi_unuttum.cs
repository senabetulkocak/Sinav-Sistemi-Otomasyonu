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
    public partial class Sifremi_unuttum : Form
    {
        public Sifremi_unuttum()
        {
            InitializeComponent();
        }

        //reyyan SqlConnection baglan = new SqlConnection(@"Data Source=DESKTOP-56SRHAG;Initial Catalog=sınav_sistemi;Integrated Security=True");
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-52OSE7G;Initial Catalog=sınav_sistemi;Integrated Security=True");

        SqlCommand komut;
        SqlDataReader read;
        private void btn_sifreDegis_Click(object sender, EventArgs e)
        {
            if ((rdiobtn_sifDegis_sinavSor.Checked == true))
            {
                sifreSinavSor(txt_sifDegis_kullaniciAd,txt_sifDegis_sifre,txt_sifDegis_sifreTekrar);
            }

            else if ( (rdiobtn_sifDegis_ogrenci.Checked == true))
            {
                sifreOgrenci(txt_sifDegis_kullaniciAd, txt_sifDegis_sifre, txt_sifDegis_sifreTekrar);
            }

            else if ( (rdiobtn_sifDegis_admin.Checked == true))
            {
                sifreAdmin(txt_sifDegis_kullaniciAd, txt_sifDegis_sifre, txt_sifDegis_sifreTekrar);
            }
        }

        public void sifreSinavSor(TextBox kullanıcıAd, TextBox sifre, TextBox sifreTekrar)
        {
            if(sifre.Text==sifreTekrar.Text)
            {
                baglanti.Open();
                komut = new SqlCommand("select *from tblSinavSorumlusu where sorumlu_kullanici_adi= '"+kullanıcıAd.Text+"'",baglanti);
                read = komut.ExecuteReader();
                if (read.Read()==true)
                {
                    baglanti.Close();
                    baglanti.Open();
                    komut = new SqlCommand("update tblSinavSorumlusu set sorumlu_sifre='"+sifre.Text+"' where sorumlu_kullanici_adi= '"+kullanıcıAd.Text+"'",baglanti);
                    komut.ExecuteNonQuery();
                    baglanti.Close();
                    MessageBox.Show("İşlem başarılı.");
                    Form1 anaForm = new Form1();
                    anaForm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Bilgilerinizi kontrol ediniz.","Hata");
                }
                baglanti.Close();
            }
            else
            {
                MessageBox.Show("Şifreler uyuşmuyor ya da boş bıraktınız.", "Uyarı");
            }
        }

        public void sifreOgrenci(TextBox kullanıcıAd, TextBox sifre, TextBox sifreTekrar)
        {
            if (sifre.Text == sifreTekrar.Text)
            {
                baglanti.Open();
                komut = new SqlCommand("select *from tblOgrenci where ogr_kullanici_adi= '" + kullanıcıAd.Text + "'", baglanti);
                read = komut.ExecuteReader();
                if (read.Read() == true)
                {
                    baglanti.Close();
                    baglanti.Open();
                    komut = new SqlCommand("update tblOgrenci set ogr_sifre='" + sifre.Text + "' where ogr_kullanici_adi= '" + kullanıcıAd.Text + "'", baglanti);
                    komut.ExecuteNonQuery();
                    baglanti.Close();
                    MessageBox.Show("İşlem başarılı.");
                    Form1 anaForm = new Form1();
                    anaForm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Bilgilerinizi kontrol ediniz.", "Hata");
                }
                baglanti.Close();
            }
            else
            {
                MessageBox.Show("Şifreler uyuşmuyor ya da boş bıraktınız.", "Uyarı");
            }
        }

        public void sifreAdmin(TextBox kullanıcıAd, TextBox sifre, TextBox sifreTekrar)
        {
            if (sifre.Text == sifreTekrar.Text && (sifre.Text!=""))
            {
                baglanti.Open();
                komut = new SqlCommand("select *from tblAdmin where admn_kullanici_adi= '" + kullanıcıAd.Text + "'", baglanti);
                read = komut.ExecuteReader();
                if (read.Read() == true)
                {
                    baglanti.Close();
                    baglanti.Open();
                    komut = new SqlCommand("update tblAdmin set admin_sifre='" + sifre.Text + "' where admn_kullanici_adi= '" + kullanıcıAd.Text + "'", baglanti);
                    komut.ExecuteNonQuery();
                    baglanti.Close();
                    MessageBox.Show("İşlem başarılı.");
                    Form1 anaForm = new Form1();
                    anaForm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Bilgilerinizi kontrol ediniz.", "Hata");
                }
                baglanti.Close();
            }
            else
            {
                MessageBox.Show("Şifreler uyuşmuyor ya da boş bıraktınız.", "Uyarı");
            }
        }
    }
}
