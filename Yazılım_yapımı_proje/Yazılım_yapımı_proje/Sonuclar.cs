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
    public partial class Sonuclar : Form
    {
        public Sonuclar()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Ogrenci_Giris_Ekrani ogrEkran = new Ogrenci_Giris_Ekrani();
            ogrEkran.Show();
            this.Hide();
        }
    }
}
