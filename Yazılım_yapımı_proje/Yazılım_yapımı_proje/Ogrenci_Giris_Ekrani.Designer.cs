
namespace Yazılım_yapımı_proje
{
    partial class Ogrenci_Giris_Ekrani
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ogrenci_Giris_Ekrani));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_ogrEkran_sinavaGir = new System.Windows.Forms.Button();
            this.btn_ogrEkran_sonucGor = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Info;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18.2F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(162, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(573, 38);
            this.label1.TabIndex = 1;
            this.label1.Text = "ÖĞRENCİ EKRANINA HOŞGELDİNİZ!";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 15.2F, System.Drawing.FontStyle.Italic);
            this.label2.Location = new System.Drawing.Point(209, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(451, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "Lütfen yapmak istediğiniz işlemi seçiniz..";
            // 
            // btn_ogrEkran_sinavaGir
            // 
            this.btn_ogrEkran_sinavaGir.BackColor = System.Drawing.Color.Gold;
            this.btn_ogrEkran_sinavaGir.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold);
            this.btn_ogrEkran_sinavaGir.Location = new System.Drawing.Point(339, 248);
            this.btn_ogrEkran_sinavaGir.Name = "btn_ogrEkran_sinavaGir";
            this.btn_ogrEkran_sinavaGir.Size = new System.Drawing.Size(183, 43);
            this.btn_ogrEkran_sinavaGir.TabIndex = 3;
            this.btn_ogrEkran_sinavaGir.Text = "Sınava Gir";
            this.btn_ogrEkran_sinavaGir.UseVisualStyleBackColor = false;
            // 
            // btn_ogrEkran_sonucGor
            // 
            this.btn_ogrEkran_sonucGor.BackColor = System.Drawing.Color.Gold;
            this.btn_ogrEkran_sonucGor.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold);
            this.btn_ogrEkran_sonucGor.Location = new System.Drawing.Point(305, 363);
            this.btn_ogrEkran_sonucGor.Name = "btn_ogrEkran_sonucGor";
            this.btn_ogrEkran_sonucGor.Size = new System.Drawing.Size(249, 43);
            this.btn_ogrEkran_sonucGor.TabIndex = 4;
            this.btn_ogrEkran_sonucGor.Text = "Sonuçları Görüntüle";
            this.btn_ogrEkran_sonucGor.UseVisualStyleBackColor = false;
            // 
            // Ogrenci_Giris_Ekrani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Khaki;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(921, 608);
            this.Controls.Add(this.btn_ogrEkran_sonucGor);
            this.Controls.Add(this.btn_ogrEkran_sinavaGir);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Ogrenci_Giris_Ekrani";
            this.Text = "Ogrenci_Giris_Ekrani";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_ogrEkran_sinavaGir;
        private System.Windows.Forms.Button btn_ogrEkran_sonucGor;
    }
}