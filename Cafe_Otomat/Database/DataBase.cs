using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

public class DataBase
{
    public static string kullanici = "";
    //static string conString = "Server=192.168.1.2;Database=saray;User Id=SARAY;Password=qwertyuıopğü123;";
    static string conString = "Server=192.168.1.164;Database=saray;User Id=SARAY;Password=qwertyuıopğü123;";
    //Bu veritabanına bağlanmak için gerekli olan bağlantı cümlemiz.Bu satıra dikkat edelim.
    //Sql Servera bağlanırken kullandığımız bilgileri ve veritabanı ismini yazıyoruz.
    public SqlConnection baglanti = new SqlConnection(conString);
    public SqlConnection baglanti1 = new SqlConnection(conString); //Timer Tick için.
    public DataBase() { }
    public void Kullanici_Ekle_Database(string kAdi, string sifre, string adi, string adres, string telNo)
    {
        //bağlantı cümlemizi kullanarak bir SqlConnection bağlantısı oluşt
        try
        {
            if (baglanti.State == ConnectionState.Closed)
                baglanti.Open();
            // Bağlantımızı kontrol ediyoruz, eğer kapalıysa açıyoruz.
            string kayit = "insert into USER_TBL(USER_NAME,PASSWORD,NAME,ADRESS,PHONE) values (@kAdi,@sifre,@ad,@adres,@telNo)";
            // kullanıcı tablomuzun ilgili alanlarına kayıt ekleme işlemini gerçekleştirecek sorgumuz.
            SqlCommand komut = new SqlCommand(kayit, baglanti);
            //Sorgumuzu ve baglantimizi parametre olarak alan bir SqlCommand nesnesi oluşturuyoruz.
            komut.Parameters.AddWithValue("@kAdi", kAdi);
            komut.Parameters.AddWithValue("@sifre", sifre);
            komut.Parameters.AddWithValue("@ad", adi);
            komut.Parameters.AddWithValue("@adres", adres);
            komut.Parameters.AddWithValue("@telNo", telNo);
            //Parametrelerimize Form üzerinde ki kontrollerden girilen verileri aktarıyoruz.
            komut.ExecuteNonQuery();
            //Veritabanında değişiklik yapacak komut işlemi bu satırda gerçekleşiyor.
            baglanti.Close();
        }
        catch (Exception hata)
        {
            MessageBox.Show(hata.Message, "hata");
        }
    }
    public void Urun_Ekle_Database(string barcode, string urunAdi, string kategori,
        string birim, double stok, double satisFiyati, double alisFiyati,
        double indirim, bool indirimKontrol, string aciklama, string tedarikci,
        DateTime kayitTarihi, DateTime indirimBaslangic,
        DateTime indirimBitis, string resim)
    {
        try
        {
            if (baglanti.State == ConnectionState.Closed)
                baglanti.Open();
            string kayit = "insert into PRODUCT_TBL(BARCODE," +
                "PRODUCT_NAME,CATEGORY,UNIT,STOCK,SALE_PRICE," +
                "PURCHASE_PRICE,DISCOUNT,DISCOUNT_CONTROL,DESCRIPTION," +
                "SUPPLIER,SAVED_DATE,DISCOUNT_START,DISCOUNT_FINISH,IMAGE) " +
                "values (@barcode,@urunAdi,@kategori,@birim,@stok," +
                "@satisFiyati,@alisFiyati,@indirim,@indirimKontrol," +
                "@aciklama,@tedarikci,@kayitTarihi,@indirimBaslangic," +
                "@indirimBitis,@resim)";
            SqlCommand komut = new SqlCommand(kayit, baglanti);
            komut.Parameters.AddWithValue("@barcode", barcode);
            komut.Parameters.AddWithValue("@urunAdi", urunAdi);
            komut.Parameters.AddWithValue("@kategori", kategori);
            komut.Parameters.AddWithValue("@birim", birim);
            komut.Parameters.AddWithValue("@stok", stok);
            komut.Parameters.AddWithValue("@satisFiyati", satisFiyati);
            komut.Parameters.AddWithValue("@alisFiyati", alisFiyati);
            komut.Parameters.AddWithValue("@indirim", indirim);
            komut.Parameters.AddWithValue("@indirimKontrol", indirimKontrol);
            komut.Parameters.AddWithValue("@aciklama", aciklama);
            komut.Parameters.AddWithValue("@tedarikci", tedarikci);
            komut.Parameters.AddWithValue("@kayitTarihi", kayitTarihi);
            komut.Parameters.AddWithValue("@indirimBaslangic", indirimBaslangic);
            komut.Parameters.AddWithValue("@indirimBitis", indirimBitis);
            komut.Parameters.AddWithValue("@resim", resim);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }
        catch (Exception hata)
        {
            MessageBox.Show(hata.Message, "hata");
        }
    }
    public void Musteri_Ekle_Database(string adi, int musteriKodu, 
        string telNo, string adres, DateTime kayitTarihi, 
        DateTime guncelleme, double bakiye)
    {

        //bağlantı cümlemizi kullanarak bir SqlConnection bağlantısı oluşt
        try
        {
            if (baglanti.State == ConnectionState.Closed)
                baglanti.Open();
            // Bağlantımızı kontrol ediyoruz, eğer kapalıysa açıyoruz.
            string kayit = "insert into CUSTOMER_TBL(CUSTOMER_NAME,CUSTOMER_CODE,CUSTOMER_PHONE,CUSTOMER_ADRESS,SAVED_TIME,UPDATEE,REMAINDER) values (@adi,@musteriKodu,@telNo,@adres,@kayitTarihi,@guncelleme,@bakiye)";
            // müşteriler tablomuzun ilgili alanlarına kayıt ekleme işlemini gerçekleştirecek sorgumuz.
            SqlCommand komut = new SqlCommand(kayit, baglanti);
            //Sorgumuzu ve baglantimizi parametre olarak alan bir SqlCommand nesnesi oluşturuyoruz.
            komut.Parameters.AddWithValue("@adi", adi);
            komut.Parameters.AddWithValue("@musteriKodu", musteriKodu);
            komut.Parameters.AddWithValue("@telNo", telNo);
            komut.Parameters.AddWithValue("@adres", adres);
            komut.Parameters.AddWithValue("@kayitTarihi", kayitTarihi);
            komut.Parameters.AddWithValue("@guncelleme", guncelleme);
            komut.Parameters.AddWithValue("@bakiye", bakiye);
            //Parametrelerimize Form üzerinde ki kontrollerden girilen verileri aktarıyoruz.
            komut.ExecuteNonQuery();
            //Veritabanında değişiklik yapacak komut işlemi bu satırda gerçekleşiyor.
            baglanti.Close();
        }
        catch (Exception hata)
        {
            MessageBox.Show(hata.Message, "hata");
        }
    }
    public void Kategori_Ekle_Database(string adi)
    {
        try
        {
            if (baglanti.State == ConnectionState.Closed)
                baglanti.Open();
            // Bağlantımızı kontrol ediyoruz, eğer kapalıysa açıyoruz.
            string kayit = "insert into CATEGORY_TBL(CATEGORY_NAME) values (@adi)";
            // müşteriler tablomuzun ilgili alanlarına kayıt ekleme işlemini gerçekleştirecek sorgumuz.
            SqlCommand komut = new SqlCommand(kayit, baglanti);
            //Sorgumuzu ve baglantimizi parametre olarak alan bir SqlCommand nesnesi oluşturuyoruz.
            komut.Parameters.AddWithValue("@adi", adi);
            //Parametrelerimize Form üzerinde ki kontrollerden girilen verileri aktarıyoruz.
            komut.ExecuteNonQuery();
            //Veritabanında değişiklik yapacak komut işlemi bu satırda gerçekleşiyor.
            baglanti.Close();
        }
        catch (Exception hata)
        {
            MessageBox.Show(hata.Message, "hata");
        }
    }
    public void Yemek_Ekle_Database(string adi, int kategori, string tip,
        double fiyat, bool kontrol)
    {
        try
        {
            if (baglanti.State == ConnectionState.Closed)
                baglanti.Open();
            // Bağlantımızı kontrol ediyoruz, eğer kapalıysa açıyoruz.
            string kayit = "insert into FOOD_TBL(FOOD_NAME,CATEGORY,FOOD_TYPE,FOOD_PRICE,CONTROL) values (@adi,@kategori,@tip,@fiyat,@kontrol)";
            // müşteriler tablomuzun ilgili alanlarına kayıt ekleme işlemini gerçekleştirecek sorgumuz.
            SqlCommand komut = new SqlCommand(kayit, baglanti);
            //Sorgumuzu ve baglantimizi parametre olarak alan bir SqlCommand nesnesi oluşturuyoruz.
            komut.Parameters.AddWithValue("@adi", adi);
            komut.Parameters.AddWithValue("@kategori", kategori);
            komut.Parameters.AddWithValue("@tip", tip);
            komut.Parameters.AddWithValue("@fiyat", fiyat);
            komut.Parameters.AddWithValue("@kontrol", kontrol);
            //Parametrelerimize Form üzerinde ki kontrollerden girilen verileri aktarıyoruz.
            komut.ExecuteNonQuery();
            //Veritabanında değişiklik yapacak komut işlemi bu satırda gerçekleşiyor.
            baglanti.Close();
        }
        catch (Exception hata)
        {
            MessageBox.Show(hata.Message, "hata");
        }
    }
    public void Satis_Ekle_Database(string islemNo, string barkod,
        string urun, DateTime satisTarihi, double miktar, double toplamFiyat, 
        string kategori, string personel, string tableName, double alisFiyat,
        double satisFiyat)
    {
        try
        {
            if (baglanti.State == ConnectionState.Closed)
                baglanti.Open();
            // Bağlantımızı kontrol ediyoruz, eğer kapalıysa açıyoruz.
            string kayit = "insert into SELL_TBL(OPERATION_NO,BARCODE,PRODUCT_NAME,SELL_DATE,AMOUNT,TOTAL_PRICE,CATEGORY,EMPLOYEE,TABLE_NAME,PRICE,PURCHASE_PRICE) values (@islemNo,@barkod,@urun,@satisTarihi,@miktar,@toplamFiyat,@kategori,@personel,@tableName,@sFiyat,@aFiyat)";
            // müşteriler tablomuzun ilgili alanlarına kayıt ekleme işlemini gerçekleştirecek sorgumuz.
            SqlCommand komut = new SqlCommand(kayit, baglanti);
            //Sorgumuzu ve baglantimizi parametre olarak alan bir SqlCommand nesnesi oluşturuyoruz.
            komut.Parameters.AddWithValue("@islemNo", islemNo);
            komut.Parameters.AddWithValue("@barkod", barkod);
            komut.Parameters.AddWithValue("@urun", urun);
            komut.Parameters.AddWithValue("@satisTarihi", satisTarihi);
            komut.Parameters.AddWithValue("@miktar", miktar);
            komut.Parameters.AddWithValue("@toplamFiyat", toplamFiyat);
            komut.Parameters.AddWithValue("@kategori", kategori);
            komut.Parameters.AddWithValue("@personel", personel);
            komut.Parameters.AddWithValue("@tableName", tableName);
            komut.Parameters.AddWithValue("@aFiyat", alisFiyat);
            komut.Parameters.AddWithValue("@sFiyat", satisFiyat);
            //Parametrelerimize Form üzerinde ki kontrollerden girilen verileri aktarıyoruz.
            komut.ExecuteNonQuery();
            //Veritabanında değişiklik yapacak komut işlemi bu satırda gerçekleşiyor.
            baglanti.Close();
        }
        catch (Exception hata)
        {
            MessageBox.Show(hata.Message, "hata");
        }
    }
    public void Tedarikci_Ekle_Database(string adi)
    {
        try
        {
            if (baglanti.State == ConnectionState.Closed)
                baglanti.Open();
            // Bağlantımızı kontrol ediyoruz, eğer kapalıysa açıyoruz.
            string kayit = "insert into SUPPLIER_TBL(SUPPLIER_NAME) values (@adi)";
            // müşteriler tablomuzun ilgili alanlarına kayıt ekleme işlemini gerçekleştirecek sorgumuz.
            SqlCommand komut = new SqlCommand(kayit, baglanti);
            //Sorgumuzu ve baglantimizi parametre olarak alan bir SqlCommand nesnesi oluşturuyoruz.
            komut.Parameters.AddWithValue("@adi", adi);
            //Parametrelerimize Form üzerinde ki kontrollerden girilen verileri aktarıyoruz.
            komut.ExecuteNonQuery();
            //Veritabanında değişiklik yapacak komut işlemi bu satırda gerçekleşiyor.
            baglanti.Close();
        }
        catch (Exception hata)
        {
            MessageBox.Show(hata.Message, "hata");
        }
    }
    public void Birim_Ekle_Database(string adi)
    {
        try
        {
            if (baglanti.State == ConnectionState.Closed)
                baglanti.Open();
            // Bağlantımızı kontrol ediyoruz, eğer kapalıysa açıyoruz.
            string kayit = "insert into UNIT_TBL(UNIT_NAME) values (@adi)";
            // müşteriler tablomuzun ilgili alanlarına kayıt ekleme işlemini gerçekleştirecek sorgumuz.
            SqlCommand komut = new SqlCommand(kayit, baglanti);
            //Sorgumuzu ve baglantimizi parametre olarak alan bir SqlCommand nesnesi oluşturuyoruz.
            komut.Parameters.AddWithValue("@adi", adi);
            //Parametrelerimize Form üzerinde ki kontrollerden girilen verileri aktarıyoruz.
            komut.ExecuteNonQuery();
            //Veritabanında değişiklik yapacak komut işlemi bu satırda gerçekleşiyor.
            baglanti.Close();
        }
        catch (Exception hata)
        {
            MessageBox.Show(hata.Message, "hata");
        }
    }
    public void Sistem_Ekle_Database(bool yedek, string yedekYolu,
        int yazici, int post, int etiket, string sirketAdi, string sirketTel,
        string sirketAdres, string serialKey)
    {
        try
        {
            if (baglanti.State == ConnectionState.Closed)
                baglanti.Open();
            // Bağlantımızı kontrol ediyoruz, eğer kapalıysa açıyoruz.
            string kayit = "insert into SYSTEM_TBL(BACKUPP,BACKUP_PATH,PRINTER,POST,LABEL,COMPANY_NAME,COMPANY_PHONE,COMPANY_ADRESS,SERIAL_KEY) values (@yedek,@yedekYolu,@yazici,@post,@etiket,@sirketAdi,@sirketTel,@sirketAdres,@serialKey)";
            // müşteriler tablomuzun ilgili alanlarına kayıt ekleme işlemini gerçekleştirecek sorgumuz.
            SqlCommand komut = new SqlCommand(kayit, baglanti);
            //Sorgumuzu ve baglantimizi parametre olarak alan bir SqlCommand nesnesi oluşturuyoruz.
            komut.Parameters.AddWithValue("@yedek", yedek);
            komut.Parameters.AddWithValue("@yedekYolu", yedekYolu);
            komut.Parameters.AddWithValue("@yazici", yazici);
            komut.Parameters.AddWithValue("@post", post);
            komut.Parameters.AddWithValue("@etiket", etiket);
            komut.Parameters.AddWithValue("@sirketAdi", sirketAdi);
            komut.Parameters.AddWithValue("@sirketTel", sirketTel);
            komut.Parameters.AddWithValue("@sirketAdres", sirketAdres);
            komut.Parameters.AddWithValue("@serialKey", serialKey);
            //Parametrelerimize Form üzerinde ki kontrollerden girilen verileri aktarıyoruz.
            komut.ExecuteNonQuery();
            //Veritabanında değişiklik yapacak komut işlemi bu satırda gerçekleşiyor.
            baglanti.Close();
        }
        catch (Exception hata)
        {
            MessageBox.Show(hata.Message, "hata");
        }
    }
    public void Kasa_Ekle_Database(string adi, string personel, DateTime islemTarihi, string islemNo,
        string aciklama, string odemeTuru, string islemTuru, double girenPara, double cikanPara)
    {
        try
        {
            if (baglanti.State == ConnectionState.Closed)
                baglanti.Open();
            // Bağlantımızı kontrol ediyoruz, eğer kapalıysa açıyoruz.
            string kayit = "insert into SAFE_TBL(SAFE_NAME,EMPLOYEE,OPERATION_DATE,OPERATION_NO,DESCRIPTION,PAY_TYPE,OPERATION_TYPE,ENTER_PRICE,EXIT_PRICE) values (@adi,@personel,@islemTarihi,@islemNo,@aciklama,@odemeTuru,@islemTuru,@girenPara,@cikanPara)";
            // müşteriler tablomuzun ilgili alanlarına kayıt ekleme işlemini gerçekleştirecek sorgumuz.
            SqlCommand komut = new SqlCommand(kayit, baglanti);
            //Sorgumuzu ve baglantimizi parametre olarak alan bir SqlCommand nesnesi oluşturuyoruz.
            komut.Parameters.AddWithValue("@adi", adi);
            komut.Parameters.AddWithValue("@personel", personel);
            komut.Parameters.AddWithValue("@islemTarihi", islemTarihi);
            komut.Parameters.AddWithValue("@islemNo", islemNo);
            komut.Parameters.AddWithValue("@aciklama", aciklama);
            komut.Parameters.AddWithValue("@odemeTuru", odemeTuru);
            komut.Parameters.AddWithValue("@islemTuru", islemTuru);
            komut.Parameters.AddWithValue("@girenPara", girenPara);
            komut.Parameters.AddWithValue("@cikanPara", cikanPara);
            //Parametrelerimize Form üzerinde ki kontrollerden girilen verileri aktarıyoruz.
            komut.ExecuteNonQuery();
            //Veritabanında değişiklik yapacak komut işlemi bu satırda gerçekleşiyor.
            baglanti.Close();
        }
        catch (Exception hata)
        {
            MessageBox.Show(hata.Message, "hata");
        }
    }
    public void Kampanya_Ekle_Database(string adi)
    {
        try
        {
            if (baglanti.State == ConnectionState.Closed)
                baglanti.Open();
            // Bağlantımızı kontrol ediyoruz, eğer kapalıysa açıyoruz.
            string kayit = "insert into CAMPAIGN_TBL(CAMPAIGN_NAME) values (@adi)";
            // müşteriler tablomuzun ilgili alanlarına kayıt ekleme işlemini gerçekleştirecek sorgumuz.
            SqlCommand komut = new SqlCommand(kayit, baglanti);
            //Sorgumuzu ve baglantimizi parametre olarak alan bir SqlCommand nesnesi oluşturuyoruz.
            komut.Parameters.AddWithValue("@adi", adi);
            //Parametrelerimize Form üzerinde ki kontrollerden girilen verileri aktarıyoruz.
            komut.ExecuteNonQuery();
            //Veritabanında değişiklik yapacak komut işlemi bu satırda gerçekleşiyor.
            baglanti.Close();
        }
        catch (Exception hata)
        {
            MessageBox.Show(hata.Message, "hata");
        }
    }

