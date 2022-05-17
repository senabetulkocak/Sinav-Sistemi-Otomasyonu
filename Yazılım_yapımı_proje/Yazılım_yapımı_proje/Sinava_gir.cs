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
            this.Close();
        }
        //reyyan SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-56SRHAG;Initial Catalog=sınav_sistemi;Integrated Security=True");
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-52OSE7G;Initial Catalog=sınav_sistemi;Integrated Security=True");
        private void Sinava_gir_Load(object sender, EventArgs e)
        {
            randomSoruGetir();
        }
        private void randomSoruGetir()
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select TOP 1 soru_metni,soru_resmi,a_sikki,b_sikki,c_sikki,d_sikki,ders_adi,unite_adi,konu_adi,sinif_duzeyi,unite_no,konu_no,soru_no,kod_no from tblSorular order by NEWID()", baglanti);
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

             
                //if (read["soru_resmi"] != null)
                //{
                //    Byte[] data = new Byte[0];
                //    data = (Byte[])(read["soru_resmi"]);
                //    MemoryStream mem = new MemoryStream(data);
                //    picbox_soru.Image = Image.FromStream(mem);
                //}
                //else if(read["soru_resmi"]==null)
                //{
                //    picbox_soru.Image=DBNull.Value 0;
                //}


            }
            baglanti.Close();
        }

        private void btn_sonrakiSoru_Click(object sender, EventArgs e)
        {
            int sayac = 0;
            do
            {
                randomSoruGetir();
            }
            while (sayac < 10);
            MessageBox.Show("Sınavınız bitmiştir.");
        }
       
    }
}
    

