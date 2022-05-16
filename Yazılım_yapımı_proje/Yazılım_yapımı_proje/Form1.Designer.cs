
namespace Yazılım_yapımı_proje
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.rdiobtn_girisYap = new System.Windows.Forms.RadioButton();
            this.rdiobtn_kayitOl = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.grpbx_kayitOl = new System.Windows.Forms.GroupBox();
            this.txt_kayitOl_soyad = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.rdiotbn_kayitOl_ogrenci = new System.Windows.Forms.RadioButton();
            this.rdiobtn_kayitOl_sinavSorum = new System.Windows.Forms.RadioButton();
            this.btn_kayitOl = new System.Windows.Forms.Button();
            this.txt_kayitOl_sifre = new System.Windows.Forms.TextBox();
            this.txt_kayitOl_ad = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.grpbx_girisYap = new System.Windows.Forms.GroupBox();
            this.rdiobtn_adminGirisi = new System.Windows.Forms.RadioButton();
            this.linklbl_sifremiUnuttum = new System.Windows.Forms.LinkLabel();
            this.rdiobtn_girisYap_ogrenci = new System.Windows.Forms.RadioButton();
            this.rdiobtn_girisYap_sinavSor = new System.Windows.Forms.RadioButton();
            this.btn_girisYap = new System.Windows.Forms.Button();
            this.txt_giris_sifre = new System.Windows.Forms.TextBox();
            this.txt_giris_kullaniciAd = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_KayitOl_kullanici = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.grpbx_kayitOl.SuspendLayout();
            this.grpbx_girisYap.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(170, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(375, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "SINAV SİSTEMİNE HOŞGELDİNİZ!";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.2F, System.Drawing.FontStyle.Italic);
            this.label2.Location = new System.Drawing.Point(188, 100);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(320, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Lütfen yapmak istediğiniz işlemi seçiniz..";
            // 
            // rdiobtn_girisYap
            // 
            this.rdiobtn_girisYap.AutoSize = true;
            this.rdiobtn_girisYap.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rdiobtn_girisYap.Location = new System.Drawing.Point(109, 37);
            this.rdiobtn_girisYap.Margin = new System.Windows.Forms.Padding(2);
            this.rdiobtn_girisYap.Name = "rdiobtn_girisYap";
            this.rdiobtn_girisYap.Size = new System.Drawing.Size(81, 21);
            this.rdiobtn_girisYap.TabIndex = 2;
            this.rdiobtn_girisYap.TabStop = true;
            this.rdiobtn_girisYap.Text = "Giriş Yap";
            this.rdiobtn_girisYap.UseVisualStyleBackColor = true;
            this.rdiobtn_girisYap.CheckedChanged += new System.EventHandler(this.rdiobtn_girisYap_CheckedChanged);
            // 
            // rdiobtn_kayitOl
            // 
            this.rdiobtn_kayitOl.AutoSize = true;
            this.rdiobtn_kayitOl.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rdiobtn_kayitOl.Location = new System.Drawing.Point(407, 37);
            this.rdiobtn_kayitOl.Margin = new System.Windows.Forms.Padding(2);
            this.rdiobtn_kayitOl.Name = "rdiobtn_kayitOl";
            this.rdiobtn_kayitOl.Size = new System.Drawing.Size(78, 21);
            this.rdiobtn_kayitOl.TabIndex = 3;
            this.rdiobtn_kayitOl.TabStop = true;
            this.rdiobtn_kayitOl.Text = "Kayıt Ol";
            this.rdiobtn_kayitOl.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.grpbx_kayitOl);
            this.groupBox1.Controls.Add(this.grpbx_girisYap);
            this.groupBox1.Controls.Add(this.rdiobtn_girisYap);
            this.groupBox1.Controls.Add(this.rdiobtn_kayitOl);
            this.groupBox1.Location = new System.Drawing.Point(46, 164);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(608, 372);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // grpbx_kayitOl
            // 
            this.grpbx_kayitOl.BackColor = System.Drawing.Color.LightYellow;
            this.grpbx_kayitOl.Controls.Add(this.txt_KayitOl_kullanici);
            this.grpbx_kayitOl.Controls.Add(this.label8);
            this.grpbx_kayitOl.Controls.Add(this.txt_kayitOl_soyad);
            this.grpbx_kayitOl.Controls.Add(this.label7);
            this.grpbx_kayitOl.Controls.Add(this.rdiotbn_kayitOl_ogrenci);
            this.grpbx_kayitOl.Controls.Add(this.rdiobtn_kayitOl_sinavSorum);
            this.grpbx_kayitOl.Controls.Add(this.btn_kayitOl);
            this.grpbx_kayitOl.Controls.Add(this.txt_kayitOl_sifre);
            this.grpbx_kayitOl.Controls.Add(this.txt_kayitOl_ad);
            this.grpbx_kayitOl.Controls.Add(this.label5);
            this.grpbx_kayitOl.Controls.Add(this.label6);
            this.grpbx_kayitOl.Location = new System.Drawing.Point(322, 75);
            this.grpbx_kayitOl.Margin = new System.Windows.Forms.Padding(2);
            this.grpbx_kayitOl.Name = "grpbx_kayitOl";
            this.grpbx_kayitOl.Padding = new System.Windows.Forms.Padding(2);
            this.grpbx_kayitOl.Size = new System.Drawing.Size(250, 271);
            this.grpbx_kayitOl.TabIndex = 5;
            this.grpbx_kayitOl.TabStop = false;
            // 
            // txt_kayitOl_soyad
            // 
            this.txt_kayitOl_soyad.Location = new System.Drawing.Point(103, 123);
            this.txt_kayitOl_soyad.Margin = new System.Windows.Forms.Padding(2);
            this.txt_kayitOl_soyad.Name = "txt_kayitOl_soyad";
            this.txt_kayitOl_soyad.Size = new System.Drawing.Size(117, 20);
            this.txt_kayitOl_soyad.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.LightSteelBlue;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(50, 125);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 16);
            this.label7.TabIndex = 12;
            this.label7.Text = "Soyadı:";
            // 
            // rdiotbn_kayitOl_ogrenci
            // 
            this.rdiotbn_kayitOl_ogrenci.AutoSize = true;
            this.rdiotbn_kayitOl_ogrenci.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rdiotbn_kayitOl_ogrenci.Location = new System.Drawing.Point(164, 36);
            this.rdiotbn_kayitOl_ogrenci.Margin = new System.Windows.Forms.Padding(2);
            this.rdiotbn_kayitOl_ogrenci.Name = "rdiotbn_kayitOl_ogrenci";
            this.rdiotbn_kayitOl_ogrenci.Size = new System.Drawing.Size(75, 21);
            this.rdiotbn_kayitOl_ogrenci.TabIndex = 11;
            this.rdiotbn_kayitOl_ogrenci.TabStop = true;
            this.rdiotbn_kayitOl_ogrenci.Text = "Öğrenci";
            this.rdiotbn_kayitOl_ogrenci.UseVisualStyleBackColor = true;
            // 
            // rdiobtn_kayitOl_sinavSorum
            // 
            this.rdiobtn_kayitOl_sinavSorum.AutoSize = true;
            this.rdiobtn_kayitOl_sinavSorum.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rdiobtn_kayitOl_sinavSorum.Location = new System.Drawing.Point(12, 36);
            this.rdiobtn_kayitOl_sinavSorum.Margin = new System.Windows.Forms.Padding(2);
            this.rdiobtn_kayitOl_sinavSorum.Name = "rdiobtn_kayitOl_sinavSorum";
            this.rdiobtn_kayitOl_sinavSorum.Size = new System.Drawing.Size(131, 21);
            this.rdiobtn_kayitOl_sinavSorum.TabIndex = 10;
            this.rdiobtn_kayitOl_sinavSorum.TabStop = true;
            this.rdiobtn_kayitOl_sinavSorum.Text = "Sınav Sorumlusu";
            this.rdiobtn_kayitOl_sinavSorum.UseVisualStyleBackColor = true;
            // 
            // btn_kayitOl
            // 
            this.btn_kayitOl.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_kayitOl.Location = new System.Drawing.Point(82, 235);
            this.btn_kayitOl.Margin = new System.Windows.Forms.Padding(2);
            this.btn_kayitOl.Name = "btn_kayitOl";
            this.btn_kayitOl.Size = new System.Drawing.Size(95, 32);
            this.btn_kayitOl.TabIndex = 9;
            this.btn_kayitOl.Text = "Kayıt Ol";
            this.btn_kayitOl.UseVisualStyleBackColor = true;
            this.btn_kayitOl.Click += new System.EventHandler(this.btn_kayitOl_Click);
            // 
            // txt_kayitOl_sifre
            // 
            this.txt_kayitOl_sifre.Location = new System.Drawing.Point(103, 190);
            this.txt_kayitOl_sifre.Margin = new System.Windows.Forms.Padding(2);
            this.txt_kayitOl_sifre.Name = "txt_kayitOl_sifre";
            this.txt_kayitOl_sifre.Size = new System.Drawing.Size(117, 20);
            this.txt_kayitOl_sifre.TabIndex = 8;
            this.txt_kayitOl_sifre.UseSystemPasswordChar = true;
            // 
            // txt_kayitOl_ad
            // 
            this.txt_kayitOl_ad.Location = new System.Drawing.Point(103, 87);
            this.txt_kayitOl_ad.Margin = new System.Windows.Forms.Padding(2);
            this.txt_kayitOl_ad.Name = "txt_kayitOl_ad";
            this.txt_kayitOl_ad.Size = new System.Drawing.Size(117, 20);
            this.txt_kayitOl_ad.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.LightSteelBlue;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(61, 192);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 16);
            this.label5.TabIndex = 6;
            this.label5.Text = "Şifre:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.LightSteelBlue;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(69, 89);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Adı:";
            // 
            // grpbx_girisYap
            // 
            this.grpbx_girisYap.BackColor = System.Drawing.Color.LightYellow;
            this.grpbx_girisYap.Controls.Add(this.rdiobtn_adminGirisi);
            this.grpbx_girisYap.Controls.Add(this.linklbl_sifremiUnuttum);
            this.grpbx_girisYap.Controls.Add(this.rdiobtn_girisYap_ogrenci);
            this.grpbx_girisYap.Controls.Add(this.rdiobtn_girisYap_sinavSor);
            this.grpbx_girisYap.Controls.Add(this.btn_girisYap);
            this.grpbx_girisYap.Controls.Add(this.txt_giris_sifre);
            this.grpbx_girisYap.Controls.Add(this.txt_giris_kullaniciAd);
            this.grpbx_girisYap.Controls.Add(this.label4);
            this.grpbx_girisYap.Controls.Add(this.label3);
            this.grpbx_girisYap.Location = new System.Drawing.Point(34, 75);
            this.grpbx_girisYap.Margin = new System.Windows.Forms.Padding(2);
            this.grpbx_girisYap.Name = "grpbx_girisYap";
            this.grpbx_girisYap.Padding = new System.Windows.Forms.Padding(2);
            this.grpbx_girisYap.Size = new System.Drawing.Size(256, 271);
            this.grpbx_girisYap.TabIndex = 4;
            this.grpbx_girisYap.TabStop = false;
            // 
            // rdiobtn_adminGirisi
            // 
            this.rdiobtn_adminGirisi.AutoSize = true;
            this.rdiobtn_adminGirisi.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rdiobtn_adminGirisi.Location = new System.Drawing.Point(74, 70);
            this.rdiobtn_adminGirisi.Margin = new System.Windows.Forms.Padding(2);
            this.rdiobtn_adminGirisi.Name = "rdiobtn_adminGirisi";
            this.rdiobtn_adminGirisi.Size = new System.Drawing.Size(105, 21);
            this.rdiobtn_adminGirisi.TabIndex = 15;
            this.rdiobtn_adminGirisi.TabStop = true;
            this.rdiobtn_adminGirisi.Text = "Admin Girişi";
            this.rdiobtn_adminGirisi.UseVisualStyleBackColor = true;
            // 
            // linklbl_sifremiUnuttum
            // 
            this.linklbl_sifremiUnuttum.AutoSize = true;
            this.linklbl_sifremiUnuttum.Font = new System.Drawing.Font("Times New Roman", 10.2F);
            this.linklbl_sifremiUnuttum.Location = new System.Drawing.Point(101, 178);
            this.linklbl_sifremiUnuttum.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.linklbl_sifremiUnuttum.Name = "linklbl_sifremiUnuttum";
            this.linklbl_sifremiUnuttum.Size = new System.Drawing.Size(100, 16);
            this.linklbl_sifremiUnuttum.TabIndex = 14;
            this.linklbl_sifremiUnuttum.TabStop = true;
            this.linklbl_sifremiUnuttum.Text = "Şifremi unuttum";
            this.linklbl_sifremiUnuttum.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linklbl_sifremiUnuttum_LinkClicked);
            // 
            // rdiobtn_girisYap_ogrenci
            // 
            this.rdiobtn_girisYap_ogrenci.AutoSize = true;
            this.rdiobtn_girisYap_ogrenci.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rdiobtn_girisYap_ogrenci.Location = new System.Drawing.Point(160, 32);
            this.rdiobtn_girisYap_ogrenci.Margin = new System.Windows.Forms.Padding(2);
            this.rdiobtn_girisYap_ogrenci.Name = "rdiobtn_girisYap_ogrenci";
            this.rdiobtn_girisYap_ogrenci.Size = new System.Drawing.Size(75, 21);
            this.rdiobtn_girisYap_ogrenci.TabIndex = 13;
            this.rdiobtn_girisYap_ogrenci.TabStop = true;
            this.rdiobtn_girisYap_ogrenci.Text = "Öğrenci";
            this.rdiobtn_girisYap_ogrenci.UseVisualStyleBackColor = true;
            // 
            // rdiobtn_girisYap_sinavSor
            // 
            this.rdiobtn_girisYap_sinavSor.AutoSize = true;
            this.rdiobtn_girisYap_sinavSor.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rdiobtn_girisYap_sinavSor.Location = new System.Drawing.Point(8, 32);
            this.rdiobtn_girisYap_sinavSor.Margin = new System.Windows.Forms.Padding(2);
            this.rdiobtn_girisYap_sinavSor.Name = "rdiobtn_girisYap_sinavSor";
            this.rdiobtn_girisYap_sinavSor.Size = new System.Drawing.Size(131, 21);
            this.rdiobtn_girisYap_sinavSor.TabIndex = 12;
            this.rdiobtn_girisYap_sinavSor.TabStop = true;
            this.rdiobtn_girisYap_sinavSor.Text = "Sınav Sorumlusu";
            this.rdiobtn_girisYap_sinavSor.UseVisualStyleBackColor = true;
            // 
            // btn_girisYap
            // 
            this.btn_girisYap.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_girisYap.Location = new System.Drawing.Point(75, 235);
            this.btn_girisYap.Margin = new System.Windows.Forms.Padding(2);
            this.btn_girisYap.Name = "btn_girisYap";
            this.btn_girisYap.Size = new System.Drawing.Size(95, 32);
            this.btn_girisYap.TabIndex = 4;
            this.btn_girisYap.Text = "Giriş Yap";
            this.btn_girisYap.UseVisualStyleBackColor = true;
            this.btn_girisYap.Click += new System.EventHandler(this.btn_girisYap_Click);
            // 
            // txt_giris_sifre
            // 
            this.txt_giris_sifre.Location = new System.Drawing.Point(104, 150);
            this.txt_giris_sifre.Margin = new System.Windows.Forms.Padding(2);
            this.txt_giris_sifre.Name = "txt_giris_sifre";
            this.txt_giris_sifre.Size = new System.Drawing.Size(117, 20);
            this.txt_giris_sifre.TabIndex = 3;
            this.txt_giris_sifre.UseSystemPasswordChar = true;
            // 
            // txt_giris_kullaniciAd
            // 
            this.txt_giris_kullaniciAd.Location = new System.Drawing.Point(104, 104);
            this.txt_giris_kullaniciAd.Margin = new System.Windows.Forms.Padding(2);
            this.txt_giris_kullaniciAd.Name = "txt_giris_kullaniciAd";
            this.txt_giris_kullaniciAd.Size = new System.Drawing.Size(117, 20);
            this.txt_giris_kullaniciAd.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.LightSteelBlue;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(52, 150);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 16);
            this.label4.TabIndex = 1;
            this.label4.Text = "Şifre:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.LightSteelBlue;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(10, 104);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Kullanıcı Adı:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.LightSteelBlue;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(18, 158);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(81, 16);
            this.label8.TabIndex = 14;
            this.label8.Text = "Kullanıcı Adı:";
            // 
            // txt_KayitOl_kullanici
            // 
            this.txt_KayitOl_kullanici.Location = new System.Drawing.Point(103, 157);
            this.txt_KayitOl_kullanici.Name = "txt_KayitOl_kullanici";
            this.txt_KayitOl_kullanici.Size = new System.Drawing.Size(117, 20);
            this.txt_KayitOl_kullanici.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Beige;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(704, 574);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sınav Sistemi";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grpbx_kayitOl.ResumeLayout(false);
            this.grpbx_kayitOl.PerformLayout();
            this.grpbx_girisYap.ResumeLayout(false);
            this.grpbx_girisYap.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rdiobtn_girisYap;
        private System.Windows.Forms.RadioButton rdiobtn_kayitOl;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox grpbx_kayitOl;
        private System.Windows.Forms.TextBox txt_kayitOl_soyad;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RadioButton rdiotbn_kayitOl_ogrenci;
        private System.Windows.Forms.RadioButton rdiobtn_kayitOl_sinavSorum;
        private System.Windows.Forms.Button btn_kayitOl;
        private System.Windows.Forms.TextBox txt_kayitOl_sifre;
        private System.Windows.Forms.TextBox txt_kayitOl_ad;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox grpbx_girisYap;
        private System.Windows.Forms.Button btn_girisYap;
        private System.Windows.Forms.TextBox txt_giris_sifre;
        private System.Windows.Forms.TextBox txt_giris_kullaniciAd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rdiobtn_girisYap_ogrenci;
        private System.Windows.Forms.RadioButton rdiobtn_girisYap_sinavSor;
        private System.Windows.Forms.LinkLabel linklbl_sifremiUnuttum;
        private System.Windows.Forms.RadioButton rdiobtn_adminGirisi;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_KayitOl_kullanici;
    }
}