    /////////////////////////////////////////////////////////////////////////////////////////////////////////////

    public void Kullanici_Guncelle_Database(string kAdi, string sifre, string adi,
        string adres, string telNo, int kullaniciID)
    {

        //bağlantı cümlemizi kullanarak bir SqlConnection bağlantısı oluşt
        try
        {
            if (baglanti.State == ConnectionState.Closed)
                baglanti.Open();
            // Bağlantımızı kontrol ediyoruz, eğer kapalıysa açıyoruz.
            string kayit = "update USER_TBL set USER_NAME=@kAdi,PASSWORD=@sifre,NAME=@ad,ADRESS=@adres,PHONE=@telNo where USER_ID=@kullaniciID)";
            // müşteriler tablomuzun ilgili alanlarına kayıt ekleme işlemini gerçekleştirecek sorgumuz.
            SqlCommand komut = new SqlCommand(kayit, baglanti);
            //Sorgumuzu ve baglantimizi parametre olarak alan bir SqlCommand nesnesi oluşturuyoruz.
            komut.Parameters.AddWithValue("@kAdi", kAdi);
            komut.Parameters.AddWithValue("@sifre", sifre);
            komut.Parameters.AddWithValue("@ad", adi);
            komut.Parameters.AddWithValue("@adres", adres);
            komut.Parameters.AddWithValue("@telNo", telNo);
            komut.Parameters.AddWithValue("@kullaniciID", kullaniciID);
            //Parametrelerimize Form üzerinde ki kontrollerden girilen verileri aktarıyoruz.
            komut.ExecuteNonQuery();
            //Veritabanında değişiklik yapacak komut işlemi bu satırda gerçekleşiyor.
            baglanti.Close();
        }
        catch (Exception hata)
        {
            MessageBox.Show(hata.Message, "hata");
        }
    }

