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
    public partial class Admin_Panel : Form
    {
        public Admin_Panel()
        {
            InitializeComponent();
        }
        
        SqlConnection baglan = new SqlConnection("Data Source=DESKTOP-52OSE7G;Initial Catalog=sınav_sistemi;Integrated Security=True");
        //reyyan SqlConnection baglan = new SqlConnection(@"Data Source=DESKTOP-56SRHAG;Initial Catalog=sınav_sistemi;Integrated Security=True");

        private void ogrenciVerileriGoster()
        {
            baglan.Open();
            SqlCommand komut = new SqlCommand("Select *from tblOgrenci", baglan);
            SqlDataReader oku = komut.ExecuteReader();

            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["ogr_id"].ToString();
                ekle.SubItems.Add(oku["ogr_adi"].ToString());
                ekle.SubItems.Add(oku["ogr_soyadi"].ToString());
                ekle.SubItems.Add(oku["ogr_kullanici_adi"].ToString());
                ekle.SubItems.Add(oku["ogr_sifre"].ToString());
                ekle.SubItems.Add(oku["ogr_dogru_sayisi"].ToString());
                ekle.SubItems.Add(oku["ogr_yanlis_sayisi"].ToString());

                listView_ogrenci.Items.Add(ekle);
            }
            baglan.Close();

        }

        private void sinavSorumlusuVerileriGoster()
        {
            baglan.Open();
            SqlCommand komut = new SqlCommand("Select *from tblSinavSorumlusu", baglan);
            SqlDataReader oku = komut.ExecuteReader();

            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["sorumlu_id"].ToString();
                ekle.SubItems.Add(oku["sorumlu_adi"].ToString());
                ekle.SubItems.Add(oku["sorumlu_soyadi"].ToString());
                ekle.SubItems.Add(oku["sorumlu_kullanici_adi"].ToString());
                ekle.SubItems.Add(oku["sorumlu_sifre"].ToString());

                listView_sinavSor.Items.Add(ekle);
            }
            baglan.Close();

        }

        private void adminVerileriGoster()
        {
            baglan.Open();
            SqlCommand komut = new SqlCommand("Select *from tblAdmin", baglan);
            SqlDataReader oku = komut.ExecuteReader();

            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["admin_id"].ToString();
                ekle.SubItems.Add(oku["admn_kullanici_adi"].ToString());
                ekle.SubItems.Add(oku["admin_sifre"].ToString());

                listView_admin.Items.Add(ekle);
            }
            baglan.Close();

        }

        private void soruVerileriGoster()
        {
            baglan.Open();
            SqlCommand komut = new SqlCommand("Select *from tblSorular", baglan);
            SqlDataReader oku = komut.ExecuteReader();

            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["soru_id"].ToString();
                ekle.SubItems.Add(oku["soru_metni"].ToString());
                ekle.SubItems.Add(oku["a_sikki"].ToString());
                ekle.SubItems.Add(oku["b_sikki"].ToString());
                ekle.SubItems.Add(oku["c_sikki"].ToString());
                ekle.SubItems.Add(oku["d_sikki"].ToString());
                ekle.SubItems.Add(oku["ders_adi"].ToString());
                ekle.SubItems.Add(oku["unite_adi"].ToString());
                ekle.SubItems.Add(oku["konu_adi"].ToString());
                ekle.SubItems.Add(oku["sinif_duzeyi"].ToString());
                ekle.SubItems.Add(oku["unite_no"].ToString());
                ekle.SubItems.Add(oku["konu_no"].ToString());
                ekle.SubItems.Add(oku["soru_no"].ToString());
                ekle.SubItems.Add(oku["kod_no"].ToString());
                ekle.SubItems.Add(oku["cevap"].ToString());
                ekle.SubItems.Add(oku["sorunun_dogru_sayisi"].ToString());

                listView_sorular.Items.Add(ekle);
            }
            baglan.Close();

        }
        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void Admin_Panel_Load(object sender, EventArgs e)
        {
            ogrenciVerileriGoster();
            sinavSorumlusuVerileriGoster();
            adminVerileriGoster();
            soruVerileriGoster();
        }

        private void btn_geriDon_Click(object sender, EventArgs e)
        {
            Form1 anaForm = new Form1();
            anaForm.Show();
            this.Hide();
        }
    }
}
