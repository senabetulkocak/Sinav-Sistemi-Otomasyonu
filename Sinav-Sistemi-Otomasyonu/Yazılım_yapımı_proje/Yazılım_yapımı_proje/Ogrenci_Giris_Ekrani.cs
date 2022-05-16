using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Yazılım_yapımı_proje
{
    public partial class Ogrenci_Giris_Ekrani : Form
    {
        public Ogrenci_Giris_Ekrani()
        {
            InitializeComponent();
        }

        private void btn_geriDon_Click(object sender, EventArgs e)
        {
            Form1 geriDon = new Form1();
            geriDon.Show();
            this.Hide();
        }

        private void btn_ogrEkran_sinavaGir_Click(object sender, EventArgs e)
        {
            Sinava_gir sinavGir = new Sinava_gir();
            sinavGir.Show();
            this.Hide();
        }

        private void btn_ogrEkran_sonucGor_Click(object sender, EventArgs e)
        {
            Sonuclar sonuc = new Sonuclar();
            sonuc.Show();
            this.Hide();
        }

        private void btn_ayarlar_Click(object sender, EventArgs e)
        {
            Ayarlar ayar = new Ayarlar();
            ayar.Show();
            this.Hide();
        }
    }
}
