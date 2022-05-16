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

namespace Yazılım_yapımı_proje
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection baglan = new SqlConnection("Data Source=DESKTOP-52OSE7G;Initial Catalog=sınav_sistemi;Integrated Security=True");
<<<<<<< Updated upstream

       
        private void rdiobtn_girisYap_CheckedChanged(object sender, EventArgs e)
        {
            
        }
=======
        //reyyan SqlConnection baglan = new SqlConnection(@"Data Source=DESKTOP-56SRHAG;Initial Catalog=sınav_sistemi;Integrated Security=True");
>>>>>>> Stashed changes

        private void btn_girisYap_Click(object sender, EventArgs e)
        {
            //radiobutton kodu
            if ((rdiobtn_girisYap.Checked == true) && (rdiobtn_girisYap_sinavSor.Checked == true))
            {
                if ((txt_giris_kullaniciAd.Text == "Sena") && (txt_giris_sifre.Text == "Reyyan"))
                {
                    Sinav_Sorumlusu_Ekran sinavSor = new Sinav_Sorumlusu_Ekran();
                    sinavSor.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Giriş reddedildi. Lütfen tekrar deneyiniz.");
                }
            }

            else if ((rdiobtn_girisYap.Checked == true) && (rdiobtn_girisYap_ogrenci.Checked == true))
            {
                if ((txt_giris_kullaniciAd.Text == "Sena") && (txt_giris_sifre.Text == "Reyyan"))
                {
                    Ogrenci_Giris_Ekrani ogrenciEkran=new Ogrenci_Giris_Ekrani();
                    ogrenciEkran.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Giriş reddedildi. Lütfen tekrar deneyiniz.");
                }
            }

            else if ((rdiobtn_girisYap.Checked == true) && (rdiobtn_adminGirisi.Checked == true))
            {
                if ((txt_giris_kullaniciAd.Text == "Sena") && (txt_giris_sifre.Text == "Reyyan"))
                {
                    Admin_Panel adminEkran = new Admin_Panel();
                    adminEkran.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Giriş reddedildi. Lütfen tekrar deneyiniz.");
                }
            }
            else
            {
                MessageBox.Show("Lütfen işaretlediğiniz kutucuğun doğru olup olmadığını kontrol ediniz..");
            }

        }

        private void linklbl_sifremiUnuttum_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
        }

        private void btn_kayitOl_Click(object sender, EventArgs e)
        {
<<<<<<< Updated upstream
            
=======
            if ((rdiobtn_kayitOl.Checked == true) && (rdiobtn_kayitOl_sinavSorum.Checked == true))
            {
                baglan.Open();
                SqlCommand komut = new SqlCommand("insert into tblSinavSorumlusu (sorumlu_adi,sorumlu_soyadi,sorumlu_kullanici_adi,sorumlu_sifre) values ('"+txt_kayitOl_ad.Text.ToString()+"','"+txt_kayitOl_soyad.Text.ToString()+"','"+txt_KayitOl_kullanici.Text.ToString()+"','"+txt_kayitOl_sifre.Text.ToString()+"')",baglan);
                komut.ExecuteNonQuery();
                baglan.Close();
                MessageBox.Show("Kayıt eklendi.");
                txt_kayitOl_ad.Clear();
                txt_kayitOl_soyad.Clear();
                txt_KayitOl_kullanici.Clear();
                txt_kayitOl_sifre.Clear();
            }
            else if((rdiobtn_kayitOl.Checked == true) && (rdiotbn_kayitOl_ogrenci.Checked == true))
            {
                baglan.Open();
                SqlCommand komut = new SqlCommand("insert into tblOgrenci (ogr_adi,ogr_soyadi,ogr_kullanici_adi,ogr_sifre) values ('" + txt_kayitOl_ad.Text.ToString() + "','" + txt_kayitOl_soyad.Text.ToString() + "','" + txt_KayitOl_kullanici.Text.ToString() + "','" + txt_kayitOl_sifre.Text.ToString() + "')", baglan);
                komut.ExecuteNonQuery();
                baglan.Close();
                MessageBox.Show("Kayıt eklendi.");
                txt_kayitOl_ad.Clear();
                txt_kayitOl_soyad.Clear();
                txt_KayitOl_kullanici.Clear();
                txt_kayitOl_sifre.Clear();
            }
            else
            {
                MessageBox.Show("Lütfen işaretlediğiniz kutucuğun doğru olup olmadığını kontrol ediniz..");
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
>>>>>>> Stashed changes
        }
    }
}