    internal void Siparis_Guncelle_Database(object ıd, string v1, bool v2)
    {
        throw new NotImplementedException();
    }

    public void Urun_Guncelle_Database(string barcode, string urunAdi, string kategori, string birim,
        double stok, double satisFiyati, double alisFiyati, double indirim,
        bool indirimKontrol, string aciklama, string tedarikci, 
        DateTime indirimBaslangic, DateTime indirimBitis, string resim, int urunID)
    {

        //bağlantı cümlemizi kullanarak bir SqlConnection bağlantısı oluşt
        try
        {
            if (baglanti.State == ConnectionState.Closed)
                baglanti.Open();
            // Bağlantımızı kontrol ediyoruz, eğer kapalıysa açıyoruz.
            string kayit = "update PRODUCT_TBL set BARCODE=@barcode,PRODUCT_NAME=@urunAdi,CATEGORY=@kategori,UNIT=@birim,STOCK=@stok,SALE_PRICE=@satisFiyati,PURCHASE_PRICE=@alisFiyati,DISCOUNT=@indirim,DISCOUNT_CONTROL=@indirimKontrol,DESCRIPTION=@aciklama,SUPPLIER=@tedarikci,DISCOUNT_START=@indirimBaslangic,DISCOUNT_FINISH=@indirimBitis,IMAGE=@resim where PRODUCT_ID=@urunID";
            // müşteriler tablomuzun ilgili alanlarına kayıt ekleme işlemini gerçekleştirecek sorgumuz.
            SqlCommand komut = new SqlCommand(kayit, baglanti);
            //Sorgumuzu ve baglantimizi parametre olarak alan bir SqlCommand nesnesi oluşturuyoruz.
            komut.Parameters.AddWithValue("@barcode", barcode);
            komut.Parameters.AddWithValue("@urunAdi", urunAdi);
            komut.Parameters.AddWithValue("@kategori", kategori);
            komut.Parameters.AddWithValue("@birim", birim);
            komut.Parameters.AddWithValue("@stok", stok);
            komut.Parameters.AddWithValue("@satisFiyati", satisFiyati);
            komut.Parameters.AddWithValue("@alisFiyati", alisFiyati);
            komut.Parameters.AddWithValue("@indirim", indirim);
            komut.Parameters.AddWithValue("@indirimKontrol", indirimKontrol);
            komut.Parameters.AddWithValue("@aciklama", aciklama);
            komut.Parameters.AddWithValue("@tedarikci", tedarikci);
            komut.Parameters.AddWithValue("@indirimBaslangic", indirimBaslangic);
            komut.Parameters.AddWithValue("@indirimBitis", indirimBitis);
            komut.Parameters.AddWithValue("@resim", resim);
            komut.Parameters.AddWithValue("@urunID", urunID);
            //Parametrelerimize Form üzerinde ki kontrollerden girilen verileri aktarıyoruz.
            komut.ExecuteNonQuery();
            //Veritabanında değişiklik yapacak komut işlemi bu satırda gerçekleşiyor.
            baglanti.Close();
        }
        catch (Exception hata)
        {
            MessageBox.Show(hata.Message, "hata");
        }
    }
    public void Urun_Miktar_Guncelle_Database(double stok, int urunID)
    {
        try
        {
            if (baglanti.State == ConnectionState.Closed)
                baglanti.Open();
            string kayit = "update PRODUCT_TBL set STOCK=@stok where PRODUCT_ID=@urunID";
            SqlCommand komut = new SqlCommand(kayit, baglanti);
            komut.Parameters.AddWithValue("@stok", stok);
            komut.Parameters.AddWithValue("@urunID", urunID);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }
        catch (Exception hata)
        {
            MessageBox.Show(hata.Message, "hata");
        }
    }
    public void Musteri_Guncelle_Database(string adi, int musteriKodu, string telNo, 
        string adres, DateTime kayitTarihi, DateTime guncelleme, double bakiye,
        int musteriID)
    {

        //bağlantı cümlemizi kullanarak bir SqlConnection bağlantısı oluşt
        try
        {
            if (baglanti.State == ConnectionState.Closed)
                baglanti.Open();
            // Bağlantımızı kontrol ediyoruz, eğer kapalıysa açıyoruz.
            string kayit = "update CUSTOMER_TBL set CUSTOMER_NAME=@adi,CUSTOMER_CODE=@musteriKodu,CUSTOMER_PHONE=@telNo,CUSTOMER_ADRESS=@adres,SAVED_TIME=@kayitTarihi,UPDATEE=@guncelleme,REMAINDER=@bakiye where CUSTOMER_ID=@musteriID";
            // müşteriler tablomuzun ilgili alanlarına kayıt ekleme işlemini gerçekleştirecek sorgumuz.
            SqlCommand komut = new SqlCommand(kayit, baglanti);
            //Sorgumuzu ve baglantimizi parametre olarak alan bir SqlCommand nesnesi oluşturuyoruz.
            komut.Parameters.AddWithValue("@adi", adi);
            komut.Parameters.AddWithValue("@musteriKodu", musteriKodu);
            komut.Parameters.AddWithValue("@telNo", telNo);
            komut.Parameters.AddWithValue("@adres", adres);
            komut.Parameters.AddWithValue("@kayitTarihi", kayitTarihi);
            komut.Parameters.AddWithValue("@guncelleme", guncelleme);
            komut.Parameters.AddWithValue("@bakiye", bakiye);
            komut.Parameters.AddWithValue("@musteriID", musteriID);
            //Parametrelerimize Form üzerinde ki kontrollerden girilen verileri aktarıyoruz.
            komut.ExecuteNonQuery();
            //Veritabanında değişiklik yapacak komut işlemi bu satırda gerçekleşiyor.
            baglanti.Close();
        }
        catch (Exception hata)
        {
            MessageBox.Show(hata.Message, "hata");
        }
    }
    public void Kategori_Guncelle_Database(string adi, int kategoriID)
    {
        try
        {
            if (baglanti.State == ConnectionState.Closed)
                baglanti.Open();
            // Bağlantımızı kontrol ediyoruz, eğer kapalıysa açıyoruz.
            string kayit = "update CATEGORY_TBL set CATEGORY_NAME@adi where CATEGORY_ID=@kategoriID";
            // müşteriler tablomuzun ilgili alanlarına kayıt ekleme işlemini gerçekleştirecek sorgumuz.
            SqlCommand komut = new SqlCommand(kayit, baglanti);
            //Sorgumuzu ve baglantimizi parametre olarak alan bir SqlCommand nesnesi oluşturuyoruz.
            komut.Parameters.AddWithValue("@adi", adi);
            komut.Parameters.AddWithValue("@kategoriID", kategoriID);
            //Parametrelerimize Form üzerinde ki kontrollerden girilen verileri aktarıyoruz.
            komut.ExecuteNonQuery();
            //Veritabanında değişiklik yapacak komut işlemi bu satırda gerçekleşiyor.
            baglanti.Close();
        }
        catch (Exception hata)
        {
            MessageBox.Show(hata.Message, "hata");
        }
    }
    public void Yemek_Guncelle_Database(string adi, int kategori, string tip, double fiyat, bool kontrol, int yemekID)
    {
        try
        {
            if (baglanti.State == ConnectionState.Closed)
                baglanti.Open();
            // Bağlantımızı kontrol ediyoruz, eğer kapalıysa açıyoruz.
            string kayit = "update FOOD_TBL set FOOD_NAME=@adi,CATEGORY@kategori,FOOD_TYPE=@tip,FOOD_PRICE=@fiyat,CONTROL=@kontrol where FOOD_ID=@yemekID";
            // müşteriler tablomuzun ilgili alanlarına kayıt ekleme işlemini gerçekleştirecek sorgumuz.
            SqlCommand komut = new SqlCommand(kayit, baglanti);
            //Sorgumuzu ve baglantimizi parametre olarak alan bir SqlCommand nesnesi oluşturuyoruz.
            komut.Parameters.AddWithValue("@adi", adi);
            komut.Parameters.AddWithValue("@kategori", kategori);
            komut.Parameters.AddWithValue("@tip", tip);
            komut.Parameters.AddWithValue("@fiyat", fiyat);
            komut.Parameters.AddWithValue("@kontrol", kontrol);
            komut.Parameters.AddWithValue("@yemekID", yemekID);
            //Parametrelerimize Form üzerinde ki kontrollerden girilen verileri aktarıyoruz.
            komut.ExecuteNonQuery();
            //Veritabanında değişiklik yapacak komut işlemi bu satırda gerçekleşiyor.
            baglanti.Close();
        }
        catch (Exception hata)
        {
            MessageBox.Show(hata.Message, "hata");
        }
    }
    public void Satis_Guncelle_Database(string islemNo, string barkod, int urun,
        DateTime satisTarihi, double miktar, double toplamFiyat, int kategori,
        int personel, string tableName, double alisFiyat,
        double satisFiyat, int satisID)
    {
        try
        {
            if (baglanti.State == ConnectionState.Closed)
                baglanti.Open();
            // Bağlantımızı kontrol ediyoruz, eğer kapalıysa açıyoruz.
            string kayit = "update SELL_TBL set OPERATION_NO=@islemNo,BARCODE=@barkod,PRODUCT_NAME=@urun,SELL_DATE=@satisTarihi,AMOUNT=@miktar,TOTAL_PRICE=@toplamFiyat,CATEGORY=@kategori,EMPLOYEE=@personel, TABLE_NAME=@tableName, PRICE=@sFiyat,PURCHASE_PRICE=@aFiyat where SELL_ID=@satisID";
            // müşteriler tablomuzun ilgili alanlarına kayıt ekleme işlemini gerçekleştirecek sorgumuz.
            SqlCommand komut = new SqlCommand(kayit, baglanti);
            //Sorgumuzu ve baglantimizi parametre olarak alan bir SqlCommand nesnesi oluşturuyoruz.
            komut.Parameters.AddWithValue("@islemNo", islemNo);
            komut.Parameters.AddWithValue("@barkod", barkod);
            komut.Parameters.AddWithValue("@urun", urun);
            komut.Parameters.AddWithValue("@satisTarihi", satisTarihi);
            komut.Parameters.AddWithValue("@miktar", miktar);
            komut.Parameters.AddWithValue("@toplamFiyat", toplamFiyat);
            komut.Parameters.AddWithValue("@kategori", kategori);
            komut.Parameters.AddWithValue("@personel", personel);
            komut.Parameters.AddWithValue("@tableName", tableName);
            komut.Parameters.AddWithValue("@aFiyat", alisFiyat);
            komut.Parameters.AddWithValue("@sFiyat", satisFiyat);
            komut.Parameters.AddWithValue("@satisID", satisID);
            //Parametrelerimize Form üzerinde ki kontrollerden girilen verileri aktarıyoruz.
            komut.ExecuteNonQuery();
            //Veritabanında değişiklik yapacak komut işlemi bu satırda gerçekleşiyor.
            baglanti.Close();
        }
        catch (Exception hata)
        {
            MessageBox.Show(hata.Message, "hata");
        }
    }
    public void Tedarikci_Guncelle_Database(string adi, int tedarikciID)
    {
        try
        {
            if (baglanti.State == ConnectionState.Closed)
                baglanti.Open();
            // Bağlantımızı kontrol ediyoruz, eğer kapalıysa açıyoruz.
            string kayit = "update SUPPLIER_TBL set SUPPLIER_NAME=@adi where SUPPLIER_ID=@tedarikciID";
            // müşteriler tablomuzun ilgili alanlarına kayıt ekleme işlemini gerçekleştirecek sorgumuz.
            SqlCommand komut = new SqlCommand(kayit, baglanti);
            //Sorgumuzu ve baglantimizi parametre olarak alan bir SqlCommand nesnesi oluşturuyoruz.
            komut.Parameters.AddWithValue("@adi", adi);
            komut.Parameters.AddWithValue("@tedarikciID", tedarikciID);
            //Parametrelerimize Form üzerinde ki kontrollerden girilen verileri aktarıyoruz.
            komut.ExecuteNonQuery();
            //Veritabanında değişiklik yapacak komut işlemi bu satırda gerçekleşiyor.
            baglanti.Close();
        }
        catch (Exception hata)
        {
            MessageBox.Show(hata.Message, "hata");
        }
    }
    public void Birim_Guncelle_Database(string adi, int urunID)
    {
        try
        {
            if (baglanti.State == ConnectionState.Closed)
                baglanti.Open();
            // Bağlantımızı kontrol ediyoruz, eğer kapalıysa açıyoruz.
            string kayit = "update UNIT_TBL set UNIT_NAME=@adi where UNIT_ID=@urunID";
            // müşteriler tablomuzun ilgili alanlarına kayıt ekleme işlemini gerçekleştirecek sorgumuz.
            SqlCommand komut = new SqlCommand(kayit, baglanti);
            //Sorgumuzu ve baglantimizi parametre olarak alan bir SqlCommand nesnesi oluşturuyoruz.
            komut.Parameters.AddWithValue("@adi", adi);
            komut.Parameters.AddWithValue("@urunID", urunID);
            //Parametrelerimize Form üzerinde ki kontrollerden girilen verileri aktarıyoruz.
            komut.ExecuteNonQuery();
            //Veritabanında değişiklik yapacak komut işlemi bu satırda gerçekleşiyor.
            baglanti.Close();
        }
        catch (Exception hata)
        {
            MessageBox.Show(hata.Message, "hata");
        }
    }
    public void Sistem_Guncelle_Database(bool yedek, string yedekYolu, int yazici,
        int post, int etiket, string sirketAdi, string sirketTel, string sirketAdres,
        string serialKey, int sistemID)
    {
        try
        {
            if (baglanti.State == ConnectionState.Closed)
                baglanti.Open();
            // Bağlantımızı kontrol ediyoruz, eğer kapalıysa açıyoruz.
            string kayit = "update SYSTEM_TBL set BACKUPP=@yedek,BACKUP_PATH=@yedekYolu,PRINTER=@yazici,POST=@post,LABEL=@etiket,COMPANY_NAME=@sirketAdi,COMPANY_PHONE=@sirketTel,COMPANY_ADRESS=@sirketAdres,SERIAL_KEY=@serialKey where SYSTEM_ID=@sistemID";
            // müşteriler tablomuzun ilgili alanlarına kayıt ekleme işlemini gerçekleştirecek sorgumuz.
            SqlCommand komut = new SqlCommand(kayit, baglanti);
            //Sorgumuzu ve baglantimizi parametre olarak alan bir SqlCommand nesnesi oluşturuyoruz.
            komut.Parameters.AddWithValue("@yedek", yedek);
            komut.Parameters.AddWithValue("@yedekYolu", yedekYolu);
            komut.Parameters.AddWithValue("@yazici", yazici);
            komut.Parameters.AddWithValue("@post", post);
            komut.Parameters.AddWithValue("@etiket", etiket);
            komut.Parameters.AddWithValue("@sirketAdi", sirketAdi);
            komut.Parameters.AddWithValue("@sirketTel", sirketTel);
            komut.Parameters.AddWithValue("@sirketAdres", sirketAdres);
            komut.Parameters.AddWithValue("@serialKey", serialKey);
            komut.Parameters.AddWithValue("@sistemID", sistemID);
            //Parametrelerimize Form üzerinde ki kontrollerden girilen verileri aktarıyoruz.
            komut.ExecuteNonQuery();
            //Veritabanında değişiklik yapacak komut işlemi bu satırda gerçekleşiyor.
            baglanti.Close();
        }
        catch (Exception hata)
        {
            MessageBox.Show(hata.Message, "hata");
        }
    }
    public void Kampanya_Guncelle_Database(string adi, int kampanyaID)
    {
        try
        {
            if (baglanti.State == ConnectionState.Closed)
                baglanti.Open();
            // Bağlantımızı kontrol ediyoruz, eğer kapalıysa açıyoruz.
            string kayit = "update CAMPAIGN_TBL set CAMPAIGN_NAME=@adi where CAMPAIGN_ID=@kampanyaID";
            // müşteriler tablomuzun ilgili alanlarına kayıt ekleme işlemini gerçekleştirecek sorgumuz.
            SqlCommand komut = new SqlCommand(kayit, baglanti);
            //Sorgumuzu ve baglantimizi parametre olarak alan bir SqlCommand nesnesi oluşturuyoruz.
            komut.Parameters.AddWithValue("@adi", adi);
            komut.Parameters.AddWithValue("@kampanyaID", kampanyaID);
            //Parametrelerimize Form üzerinde ki kontrollerden girilen verileri aktarıyoruz.
            komut.ExecuteNonQuery();
            //Veritabanında değişiklik yapacak komut işlemi bu satırda gerçekleşiyor.
            baglanti.Close();
        }
        catch (Exception hata)
        {
            MessageBox.Show(hata.Message, "hata");
        }
    }
    public void Kasa_Guncelle_Database(string adi, string personel, DateTime islemTarihi,
        string islemNo, string aciklama, string odemeTuru, string islemTuru, double girenPara,
        double cikanPara, int kasaID)
    {
        try
        {
            if (baglanti.State == ConnectionState.Closed)
                baglanti.Open();
            // Bağlantımızı kontrol ediyoruz, eğer kapalıysa açıyoruz.
            string kayit = "update SAFE_TBL set SAFE_NAME=@adi,EMPLOYEE=@personel,OPERATION_DATE=@islemTarihi,OPERATION_NO=@islemNo,DESCRIPTION=@aciklama,PAY_TYPE=@odemeTuru,OPERATION_TYPE=@islemTuru,ENTER_PRICE=@girenPara,EXIT_PRICE=@cikanPara where SAFE_ID=@kasaID";
            // müşteriler tablomuzun ilgili alanlarına kayıt ekleme işlemini gerçekleştirecek sorgumuz.
            SqlCommand komut = new SqlCommand(kayit, baglanti);
            //Sorgumuzu ve baglantimizi parametre olarak alan bir SqlCommand nesnesi oluşturuyoruz.
            komut.Parameters.AddWithValue("@adi", adi);
            komut.Parameters.AddWithValue("@personel", personel);
            komut.Parameters.AddWithValue("@islemTarihi", islemTarihi);
            komut.Parameters.AddWithValue("@islemNo", islemNo);
            komut.Parameters.AddWithValue("@aciklama", aciklama);
            komut.Parameters.AddWithValue("@odemeTuru", odemeTuru);
            komut.Parameters.AddWithValue("@islemTuru", islemTuru);
            komut.Parameters.AddWithValue("@girenPara", girenPara);
            komut.Parameters.AddWithValue("@cikanPara", cikanPara);
            komut.Parameters.AddWithValue("@kasaID", kasaID);
            //Parametrelerimize Form üzerinde ki kontrollerden girilen verileri aktarıyoruz.
            komut.ExecuteNonQuery();
            //Veritabanında değişiklik yapacak komut işlemi bu satırda gerçekleşiyor.
            baglanti.Close();
        }
        catch (Exception hata)
        {
            MessageBox.Show(hata.Message, "hata");
        }

    }

    ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

