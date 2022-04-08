using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cafe_Otomat
{
    public partial class FrmSatisEkran : Form
    {
        DataBase db = new DataBase();// Veri Tabanı bağlantısı yapıldı
        DataTable dt = new DataTable();
        int masa = 0;
        double tutar = 0;
        double miktar = 0;
        public FrmSatisEkran()
        {
            //this.Hide();
            //FrmGiris giris = new FrmGiris();
            //giris.ShowDialog();
            InitializeComponent();
        }

        private void FrmAnasayfa_Load(object sender, EventArgs e)
        {
            //if (!FrmGiris.control)
            //{
            //    this.Close();
            //    return;
            //}
            timer1.Start();
            dt.Columns.Add("clmImage", Type.GetType("System.Byte[]"));
            UrunEkle();
            MasaEkle();
            MasaControl();
            MasaSec();
            listeSepet.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            listeSepet.RowsDefaultCellStyle.WrapMode = DataGridViewTriState.True;
            listeSepet.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            MasaSepetGetir();
            ListeAnaliz();
            MessageBox.Show((220 - 205 + 221).ToString());
        }
        void MasaSec() //Tıklanılan masanın rengini değiştirdik.
        {
            int a = 0;
            foreach (TabPage item in tabMasa.Controls)
                foreach (Masa temp in item.Controls)
                    if (a == 0)
                    {
                        temp.BackColor = Color.FromArgb(253, 208, 216);
                        txtSepetAdi.Text = temp.Text;
                        temp.control = true;
                        a++;
                    }
        }
        private void btnCikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnAyar_Click(object sender, EventArgs e)
        {

        }
        public void MasaEkle() //Masa ekleme fonksiyonu
        {
            //for (int k = 1; k <= pageSayisi; k++) //k döngüdeki sayfa sayısıdır.
            SqlDataReader dr = db.Table_Bilgi_Database();
            int k = 1;
            int _X_1 = 10, _Y_1 = 10, _X_2 = 10, _Y_2 = 235;
            int i = 0;
            TabPage newPage = new TabPage();
            while (dr.Read())
            {
                if (i%8==0)
                {
                    newPage = new TabPage();
                    _X_1 = 10; _Y_1 = 10; _X_2 = 10; _Y_2 = 235; i = 0; //Masaları yerleştirmek için salon sayfalarının boyutlarının ayarolanması.
                    newPage.Location = new Point(4, 23);
                    newPage.Name = "newPage" + (k).ToString();
                    newPage.Padding = new Padding(5);
                    newPage.Size = new Size(481, 239);
                    newPage.Text = "SALON " + (k).ToString();
                    tabMasa.Controls.Add(newPage);//Yeni salon sayfası ekleme olayı.
                }
                Masa newGrup = new Masa();//Masalar groupBox ile oluşturulmuştur.
                if (i < 4)//Eklenecek masa sayısı 4 den küçük ve eşitse masa ötelenerek x düzlemine yerleştirilir.Y düzlemi ise sabit kalır.
                {
                    newGrup.Location = new Point(_X_1, _Y_1);
                    newGrup.Name = "masa" + (i+1 + ((k - 1) * 8)).ToString();//Kaçıncı masa olduğunu gösterir.
                    newGrup.Size = new Size(220, 220);//Masa boyutu
                    newGrup.Text = dr[1].ToString();
                    _X_1 += 230;
                }
                else if (i < 8 && i >= 4) //girilen masa sayısı 4 ile 8 arasında ise y düzleminde alta kayılır ve x düzleminde başlangıç noktasından başlanır.
                {
                    newGrup.Location = new Point(_X_2, _Y_2);
                    newGrup.Name = "masa" + (i+1 + ((k - 1) * 8)).ToString();
                    newGrup.Size = new Size(220, 220);
                    newGrup.Text = dr[1].ToString();
                    _X_2 += 230;
                }
                newPage.Controls.Add(newGrup);
                newGrup.MouseClick += new MouseEventHandler(this.groupBox1_Click);
                newGrup.ContextMenuStrip = menuMasa;
                i++;
                if(i%8==0)
                    k++;
            }
            dr.Close();
            db.baglanti.Close();
        }
        [DllImport("kernel32.dll", EntryPoint = "CopyMemory", SetLastError = true)]
        public static extern void CopyMemoryUnmanaged(IntPtr dest, IntPtr src, int count);
        // in case you can't use P/Invoke, copy via intermediate .Net buffer        
        //static void CopyMemoryNet(IntPtr dst, IntPtr src, int count)
        //{
        //    byte[] buffer = new byte[count];
        //    Marshal.Copy(src, buffer, 0, count);
        //    Marshal.Copy(buffer, 0, dst, count);
        //}
        static Image CopyImagePart(Bitmap srcImg, int startH, int endH) //Butonun içine eklenilen resmin 
        {                                                //boyutunun 64 x 64 olarak ayarlanmasını sağlar.
            var width = srcImg.Width;
            var height = endH - startH;
            var srcBitmapData = srcImg.LockBits(new Rectangle(0, startH, width, height), 
                ImageLockMode.ReadOnly, srcImg.PixelFormat);

            var dstImg = new Bitmap(width, height, srcImg.PixelFormat);
            var dstBitmapData = dstImg.LockBits(new Rectangle(0, 0, width, height), 
                ImageLockMode.ReadWrite, srcImg.PixelFormat);

            int bytesCount = Math.Abs(srcBitmapData.Stride) * height;
            CopyMemoryUnmanaged(dstBitmapData.Scan0, srcBitmapData.Scan0, bytesCount);

            srcImg.UnlockBits(srcBitmapData);
            dstImg.UnlockBits(dstBitmapData);

            return dstImg;
        }
        public static Image ResizeInParts(Bitmap srcBmp, int width, int height)
        {
            int srcStep = srcBmp.Height;
            int dstStep = height;
            while (srcStep > 30000)
            {
                srcStep /= 2;
                dstStep /= 2;
            }

            var resBmp = new Bitmap(width, height);
            using (Graphics graphic = Graphics.FromImage(resBmp))
            {
                graphic.InterpolationMode = InterpolationMode.NearestNeighbor;
                graphic.PixelOffsetMode = PixelOffsetMode.Half;
                for (int srcTop = 0, dstTop = 0; srcTop < srcBmp.Height;
                    srcTop += srcStep, dstTop += dstStep)
                {
                    int srcBottom = srcTop + srcStep;
                    int dstH = dstStep;
                    if (srcBottom > srcBmp.Height)
                    {
                        srcBottom = srcBmp.Height;
                        dstH = height - dstTop;
                    }
                    using (var imgPart = CopyImagePart(srcBmp, srcTop, srcBottom))
                    {
                        graphic.DrawImage(imgPart, 0, dstTop, width, dstH);
                    }
                }
            }
            return resBmp;
        }
        void UrunEkle() //Product_TBL ye ürün ekler.
        {
            SqlDataReader dr1 = db.Urun_Bilgi_Database(); //Ürünlerin bilgilerini getirir.
            while (dr1.Read())
            {
                bool control = false;
                foreach (TabPage item in tabUrun.TabPages) 
                    if (item.Text == dr1[3].ToString()) //Eğer böyle bir ürün var mı diye kontrol eder varsa döngüden çıkar.
                    {
                        control = true;
                        break;
                    }
                if (!control)
                    tabUrun.TabPages.Add(dr1[3].ToString()); //Böyle bir ürün yoksa ekler.
            }
            dr1.Close();
            db.baglanti.Close();
            foreach (TabPage item in tabUrun.TabPages) //Eklenilen ürünleri sipariş sayfasındaki tabUrun'e ekler.
                item.AutoScroll = true; 
            SqlDataReader dr = db.Urun_Bilgi_Database();
            while (dr.Read())
                foreach (TabPage item in tabUrun.TabPages) //tabUrun de ilk satıra toplamda 8 ürün buton 
                    if (dr[3].ToString() == item.Text)//şeklinde eklenecektir.8 ürün eklendikten sonra y düzleminde 
                    {                                   //aşağı kayılarak ürünler eklenmeye devam eder.
                        int _X_1 = 15, _Y_1 = 15, k = 0;
                        if (item.Controls.Count > 0)
                        {
                            k = item.Controls.Count % 8 == 0 ? 8 : item.Controls.Count % 8;
                            _X_1 = item.Controls[item.Controls.Count-1].Location.X + 
                                item.Controls[item.Controls.Count - 1].Size.Width + 5;
                            _Y_1 = item.Controls[item.Controls.Count-1].Location.Y;
                        }
                        if (k > 7)
                        {
                            _X_1 = 15;
                            _Y_1 += 120;
                            k = 1;
                        }
                        Button newBtn = new Button();
                        newBtn.Location = new Point(_X_1, _Y_1);//Hangi ürüne tıklanıldığını gösterir.
                        newBtn.TextImageRelation = TextImageRelation.ImageAboveText;
                        newBtn.Size = new Size(110, 115);
                        string ppf = dr[15] == null ? "" : dr[15].ToString();
                        if (ppf.Length > 5) //Veri tabanına kaydedilen ürünleri resimlerini boyutlarını butona göre ayarlar.
                        {
                            ppf = ppf.Replace("data:image/jpeg;base64,", "");
                            ppf = ppf.Replace("data:image/png;base64,", "");
                            var bytes = Convert.FromBase64String(ppf);
                            using (MemoryStream ms = new MemoryStream(bytes))
                                newBtn.Image = ResizeInParts((Bitmap)Image.FromStream(ms), 64, 64);
                        }
                        else
                            newBtn.Image = Properties.Resources.fast_food;
                        newBtn.Text = dr[2].ToString();
                        newBtn.Click += new System.EventHandler(this.Button_Click);
                        k++;
                        item.Controls.Add(newBtn);
            }
            dr.Close();
            db.baglanti.Close();
            
        }
        public string IslemNo_Uret() //Her masa için benzersiz sipariş numarası üretilir.
        {
            SqlDataReader dr = db.Safe_Bilgi_Database();
            Random random = new Random();
            string sayi = random.Next(100000, 999999).ToString() + //13 haneli olacağı için 2 basamağa ayırdık.
                random.Next(1000000, 9999999).ToString();
            while (dr.Read())
            {
                while (true)
                {
                    if (dr[4].ToString() == sayi)
                        sayi = random.Next(100000000, 999999999).ToString();
                    else
                        break;
                }
            }
            dr.Close();
            db.baglanti.Close();
            return sayi;
        }
        private void Button_Click(object sender, EventArgs e)
        {
            string islemNo = "";
            foreach (TabPage item in tabMasa.Controls)
            {
                foreach (Masa temp in item.Controls)
                {
                    if (txtSepetAdi.Text == temp.Text)
                    {
                        if (temp.islemNo.Length == 0)
                        {
                            islemNo = IslemNo_Uret();
                            temp.islemNo = islemNo;
                        }
                        else
                        {
                            islemNo = temp.islemNo;
                        }
                    }
                }
            }
            foreach (TabPage item in tabUrun.TabPages)
            {
                foreach (Button temp in item.Controls)
                {
                    if (temp.Focused)
                    {
                        SqlDataReader dr = db.Urun_Bilgi_Database(temp.Text); //Tıklanılan ürünün bilgisini dr ye atadık.
                        SiparisDB siparis = new SiparisDB();
                        while (dr.Read())
                        {
                            siparis = new SiparisDB //Oluşturmuş olduğumuz listeye tıklanan ürünün bilgilerini atadık.
                            {
                                Id = Convert.ToInt32(dr[0].ToString()),
                                Barkod = dr[1].ToString(),
                                UrunAd = dr[2].ToString(),
                                Kategori = dr[3].ToString(),
                                AlisFiyat = Convert.ToDouble(dr[7].ToString()),
                                Fiyat = Convert.ToDouble(dr[6].ToString()),
                                IslemNo = islemNo,
                                Miktar = 1,
                                Personel = DataBase.kullanici,
                                Tarih = DateTime.Now,
                                ToplamTutar = 1 * Convert.ToDouble(dr[6].ToString()),
                                MasaAd = txtSepetAdi.Text
                            };
                            miktar = Convert.ToDouble(dr[5].ToString());
                        }
                        dr.Close();
                        db.baglanti.Close();
                        SepetGetir(siparis);
                    }
                }
            }
            
        }
        void SepetGetir(SiparisDB siparis) //Siparişler sepete eklenir.
        {
            double miktar = 0, tTutar = 0;
            bool control = false;
            int id = 0;
            SqlDataReader reader = db.Siparis_Bilgi_Getir_Database();
            while (reader.Read())
            {
                if (reader[1].ToString() == siparis.MasaAd)
                {
                    if (reader[3].ToString() == siparis.Barkod) //Getirilen masanın içerisindeki siparişleri getirir.
                    {
                        miktar = Convert.ToDouble(reader[6].ToString());
                        tTutar = Convert.ToDouble(reader[8].ToString());
                        miktar += siparis.Miktar;
                        tTutar += siparis.ToplamTutar;
                        id = Convert.ToInt32(reader[0].ToString());
                        control = true;
                    }
                }
            }
            reader.Close();
            db.baglanti.Close();
            if ((this.miktar - siparis.Miktar) < 0) //Sepetteki ürün miktarı ayarı.İstenilen ürün stokta yoksa uyarı verir.
            {
                MessageBox.Show("Sipariş Etmek İstediğiniz Ürün Tükenmiştir!!!", "UYARI",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (control)//Stokta ürün varsa miktar arttırıp azaltılabilir.
                {
                    db.Siparis_Guncelle_Database(siparis.IslemNo, siparis.Barkod,
                         siparis.UrunAd, siparis.Tarih, miktar, tTutar, siparis.Kategori,
                         siparis.Personel, siparis.MasaAd, siparis.Fiyat, siparis.AlisFiyat, id);
                }
                else //Ürün sepette varsa üzerine ekleme yap yoksa sepete ekle.
                {
                    db.Siparis_Ekle_Database(siparis.IslemNo, siparis.Barkod,
                         siparis.UrunAd, siparis.Tarih, siparis.Miktar, siparis.ToplamTutar,
                         siparis.Kategori, siparis.Personel, siparis.MasaAd, siparis.Fiyat,
                         siparis.AlisFiyat);
                }
                db.Urun_Miktar_Guncelle_Database(this.miktar - siparis.Miktar, siparis.Id);//Sipariş edilen ürünün veri tabanında güncellemesi yapılır.
                ListeAnaliz();
                MasaSepetGetir();
                SqlDataReader dr = db.Table_Bilgi_Database();
                while (dr.Read())
                    if (dr[1].ToString() == siparis.MasaAd)
                        id = Convert.ToInt32(dr[0].ToString());
                dr.Close();
                db.baglanti.Close();
                db.Masa_Tutar_Guncelle_Database(tutar, id);
                db.Masa_Aktiflik_Guncelle_Database(true, id);
            }
            MasaControl();
        }
        void MasaSepetGetir() //Tıklanılan masanın siparişlerini sepete getirir.
        {
            listeSepet.Rows.Clear();
            Button btnPlus = new Button();
            Button btnMinus = new Button();
            SqlDataReader reader = db.Siparis_Bilgi_Getir_Database();
            while (reader.Read())
            {
                if(reader[1].ToString() == txtSepetAdi.Text)
                {
                    if(reader[13].ToString() == "True")
                    {

                    }
                }
                    
            }
            reader.Close();
            db.baglanti.Close();
        }
        private void btnOnayla_Click(object sender, EventArgs e)
        {
            Button btnPlus = new Button();
            Button btnMinus = new Button();
            foreach (DataGridViewRow item in listeSepet.SelectedRows)
            {
                //db.Siparis_Guncelle_Database(txtSepetAdi.Id, item.Cells[0].Value.ToString(), true);
            }
            MasaSepetGetir();
        }
        private void btnMasaEkle_Click(object sender, EventArgs e)
        {
            FrmKasaIslemleri kasaIslemleri = new FrmKasaIslemleri();
            kasaIslemleri.ShowDialog();
        }
        private void groupBox1_Click(object sender, EventArgs e)
        {
            Point cp = PointToClient(Cursor.Position);
            foreach (TabPage item in tabMasa.TabPages)//Tıklanılan masanın rengini değiştirir ve masanın sipariş durumunu sepete getirir.
                foreach (Masa temp in item.Controls)
                    if (temp.BackColor == Color.FromArgb(253, 208, 216))
                    {
                        temp.BackColor = Color.Transparent; //Masanın içerisinde ürün yoksa rengi değişmez.
                        if(txtSepetAdi.Text == temp.Text)
                        {
                            bool control = false;
                            SqlDataReader reader = db.Siparis_Bilgi_Getir_Database();
                            while (reader.Read())
                            {
                                if (temp.Text == reader[1].ToString())
                                    control = true;
                            }
                            reader.Close();
                            db.baglanti.Close();
                            if (control)
                            {
                                int id = 0;
                                SqlDataReader dr = db.Table_Bilgi_Database();
                                while (dr.Read())
                                {
                                    if(dr[1].ToString() == temp.Text)
                                        id = Convert.ToInt32(dr[0].ToString());
                                }
                                dr.Close();
                                db.baglanti.Close();
                                temp.BackColor = Color.LightCyan;//Başka bir masaya tıkladığımızda sepetinde ürün olan masalar maviye döner.
                                db.Masa_Aktiflik_Guncelle_Database(true, id); 
                            }
                            else
                            {
                                int id = 0;
                                SqlDataReader dr = db.Table_Bilgi_Database();
                                while (dr.Read())
                                {
                                    if (dr[1].ToString() == temp.Text)
                                        id = Convert.ToInt32(dr[0].ToString());
                                }
                                dr.Close();
                                db.baglanti.Close();
                                temp.BackColor = Color.Transparent;
                                db.Masa_Aktiflik_Guncelle_Database(false, id);
                            }
                        }
                    } 
            MasaControl();
            foreach (TabPage item in tabMasa.TabPages)
                foreach (Masa temp in item.Controls)
                {       //Tıklanılan masanın rengini kırmızı yapar.
                    if (temp.Name == "masa" + MasaNoBul(cp)) 
                    {
                        temp.control = true;
                        temp.BackColor = Color.FromArgb(253, 208, 216);
                        txtSepetAdi.Text = temp.Text;
                    }
                    else
                        temp.control = false;
                }
            MasaSepetGetir();
            ListeAnaliz();
        }
        private string MasaNoBul(Point e) //Masanın numarasının 
        { // TabPage içerisinde ekli olan groupBox ların lokasyonları ile buluruz.
            int tabIndex = tabMasa.SelectedIndex * 8, sonuc = 0;

            if (e.Y >= 10 && e.Y <= 250)
            {
                if (e.X >= 10 && e.X <= 290)
                    masa = 1;
                else if (e.X >= 305 && e.X <= 545)
                    masa = 2;
                else if (e.X >= 555 && e.X <= 795)
                    masa = 3;
                else if (e.X >= 805 && e.X <= 1045)
                    masa = 4;
            }
            else if (e.Y >= 260 && e.Y <= 500) 
            {
                if (e.X >= 10 && e.X <= 290)
                    masa = 5;
                else if (e.X >= 305 && e.X <= 545)
                    masa = 6;
                else if (e.X >= 555 && e.X <= 795)
                    masa = 7;
                else if (e.X >= 805 && e.X <= 1045)
                    masa = 8;
            }
            sonuc = tabIndex + masa;
            return sonuc.ToString();
        }
        private void listeSepet_CellValueChanged(object sender, DataGridViewCellEventArgs e)//Sepet içerisinde seçili ürünün herhangi bir yerinde değişiklik olduğunda çağrılır.
        {
            if (listeSepet.RowCount > 0)
            {
                int id = 0;
                double miktar = 0, tTutar = 0;
                SiparisDB item = new SiparisDB();
                SqlDataReader reader = db.Siparis_MasaBilgiGetir_Database(txtSepetAdi.Text);
                while (reader.Read())
                {
                    if (reader[4].ToString() == listeSepet.CurrentRow.Cells[0].Value.ToString())
                    {
                        miktar = Convert.ToDouble(listeSepet.CurrentRow.Cells[2].Value); //Convert.ToDouble(reader[6].ToString());
                        tTutar = miktar* Convert.ToDouble(reader[7].ToString());
                        id = Convert.ToInt32(reader[0].ToString());
                        item.Barkod = reader[3].ToString();
                        item.Fiyat = Convert.ToDouble(reader[7].ToString());
                        item.IslemNo = reader[2].ToString();
                        item.Kategori = reader[9].ToString();
                        item.MasaAd = reader[1].ToString();
                        item.Miktar = miktar;
                        item.Personel = reader[10].ToString();
                        item.Tarih = Convert.ToDateTime(reader[5].ToString());
                        item.ToplamTutar = tTutar;
                        item.UrunAd = reader[4].ToString();
                    }
                }
                reader.Close();
                db.baglanti.Close();
                listeSepet.CurrentRow.Cells[4].Value = tTutar;
                db.Siparis_Guncelle_Database(item.IslemNo, item.Barkod,
                    item.UrunAd, item.Tarih, item.Miktar, item.ToplamTutar,
                    item.Kategori, item.Personel, item.MasaAd, item.Fiyat,
                    item.AlisFiyat, id);
                if (listeSepet.CurrentRow != null)
                    if (Convert.ToDouble(listeSepet.CurrentRow.Cells[2].Value) <= 0)
                    {
                        SqlDataReader reader1 = db.Siparis_MasaBilgiGetir_Database(txtSepetAdi.Text);
                        while (reader1.Read())
                        {
                            if (listeSepet.CurrentRow.Cells[0].Value.ToString() == reader1[4].ToString())
                            {
                                id = Convert.ToInt32(reader1[0].ToString());
                            }
                        }
                        reader1.Close();
                        db.baglanti.Close();
                        db.Siparis_Sil_Database(id);
                        listeSepet.Rows.RemoveAt(listeSepet.CurrentRow.Index);
                    }
            }
            
            ListeAnaliz();
        }
        private void listeSepet_CellContentClick(object sender, DataGridViewCellEventArgs e)//Liste üzerindeki + , - butonlarına tıklanıldığında liste üzerinde değerler güncellendi.
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.ColumnIndex == 3 &&
                e.RowIndex >= 0)
            {
                double temp = Convert.ToInt32(listeSepet.Rows[e.RowIndex].Cells[2].Value);
                temp++;
                listeSepet.Rows[e.RowIndex].Cells[2].Value = temp;
            }
            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.ColumnIndex == 1 &&
                e.RowIndex >= 0)
            {
                double temp = Convert.ToInt32(listeSepet.Rows[e.RowIndex].Cells[2].Value);
                temp--;
                listeSepet.Rows[e.RowIndex].Cells[2].Value = temp;
            }
            ListeAnaliz();
        }
        private void ürünüSilToolStripMenuItem_Click(object sender, EventArgs e)//Context strip menu üzerinden tıklanıldığında ürünü silme fonksiyonu.
        {
            if(listeSepet.RowCount > 0)
            {
                int id = 0;
                SqlDataReader reader = db.Siparis_MasaBilgiGetir_Database(txtSepetAdi.Text);
                while (reader.Read())
                {
                    if (listeSepet.CurrentRow.Cells[0].Value.ToString() == reader[4].ToString())
                    {
                        id = Convert.ToInt32(reader[0].ToString());
                    }
                }
                reader.Close();
                db.baglanti.Close();
                db.Siparis_Sil_Database(id);
                listeSepet.Rows.RemoveAt(listeSepet.CurrentRow.Index);
                ListeAnaliz();
            }
        }
        private void masaAdıDeğiştirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Point cp = PointToClient(Cursor.Position);
            foreach (TabPage item in tabMasa.TabPages)
                foreach (Masa temp in item.Controls)
                    if (temp.Name == "masa" + MasaNoBul(cp))
                    {
                        FrmMasaAdi masaAdi = new FrmMasaAdi(temp.Text);
                        masaAdi.ShowDialog();
                        temp.Text = FrmMasaAdi.masaAdi;
                    }
        }
        void MasaControl()//Masada aktiflik durumuna göre renk değiştirme fonksiyonu.
        {
            foreach (TabPage item in tabMasa.TabPages)
                foreach (Masa temp in item.Controls)
                {
                    SqlDataReader dr = db.Table_Bilgi_Database();
                    while (dr.Read())
                    {
                        if (temp.Text == dr[1].ToString() && dr[2].ToString() == "True")
                            temp.BackColor = Color.LightCyan;
                        else if (temp.Text == dr[1].ToString() && dr[2].ToString() == "False")
                            temp.BackColor = Color.Transparent;
                    }
                    dr.Close();
                    db.baglanti.Close();
                    if(temp.control)
                        temp.BackColor = Color.FromArgb(253, 208, 216);
                }
        }
        void ListeAnaliz() //Tutarı güncellemişiz.
        {
            tutar = 0;
            SqlDataReader reader = db.Siparis_MasaBilgiGetir_Database(txtSepetAdi.Text);
            while (reader.Read())
            {
                tutar += Convert.ToDouble(reader[8].ToString());
            }
            reader.Close();
            db.baglanti.Close();
            txtTTutar.Text = tutar.ToString() + " ₺";
        }
        private void masaHesapKapatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int id = 0;
            Point cp = PointToClient(Cursor.Position);
            foreach (TabPage item in tabMasa.TabPages)
                foreach (Masa temp in item.Controls)
                {
                    if (temp.Name == "masa" + MasaNoBul(cp))
                    {
                        double tutarim = 0;
                        SqlDataReader dr1 = db.Siparis_MasaBilgiGetir_Database(temp.Text);
                        while (dr1.Read())
                        {
                            tutarim += Convert.ToDouble(dr1[8].ToString());
                        }
                        dr1.Close();
                        db.baglanti.Close();
                        SqlDataReader dr = db.Table_Bilgi_Database();
                        while (dr.Read())
                        {
                            if (dr[1].ToString() == temp.Text)
                            {
                                id = Convert.ToInt32(dr[0].ToString());
                            }
                        }
                        dr.Close();
                        db.baglanti.Close();
                        db.Masa_Tutar_Guncelle_Database(tutarim, id);
                        FrmHesapKapat hesapKapat = new FrmHesapKapat(id);
                        hesapKapat.ShowDialog();
                        SqlDataReader dr2 = db.Table_Bilgi_Database();
                        while (dr2.Read())
                        {
                            if (dr2[1].ToString() == temp.Text)
                            {
                                if (dr2[2].ToString() == "False")
                                    temp.BackColor = Color.Transparent;
                            }
                        }
                        dr2.Close();
                        db.baglanti.Close();
                        
                    }
                }
            MasaSepetGetir();
            MasaControl();
            ListeAnaliz();
            MasaSec();
        }
        private void timer1_Tick(object sender, EventArgs e) //Çoklu kullanıcıda başkasının yaptığı değişikliği anlık kontrol etmek için kullanılır.
        {
            foreach (TabPage item in tabMasa.TabPages)
                foreach (Masa temp in item.Controls)
                {
                    SqlDataReader dr = db.Masa_Bilgi_Database();
                    while (dr.Read())
                    {
                        if (!temp.control)
                        {
                             if (temp.Text == dr[1].ToString() && dr[2].ToString() == "True")
                                temp.BackColor = Color.LightCyan;
                             else if (temp.Text == dr[1].ToString() && dr[2].ToString() == "False")
                                temp.BackColor = Color.Transparent;
                        }
                    }
                    dr.Close();
                    db.baglanti1.Close();
                }
        }
        private void btnIslemler_Click(object sender, EventArgs e)
        {
            FrmIslemler islemler = new FrmIslemler();
            islemler.ShowDialog();
        }
        private void btnRapor_Click(object sender, EventArgs e)
        {
            FrmSatisRapor satisRapor = new FrmSatisRapor();
            satisRapor.ShowDialog();
        }
    } 
}
