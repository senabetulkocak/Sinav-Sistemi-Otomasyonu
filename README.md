# Sinav-Sistemi-Otomasyonu

SQL kodu içeren kod parçaları, veri tabanını tasarım ekranlarına bağlamak için yazılmış kodlardır. Örneğin bu kod Visual Studio'yu veri tabanına bağlamak için yazılmıştır:

    SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-56SRHAG;Initial Catalog=sınav_sistemi;Integrated Security=True");
    
    
 Örneğin; aşağıdaki kod parçacığında kullanıcının textbox'lara girdiği ifadeyi veri tabanındaki ilglini sütuna aktarıyoruz.
                    
                    baglan.Open();
                    string sql = "select * from tblSinavSorumlusu where sorumlu_kullanici_adi=@sadi AND sorumlu_sifre=@ssifre";
                    SqlParameter prm1 = new SqlParameter("sadi", txt_giris_kullaniciAd.Text.Trim());
                    SqlParameter prm2 = new SqlParameter("ssifre", txt_giris_sifre.Text.Trim());
                    SqlCommand komut = new SqlCommand(sql, baglan);
                    
 Bu ve bunun gibi kodlar zaten projemizde mevcuttur. 
 
 
 Bu program giriş ekranında kayıt kontrolü ya da giriş yapmanızı sağlayacak alanlar bulundurmaktadır. İlgili alanları doldurup kayıt olduğunuz zaman, bu bilgilerle giriş yapabilirsiniz. Veri tabanındaki ilgili tablolar bu bilgileri tutar. Giriş yaptığınız alana ait farklı işlemler bulunmaktadır. Bu işlemler sınav sorumlusu için soru ekle/çıkar, öğrenci için sınava girip sonuç görüntüleme ya da ayarları değiştirme imkanı sağlar. Admin için ise tüm veri tabanı tabloları görme yetkisi sağlar.