    public void Kullanici_Sil_Database(int kullaniciID)
    {
        baglanti.Open();
        SqlCommand deletesorgu = new SqlCommand("delete from USER_TBL where USER_ID='" + kullaniciID + "'", baglanti);
        deletesorgu.ExecuteNonQuery();
        MessageBox.Show("Kayıt Silindi");
        baglanti.Close();
    }
    public void Urun_Sil_Database(string barcode)
    {
        baglanti.Open();
        SqlCommand deletesorgu = new SqlCommand("delete from PRODUCT_TBL where CONVERT(VARCHAR, BARCODE)=@barcode", baglanti);
        deletesorgu.Parameters.AddWithValue("@barcode", barcode);
        deletesorgu.ExecuteNonQuery();
        MessageBox.Show("Kayıt Silindi");
        baglanti.Close();
    }
    public void Musteri_Sil_Database(int musteriID)
    {
        baglanti.Open();
        SqlCommand deletesorgu = new SqlCommand("delete from CUSTOMER_TBL where CUSTOMER_ID='" + musteriID + "'", baglanti);
        deletesorgu.ExecuteNonQuery();
        MessageBox.Show("Kayıt Silindi");
        baglanti.Close();
    }
    public void Kategori_Sil_Database(int kategoriID)
    {
        baglanti.Open();
        SqlCommand deletesorgu = new SqlCommand("delete from CATEGORY_TBL where CATEGORY_ID='" + kategoriID + "'", baglanti);
        deletesorgu.ExecuteNonQuery();
        MessageBox.Show("Kayıt Silindi");
        baglanti.Close();
    }
    public void Yemek_Sil_Database(int yemekID)
    {
        baglanti.Open();
        SqlCommand deletesorgu = new SqlCommand("delete from FOOD_TBL where FOOD_ID='" + yemekID + "'", baglanti);
        deletesorgu.ExecuteNonQuery();

            MessageBox.Show("Kayıt Silindi");
            baglanti.Close();
    }
    public void Satis_Sil_Database(int satisID)
    {
        baglanti.Open();
       
        SqlCommand deletesorgu = new SqlCommand("delete from SELL_TBL where SELL_ID='" + satisID + "'", baglanti);
        deletesorgu.ExecuteNonQuery();
        MessageBox.Show("Kayıt Silindi");
        baglanti.Close();
    }
    public void Tedarikci_Sil_Database(int tedarikciID)
    {
        baglanti.Open();
        SqlCommand deletesorgu = new SqlCommand("delete from SUPPLIER_TBL where SUPPLIER_ID='" + tedarikciID + "'", baglanti);
        deletesorgu.ExecuteNonQuery();
        MessageBox.Show("Kayıt Silindi");
        baglanti.Close();
    }
    public void Birim_Sil_Database(int birimID)
    {
        baglanti.Open();
        SqlCommand deletesorgu = new SqlCommand("delete from UNIT_TBL where UNIT_ID='" + birimID + "'", baglanti);
        deletesorgu.ExecuteNonQuery();
        MessageBox.Show("Kayıt Silindi");
        baglanti.Close();
    }
    public void Sistem_Sil_Database(int sistemID)
    {

        baglanti.Open();
        SqlCommand deletesorgu = new SqlCommand("delete from SYSTEM_TBL where SYSTEM_ID='" + sistemID + "'", baglanti);
        deletesorgu.ExecuteNonQuery();
        MessageBox.Show("Kayıt Silindi");
        baglanti.Close();
    }
    public void Kampanya_Sil_Database(int kampanyaID)
    {
        baglanti.Open();
        SqlCommand deletesorgu = new SqlCommand("delete from CAMPAIGN_TBL where CAMPAIGN_ID='" + kampanyaID + "'", baglanti);
        deletesorgu.ExecuteNonQuery();
        MessageBox.Show("Kayıt Silindi");
        baglanti.Close();
    }
    public void Kasa_Sil_Database(int kasaID)
    {
        baglanti.Open();
        SqlCommand deletesorgu = new SqlCommand("delete from SAFE_TBL where SAFE_ID='" + kasaID + "'", baglanti);
        deletesorgu.ExecuteNonQuery();
        MessageBox.Show("Kayıt Silindi");
        baglanti.Close();
    }

