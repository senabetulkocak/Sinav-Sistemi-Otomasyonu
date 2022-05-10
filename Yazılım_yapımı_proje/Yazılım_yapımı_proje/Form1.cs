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

        //sena SqlConnection baglan = new SqlConnection("Data Source=DESKTOP-52OSE7G;Initial Catalog=sınav_sistemi;Integrated Security=True");
        SqlConnection baglan = new SqlConnection(@"Data Source=DESKTOP-56SRHAG;Initial Catalog=sınav_sistemi;Integrated Security=True");

        private void rdiobtn_girisYap_CheckedChanged(object sender, EventArgs e)
        {
            
        }

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
            MessageBox.Show("Geçici Kullanıcı adınız: Sena\nŞifreniz: Reyyan");
        }

        private void btn_kayitOl_Click(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
