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
    public partial class Ayarlar : Form
    {
        public Ayarlar()
        {
            InitializeComponent();
        }

        private void btn_ayarlarDonOgrenciEkrani_Click(object sender, EventArgs e)
        {
            Ogrenci_Giris_Ekrani ogrDon = new Ogrenci_Giris_Ekrani();
            ogrDon.Show();
            this.Hide();
        }

        private void btn_ayarlarKaydet_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ayarlarınız başarıyla kaydedildi!");
        }
    }
}