    //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

    public SqlDataReader Kullanici_Bilgi_Database()
    {
        string sql = "SELECT * FROM USER_TBL";
        baglanti.Open();
        SqlCommand cmd = new SqlCommand(sql, baglanti);
        SqlDataReader dr = cmd.ExecuteReader();
        return dr;
    }
    public SqlDataReader Urun_Bilgi_Database()
    {
        string sql = "SELECT * FROM PRODUCT_TBL";
        baglanti.Open();
        SqlCommand cmd = new SqlCommand(sql, baglanti);
        SqlDataReader dr = cmd.ExecuteReader();
        return dr;
    }
    public SqlDataReader Urun_Bilgi_Getir_Database(string barkod)
    {
        
        string sql = "SELECT * FROM PRODUCT_TBL WHERE CONVERT(VARCHAR, BARCODE)='" + barkod +"'";
        baglanti.Open();
        SqlCommand cmd = new SqlCommand(sql, baglanti);
        SqlDataReader dr = cmd.ExecuteReader();
        return dr;
    }
    public SqlDataReader Urun_Bilgi_Database(string urunAdi)
    {

        string sql = "SELECT * FROM PRODUCT_TBL WHERE CONVERT(VARCHAR, PRODUCT_NAME)='" + urunAdi + "'";
        baglanti.Open();
        SqlCommand cmd = new SqlCommand(sql, baglanti);
        SqlDataReader dr = cmd.ExecuteReader();
        return dr;
    }
    public SqlDataReader Birim_Bilgi_Getir_Database()
    {
        string sql = "SELECT * FROM UNIT_TBL";
        baglanti.Open();
        SqlCommand cmd = new SqlCommand(sql, baglanti);
        SqlDataReader dr = cmd.ExecuteReader();
        return dr;

    }
    public SqlDataReader Tedarikci_Bilgi_Getir_Database()
    {
        string sql = "SELECT * FROM SUPPLIER_TBL";
        baglanti.Open();
        SqlCommand cmd = new SqlCommand(sql, baglanti);
        SqlDataReader dr = cmd.ExecuteReader();
        return dr;
    }
    public SqlDataReader Kategori_Bilgi_Getir_Database()
    {
        string sql = "SELECT * FROM CATEGORY_TBL";
        baglanti.Open();
        SqlCommand cmd = new SqlCommand(sql, baglanti);
        SqlDataReader dr = cmd.ExecuteReader();
        return dr;
    }
    public SqlDataReader Safe_Bilgi_Database()
    {
        string sql = "SELECT * FROM SAFE_TBL";
        baglanti.Open();
        SqlCommand cmd = new SqlCommand(sql, baglanti);
        SqlDataReader dr = cmd.ExecuteReader();
        return dr;
    }
    public SqlDataReader Sell_Bilgi_Database()
    {
        string sql = "SELECT * FROM SELL_TBL";
        baglanti.Open();
        SqlCommand cmd = new SqlCommand(sql, baglanti);
        SqlDataReader dr = cmd.ExecuteReader();
        return dr;
    }
    public SqlDataReader Table_Bilgi_Database()
    {
        string sql = "SELECT * FROM TABLE_TBL";
        baglanti.Open();
        SqlCommand cmd = new SqlCommand(sql, baglanti);
        SqlDataReader dr = cmd.ExecuteReader();
        return dr;
    }
    public SqlDataReader Masa_Bilgi_Database()
    {

        string sql = "SELECT * FROM TABLE_TBL";
        baglanti1.Open();
        SqlCommand cmd = new SqlCommand(sql, baglanti1);
        SqlDataReader dr = cmd.ExecuteReader();
        return dr;
    }
    public void Masa_Ekle_Database(string masaAdi, bool durum)
    {

        //bağlantı cümlemizi kullanarak bir SqlConnection bağlantısı oluşt
        try
        {
            if (baglanti.State == ConnectionState.Closed)
                baglanti.Open();
            // Bağlantımızı kontrol ediyoruz, eğer kapalıysa açıyoruz.
            string kayit = "insert into TABLE_TBL(NAME,ACTIVE) values (@masaAdi,@durum)";
            // müşteriler tablomuzun ilgili alanlarına kayıt ekleme işlemini gerçekleştirecek sorgumuz.
            SqlCommand komut = new SqlCommand(kayit, baglanti);
            //Sorgumuzu ve baglantimizi parametre olarak alan bir SqlCommand nesnesi oluşturuyoruz.
            komut.Parameters.AddWithValue("@masaAdi", masaAdi);
            komut.Parameters.AddWithValue("@durum", durum);
            //Parametrelerimize Form üzerinde ki kontrollerden girilen verileri aktarıyoruz.
            komut.ExecuteNonQuery();
            //Veritabanında değişiklik yapacak komut işlemi bu satırda gerçekleşiyor.
            baglanti.Close();
        }
        catch (Exception hata)
        {
            MessageBox.Show(hata.Message, "hata");
        }
    }
    public void Masa_Sil_Database(int masaID)
    {
        baglanti.Open();

        SqlCommand deletesorgu = new SqlCommand("delete from TABLE_TBL where ID='" + masaID + "'", baglanti);
        deletesorgu.ExecuteNonQuery();
        MessageBox.Show("Kayıt Silindi");
        baglanti.Close();
    }
    public void Masa_Adi_Guncelle_Database(string masaAdi, int masaID)
    {
        try
        {
            if (baglanti.State == ConnectionState.Closed)
                baglanti.Open();
            string kayit = "update TABLE_TBL set NAME=@masaAdi where ID=@masaID";
            SqlCommand komut = new SqlCommand(kayit, baglanti);
            komut.Parameters.AddWithValue("@masaAdi", masaAdi);
            komut.Parameters.AddWithValue("@masaID", masaID);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }
        catch (Exception hata)
        {
            MessageBox.Show(hata.Message, "hata");
        }
    }
    public void Masa_Tutar_Guncelle_Database(double tTutar, int masaID)
    {
        try
        {
            if (baglanti.State == ConnectionState.Closed)
                baglanti.Open();
            string kayit = "update TABLE_TBL set TOTAL_PRICE=@tTutar where ID=@masaID";
            SqlCommand komut = new SqlCommand(kayit, baglanti);
            komut.Parameters.AddWithValue("@tTutar", tTutar);
            komut.Parameters.AddWithValue("@masaID", masaID);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }
        catch (Exception hata)
        {
            MessageBox.Show(hata.Message, "hata");
        }
    }
    public void Masa_Aktiflik_Guncelle_Database(bool durum, int masaID)
    {
        try
        {
            if (baglanti.State == ConnectionState.Closed)
                baglanti.Open();
            // Bağlantımızı kontrol ediyoruz, eğer kapalıysa açıyoruz.
            string kayit = "update TABLE_TBL set ACTIVE=@durum where ID=@masaID";
            // müşteriler tablomuzun ilgili alanlarına kayıt ekleme işlemini gerçekleştirecek sorgumuz.
            SqlCommand komut = new SqlCommand(kayit, baglanti);
            //Sorgumuzu ve baglantimizi parametre olarak alan bir SqlCommand nesnesi oluşturuyoruz.
            komut.Parameters.AddWithValue("@durum", durum);
            komut.Parameters.AddWithValue("@masaID", masaID);
            //Parametrelerimize Form üzerinde ki kontrollerden girilen verileri aktarıyoruz.
            komut.ExecuteNonQuery();
            //Veritabanında değişiklik yapacak komut işlemi bu satırda gerçekleşiyor.
            baglanti.Close();
        }
        catch (Exception hata)
        {
            MessageBox.Show(hata.Message, "hata");
        }
    }
    public void UrunIslem_Ekle_Database(double guncellemeDegisim, DateTime guncellemeTarihi, string personel)
    {

        //bağlantı cümlemizi kullanarak bir SqlConnection bağlantısı oluşt
        try
        {
            if (baglanti.State == ConnectionState.Closed)
                baglanti.Open();
            // Bağlantımızı kontrol ediyoruz, eğer kapalıysa açıyoruz.
            string kayit = "insert into PRODUCT_OPERATION_TBL(UPDATE_CHANGE,UPDATE_DATE,PERSONEL) values (@guncellemeDegisim,@guncellemeTarihi,@personel)";
            // müşteriler tablomuzun ilgili alanlarına kayıt ekleme işlemini gerçekleştirecek sorgumuz.
            SqlCommand komut = new SqlCommand(kayit, baglanti);
            //Sorgumuzu ve baglantimizi parametre olarak alan bir SqlCommand nesnesi oluşturuyoruz.
            komut.Parameters.AddWithValue("@guncellemeDegisim", guncellemeDegisim);
            komut.Parameters.AddWithValue("@guncellemeTarihi", guncellemeTarihi);
            komut.Parameters.AddWithValue("@personel", personel);
            //Parametrelerimize Form üzerinde ki kontrollerden girilen verileri aktarıyoruz.
            komut.ExecuteNonQuery();
            //Veritabanında değişiklik yapacak komut işlemi bu satırda gerçekleşiyor.
            baglanti.Close();
        }
        catch (Exception hata)
        {
            MessageBox.Show(hata.Message, "hata");
        }
    }
    public void UrunIslem_Guncelle_Database(double guncellemeDegisim, DateTime guncellemeTarihi, string personel, int IslemID)
    {

        //bağlantı cümlemizi kullanarak bir SqlConnection bağlantısı oluşt
        try
        {
            if (baglanti.State == ConnectionState.Closed)
                baglanti.Open();
            // Bağlantımızı kontrol ediyoruz, eğer kapalıysa açıyoruz.
            string kayit = "update PRODUCT_OPERATION_TBL set UPDATE_CHANGE=@guncellemeDegisim,UPDATE_DATE=@guncellemeTarihi,PERSONEL=@personel where ID=@IslemID)";
            // müşteriler tablomuzun ilgili alanlarına kayıt ekleme işlemini gerçekleştirecek sorgumuz.
            SqlCommand komut = new SqlCommand(kayit, baglanti);
            //Sorgumuzu ve baglantimizi parametre olarak alan bir SqlCommand nesnesi oluşturuyoruz.
            komut.Parameters.AddWithValue("@guncellemeDegisim", guncellemeDegisim);
            komut.Parameters.AddWithValue("@guncellemeTarihi", guncellemeTarihi);
            komut.Parameters.AddWithValue("@personel", personel);
            komut.Parameters.AddWithValue("@IslemID", IslemID);
            //Parametrelerimize Form üzerinde ki kontrollerden girilen verileri aktarıyoruz.
            komut.ExecuteNonQuery();
            //Veritabanında değişiklik yapacak komut işlemi bu satırda gerçekleşiyor.
            baglanti.Close();
        }
        catch (Exception hata)
        {
            MessageBox.Show(hata.Message, "hata");
        }
    }
    public void UrunIslem_Sil_Database(int IslemID)
    {
        baglanti.Open();
        SqlCommand deletesorgu = new SqlCommand("delete from PRODUCT_OPERATION_TBL where ID='" + IslemID + "'", baglanti);
        deletesorgu.ExecuteNonQuery();
        MessageBox.Show("Kayıt Silindi");
        baglanti.Close();
    }
    public void Siparis_Guncelle_Database(string islemNo, string barkod, string urun,
        DateTime satisTarihi, double miktar, double toplamFiyat, string kategori,
        string personel, string tableName, double fiyat, double alisFiyat, int siparisID)
    {
        try
        {
            if (baglanti.State == ConnectionState.Closed)
                baglanti.Open();
            // Bağlantımızı kontrol ediyoruz, eğer kapalıysa açıyoruz.
            string kayit = "update ORDER_TBL set OPERATION_NO=@islemNo,BARCODE=@barkod,PRODUCT_NAME=@urun,DATE=@satisTarihi,AMOUNT=@miktar,TOTAL_PRICE=@toplamFiyat,CATEGORY=@kategori,EMPLOYEE=@personel,TABLE_NAME=@tableName,PRICE=@fiyat,PURCHASE_PRICE=@aFiyat where ID=@siparisID";
            // müşteriler tablomuzun ilgili alanlarına kayıt ekleme işlemini gerçekleştirecek sorgumuz.
            SqlCommand komut = new SqlCommand(kayit, baglanti);
            //Sorgumuzu ve baglantimizi parametre olarak alan bir SqlCommand nesnesi oluşturuyoruz.
            komut.Parameters.AddWithValue("@islemNo", islemNo);
            komut.Parameters.AddWithValue("@barkod", barkod);
            komut.Parameters.AddWithValue("@urun", urun);
            komut.Parameters.AddWithValue("@satisTarihi", satisTarihi);
            komut.Parameters.AddWithValue("@miktar", miktar);
            komut.Parameters.AddWithValue("@toplamFiyat", toplamFiyat);
            komut.Parameters.AddWithValue("@kategori", kategori);
            komut.Parameters.AddWithValue("@personel", personel);
            komut.Parameters.AddWithValue("@fiyat", fiyat);
            komut.Parameters.AddWithValue("@aFiyat", alisFiyat);
            komut.Parameters.AddWithValue("@tableName", tableName);
            komut.Parameters.AddWithValue("@siparisID", siparisID);
            //Parametrelerimize Form üzerinde ki kontrollerden girilen verileri aktarıyoruz.
            komut.ExecuteNonQuery();
            //Veritabanında değişiklik yapacak komut işlemi bu satırda gerçekleşiyor.
            baglanti.Close();
        }
        catch (Exception hata)
        {
            MessageBox.Show(hata.Message, "hata");
        }
    }
    public void Siparis_Ekle_Database(string islemNo, string barkod, string urun,
        DateTime satisTarihi, double miktar, double toplamFiyat, string kategori,
        string personel, string tableName, double fiyat, double alisFiyat)
    {
        try
        {
            if (baglanti.State == ConnectionState.Closed)
                baglanti.Open();
            // Bağlantımızı kontrol ediyoruz, eğer kapalıysa açıyoruz.
            string kayit = "insert into ORDER_TBL(OPERATION_NO,BARCODE,PRODUCT_NAME,DATE,AMOUNT," +
                "TOTAL_PRICE,CATEGORY,EMPLOYEE,TABLE_NAME,PRICE,PURCHASE_PRICE) values (@islemNo," +
                "@barkod,@urun,@satisTarihi,@miktar,@toplamFiyat,@kategori,@personel,@tableName,@fiyat,@aFiyat)";
            // müşteriler tablomuzun ilgili alanlarına kayıt ekleme işlemini gerçekleştirecek sorgumuz.
            SqlCommand komut = new SqlCommand(kayit, baglanti);
            //Sorgumuzu ve baglantimizi parametre olarak alan bir SqlCommand nesnesi oluşturuyoruz.
            komut.Parameters.AddWithValue("@islemNo", islemNo);
            komut.Parameters.AddWithValue("@barkod", barkod);
            komut.Parameters.AddWithValue("@urun", urun);
            komut.Parameters.AddWithValue("@satisTarihi", satisTarihi);
            komut.Parameters.AddWithValue("@miktar", miktar);
            komut.Parameters.AddWithValue("@toplamFiyat", toplamFiyat);
            komut.Parameters.AddWithValue("@kategori", kategori);
            komut.Parameters.AddWithValue("@personel", personel);
            komut.Parameters.AddWithValue("@tableName", tableName);
            komut.Parameters.AddWithValue("@fiyat", fiyat);
            komut.Parameters.AddWithValue("@aFiyat", alisFiyat);
            //Parametrelerimize Form üzerinde ki kontrollerden girilen verileri aktarıyoruz.
            komut.ExecuteNonQuery();
            //Veritabanında değişiklik yapacak komut işlemi bu satırda gerçekleşiyor.
            baglanti.Close();
        }
        catch (Exception hata)
        {
            MessageBox.Show(hata.Message, "HATA");
        }
    }
    public void Siparis_Sil_Database(int siparisID)
    {
        baglanti.Open();

        SqlCommand deletesorgu = new SqlCommand("delete from ORDER_TBL where ID='" + siparisID + "'", baglanti);
        deletesorgu.ExecuteNonQuery();
        baglanti.Close();
    }
    public SqlDataReader Siparis_MasaBilgiGetir_Database(string masaAdi)
    {
        string sql = "SELECT * FROM ORDER_TBL WHERE CONVERT(VARCHAR, TABLE_NAME)='" + masaAdi + "'";
        baglanti.Open();
        SqlCommand cmd = new SqlCommand(sql, baglanti);
        SqlDataReader dr = cmd.ExecuteReader();
        return dr;
    }
    public SqlDataReader Siparis_Bilgi_Getir_Database()
    {
        string sql = "SELECT * FROM ORDER_TBL";
        baglanti.Open();
        SqlCommand cmd = new SqlCommand(sql, baglanti);
        SqlDataReader dr = cmd.ExecuteReader();
        return dr;
    }
}