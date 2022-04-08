using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Configuration;
using System.Windows.Forms;

namespace Cafe_Otomat
{
    public partial class FrmStokIslemleri : Form
    {
        DataBase db = new DataBase();
        public static DateTime iBaslangic = DateTime.Now, iBitis = DateTime.Now;
        public static bool iControl = false;
        DataTable dt = new DataTable();
        string imagem = "";
        public FrmStokIslemleri()
        {
            InitializeComponent();
        }
        private void btnBarkodUret_Click(object sender, EventArgs e) //Kullanıcının girmesine gerek
        {                                       //kalmadan otomatik olarak random sayılarla eşsiz bir
            Random random = new Random();       //barkod oluşturmak için yazılan fonksiyon.
            string sayi = random.Next(100000, 999999).ToString() +
                random.Next(1000000, 9999999).ToString(); //13 basamaklı sayı yazamadığımız için bir adet
                                                          //6 ve bir adet 7 basamaklı sayılar oluşturduk.
            SqlDataReader dr = db.Urun_Bilgi_Database(); //Veri tabanındaki tüm barkodları getirildi.
            while (dr.Read()) //Üretilen barkod sayısının veri tabanından getirilen barkodlarla aynı
                              //olup olmadığını kontrol eden ve aynı değilse yeni barkod üreten döngü.
            {
                while (true)
                {
                    if (dr[1].ToString() == sayi)
                        sayi = random.Next(100000, 999999).ToString() +
                            random.Next(1000000, 9999999).ToString();
                    else
                        break;
                }
            }
            dr.Close();
            db.baglanti.Close(); //Okuma bağlantısı kapatılır.
            txtBarkod1.Text = sayi; //Üretilen barkod sayısı textBoxa yazdırılır.
        }
        private void FrmStokIslemleri_Load(object sender, EventArgs e)
        {
            ComboDoldur(1);
            ComboDoldur(2);
            ComboDoldur(3);
            ListeDoldur();
            comboArama.SelectedIndex = 0;
            ListeAnaliz();
        }
        void ComboDoldur(int index) // veritabanına nbağlanarak kategori, birim, tedarikçi tablolarından verileri aldık.
        {
            if(index == 1)
            {
                int temp = comboBirim.SelectedIndex;
                comboBirim.Items.Clear();
                comboBirim1.Items.Clear();
                SqlDataReader dr = db.Birim_Bilgi_Getir_Database();
                while (dr.Read())
                {
                    comboBirim.Items.Add(dr[1].ToString());
                    comboBirim1.Items.Add(dr[1].ToString());
                }
                dr.Close();
                db.baglanti.Close();
                comboBirim.SelectedIndex = temp;
                comboBirim1.SelectedIndex = temp;
            }
            else if (index == 2)
            {
                int temp = comboKategori.SelectedIndex;
                comboKategori.Items.Clear();
                comboKategori1.Items.Clear();
                SqlDataReader dr = db.Kategori_Bilgi_Getir_Database();
                while (dr.Read())
                {
                    comboKategori.Items.Add(dr[1].ToString());
                    comboKategori1.Items.Add(dr[1].ToString());
                }
                dr.Close();
                db.baglanti.Close();
                comboKategori.SelectedIndex = temp;
                comboKategori1.SelectedIndex = temp;
            }
            else if (index == 3)
            {
                int temp = comboTedarikci.SelectedIndex;
                comboTedarikci.Items.Clear();
                comboTedarikci1.Items.Clear();
                SqlDataReader dr = db.Tedarikci_Bilgi_Getir_Database();
                while (dr.Read())
                {
                    comboTedarikci.Items.Add(dr[1].ToString());
                    comboTedarikci1.Items.Add(dr[1].ToString());
                }
                dr.Close();
                db.baglanti.Close();
                comboTedarikci.SelectedIndex = temp;
                comboTedarikci1.SelectedIndex = temp;
            }
        }
        void ListeDoldur() // ürün listesini veritabından verilerle doldurduk
        {
            if (db.baglanti.State == ConnectionState.Closed)
                db.baglanti.Open();
            dt = new DataTable();
            using (SqlDataAdapter da = new SqlDataAdapter("SELECT BARCODE, PRODUCT_NAME, CATEGORY, " +
                "STOCK, UNIT, PURCHASE_PRICE, SALE_PRICE, DESCRIPTION FROM PRODUCT_TBL", db.baglanti))
            {
                da.Fill(dt);
            }
            db.baglanti.Close();
            for (int i = 0; i < dt.Columns.Count; i++)
                dt.Columns[i].ColumnName = listeDeneme.Columns[i].HeaderText;
            listeUrun.DataSource = dt;
        }
        void ListeAnaliz() // liste içerisinde dolaşıp textboxlara
                           // stok miktarı, toplam alış ve satış fiyat sonuçlarını yazdık.
        {
            double miktar = 0, sFiyat = 0, aFiyat = 0;
            txtUrunSayisi.Text = listeUrun.RowCount.ToString();
            foreach (DataGridViewRow item in listeUrun.Rows)
            {
                miktar += Convert.ToDouble(item.Cells[3].Value);
                sFiyat += Convert.ToDouble(item.Cells[6].Value) * miktar;
                aFiyat += Convert.ToDouble(item.Cells[5].Value) * miktar;
            }
            txtToplamStokMiktar.Text = miktar.ToString();
            txtToplamAlisFiyat.Text = aFiyat.ToString() + " ₺";
            txtToplamSatisFiyat_1.Text = sFiyat.ToString() + " ₺";
        }
        private void txtBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) &&
                e.KeyChar != ',' && e.KeyChar != '.';
        }
        void TextTemizle()
        {
            txtBarkod.Clear();
            txtAciklama.Clear();
            txtAlisFiyat.Clear();
            txtMiktari.Clear();
            txtSatisFiyat.Clear();
            txtIndirimliFiyat.Clear();
            comboBirim.ResetText();
            comboKategori.ResetText();
            comboTedarikci.ResetText();
            txtUrunAdi.Clear();
        }
        private void btnUrunEkle_Click(object sender, EventArgs e) // ürün ekleyip textboxları temizledik.
        {
            if (txtBarkod1.TextLength == 13 && txtUrunAdi1.TextLength != 0)
            {
                if (pctrStokLogo1.ImageLocation != null) // resmi stringe dönüştürdük
                {
                    imagem = pctrStokLogo1.ImageLocation;
                    Image image = Image.FromFile(imagem);
                    MemoryStream m = new MemoryStream();
                    image.Save(m, image.RawFormat);
                    byte[] imageBytes = m.ToArray();
                    imagem = Convert.ToBase64String(imageBytes);
                }
                db.Urun_Ekle_Database(txtBarkod1.Text, txtUrunAdi1.Text,
                    comboKategori1.Text, comboBirim1.Text, Convert.ToDouble(txtMiktari1.Text),
                    Convert.ToDouble(txtSatisFiyat1.Text), Convert.ToDouble(txtAlisFiyat1.Text),
                    0, false, txtAciklama1.Text, comboTedarikci1.Text, DateTime.Now, DateTime.Now,
                    DateTime.Now, imagem);
                txtBarkod1.Clear();
                txtAciklama1.Clear();
                txtAlisFiyat1.Clear();
                txtMiktari1.Clear();
                txtSatisFiyat1.Clear();
                comboBirim1.ResetText();
                comboKategori1.ResetText();
                comboTedarikci1.ResetText();
                txtUrunAdi1.Clear();
                pctrStokLogo1.Image = Properties.Resources.fast_food;
                ListeDoldur();
                ListeAnaliz();
            }
            else
                MessageBox.Show("Kullanıcı adı veya Bakod numarası boş olamaz!","",
                    MessageBoxButtons.OK,MessageBoxIcon.Error);
        }
        private void txtArama_TextChanged(object sender, EventArgs e)// comboAramaOlcut'da seçili olan ölçüte göre 
                                                                     // listede txtArama.Text'e göre arama yapıp listeyi getiriyor.
        {
            if (comboArama.SelectedIndex == 0)
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT BARCODE, PRODUCT_NAME, CATEGORY, STOCK, UNIT, PURCHASE_PRICE, SALE_PRICE, DESCRIPTION FROM PRODUCT_TBL WHERE BARCODE LIKE '%" + txtArama.Text + "%'", db.baglanti);
                dt = new DataTable();
                da.Fill(dt);
            }
            else if (comboArama.SelectedIndex == 1)
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT BARCODE, PRODUCT_NAME, CATEGORY, STOCK, UNIT, PURCHASE_PRICE, SALE_PRICE, DESCRIPTION FROM PRODUCT_TBL WHERE PRODUCT_NAME LIKE '%" + txtArama.Text + "%'", db.baglanti);
                dt = new DataTable();
                da.Fill(dt);
            }
            else if (comboArama.SelectedIndex == 2)
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT BARCODE, PRODUCT_NAME, CATEGORY, STOCK, UNIT, PURCHASE_PRICE, SALE_PRICE, DESCRIPTION FROM PRODUCT_TBL WHERE CATEGORY LIKE '%" + txtArama.Text + "%'", db.baglanti);
                dt = new DataTable();
                da.Fill(dt);
            }
            else if (comboArama.SelectedIndex == 3)
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT BARCODE, PRODUCT_NAME, CATEGORY, STOCK, UNIT, PURCHASE_PRICE, SALE_PRICE, DESCRIPTION FROM PRODUCT_TBL WHERE DESCRIPTION LIKE '%" + txtArama.Text + "%'", db.baglanti);
                dt = new DataTable();
                da.Fill(dt);
            }
            for (int i = 0; i < dt.Columns.Count; i++)
                dt.Columns[i].ColumnName = listeDeneme.Columns[i].HeaderText;
            listeUrun.DataSource = dt;
            db.baglanti.Close();
        }
        private void txtArama_Enter(object sender, EventArgs e)
        {
            txtArama.Text = "";
            txtArama.Font = new Font("Tahoma", 11.25F,
                FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
        }
        private void btnStokEkle_Click(object sender, EventArgs e)
        {
            if(listeUrun.RowCount != 0)
            {
                FrmStokEkle stokEkle = new FrmStokEkle(listeUrun.CurrentRow.Cells[0].Value.ToString());
                stokEkle.ShowDialog();
                ListeDoldur();
                ListeAnaliz();
            }
        }
        private void btnResimYukle_Click(object sender, EventArgs e) // resim seçme sayfasını açıyoruz.
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Filter = "IMAGE|*.jpg;*.png;*.jpeg;*.JPG;*.PNG;*.JPEG";
            fileDialog.Title = "drahnasoft.com"; 
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                if (fileDialog.FileName.Length != 0)
                {
                    pctrStokLogo.ImageLocation = fileDialog.FileName;
                    
                }
            }
        }
        private void btnResimSil_Click(object sender, EventArgs e)
        {
            pctrStokLogo.Image = Properties.Resources.fast_food;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnIslemIptal_Click(object sender, EventArgs e)
        {

        }

        private void btnUrunSil_Click(object sender, EventArgs e)
        {
            if (listeUrun.RowCount != 0)
            {
                if (MessageBox.Show("Ürün Silmek İstediğinizden Emin misiniz?", "REMIT-PRO", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    db.Urun_Sil_Database(listeUrun.CurrentRow.Cells[0].Value.ToString());
                    ListeDoldur();
                    ListeAnaliz();
                    if (listeUrun.RowCount.Equals(0))
                        TextTemizle();
                }
            }
            else
            {
                MessageBox.Show("Ürün yok", "REMIT-PRO",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnResimYukle1_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Filter = "IMAGE|*.jpg;*.png;*.jpeg;*.JPG;*.PNG;*.JPEG";
            fileDialog.Title = "drahnasoft.com";
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                if (fileDialog.FileName.Length != 0)
                {
                    pctrStokLogo1.ImageLocation = fileDialog.FileName;

                }
            }
        }

        private void btnResimSil1_Click(object sender, EventArgs e)
        {
            pctrStokLogo1.Image = Properties.Resources.fast_food;
        }
        private void btnIndirimControl_Click(object sender, EventArgs e)
        {
            SqlDataReader dataReader = db.Urun_Bilgi_Getir_Database(listeUrun.CurrentRow.Cells[0].Value.ToString());
            while (dataReader.Read())
            {
                iControl = Convert.ToBoolean(dataReader[9].ToString());
                iBaslangic = Convert.ToDateTime(dataReader[13].ToString());
                iBitis = Convert.ToDateTime(dataReader[14].ToString());
            }
            dataReader.Close();
            db.baglanti.Close();
            FrmIndirimControl indirimControl = new FrmIndirimControl();
            indirimControl.ShowDialog();
        }

        private void btnUrunDuzenle_Click(object sender, EventArgs e) // ürün formunda yapılan değişiklikleri veritabanına kaydettik
        {
            int id = 0;
            SqlDataReader dataReader = db.Urun_Bilgi_Getir_Database(listeUrun.CurrentRow.Cells[0].Value.ToString());
            while (dataReader.Read())
            {
                id = Convert.ToInt32(dataReader[0].ToString());
            }
            dataReader.Close();
            db.baglanti.Close();
            if (pctrStokLogo.ImageLocation != null) // resmi stringten imageye dönüştürdük
            {
                imagem = pctrStokLogo.ImageLocation;
                Image image = Image.FromFile(imagem);
                MemoryStream m = new MemoryStream();
                image.Save(m, image.RawFormat);
                byte[] imageBytes = m.ToArray();
                imagem = Convert.ToBase64String(imageBytes);
            }
            db.Urun_Guncelle_Database(txtBarkod.Text, txtUrunAdi.Text,
                comboKategori.Text, comboBirim.Text, Convert.ToDouble(txtMiktari.Text),
                Convert.ToDouble(txtSatisFiyat.Text), Convert.ToDouble(txtAlisFiyat.Text),
                Convert.ToDouble(txtIndirimliFiyat.Text), iControl, txtAciklama.Text,
                comboTedarikci.Text, iBaslangic, iBitis, imagem, id);
            ListeDoldur();
            ListeAnaliz();
        }

        private void btnBirimEkle_Click(object sender, EventArgs e)
        {
            FrmBirimIslemleri birimIslemleri = new FrmBirimIslemleri();
            birimIslemleri.ShowDialog();
            ComboDoldur(1);
        }
        private void btnTedarikciEkle_Click(object sender, EventArgs e)
        {
            FrmTedarikciIslemleri tedarikciIslemleri = new FrmTedarikciIslemleri();
            tedarikciIslemleri.ShowDialog();
            ComboDoldur(3);
        }
        private void btnKategoriEkle_Click(object sender, EventArgs e)
        {
            FrmKategoriIslemleri kategoriIslemleri = new FrmKategoriIslemleri();
            kategoriIslemleri.ShowDialog();
            ComboDoldur(2);
        }
        private void txtAlisFiyat1_TextChanged(object sender, EventArgs e)
        {
            if (txtAlisFiyat1.TextLength == 0)
                txtAlisFiyat1.Text = "0";
        }
        private void txtSatisFiyat1_TextChanged(object sender, EventArgs e)
        {
            if (txtSatisFiyat1.TextLength == 0)
                txtSatisFiyat1.Text = "0";
        }
        private void txtMiktari1_TextChanged(object sender, EventArgs e)
        {
            if (txtMiktari1.TextLength == 0)
                txtMiktari1.Text = "0";
        }

        private void txtUrunAdi1_TextChanged(object sender, EventArgs e)
        {
            txtUrunAdi1.Text = txtUrunAdi1.Text.ToUpper(); // harfleri büyük harfe dönüştürdük
            txtUrunAdi1.SelectionStart = txtUrunAdi1.Text.Length;
        }

        private void txtUrunAdi_TextChanged(object sender, EventArgs e)
        {
            txtUrunAdi.Text = txtUrunAdi.Text.ToUpper();
            txtUrunAdi.SelectionStart = txtUrunAdi.Text.Length;
        }

        private void comboBirim_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBirim.Text = comboBirim.Text.ToUpper();
            comboBirim.SelectionStart = comboBirim.Text.Length;
        }

        private void comboKategori_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboKategori.Text = comboKategori.Text.ToUpper();
            comboKategori.SelectionStart = comboKategori.Text.Length;
        }

        private void comboTedarikci_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboTedarikci.Text = comboTedarikci.Text.ToUpper();
            comboTedarikci.SelectionStart = comboTedarikci.Text.Length;
        }
        private void listeUrun_SelectionChanged(object sender, EventArgs e) // listede seçili satır değişince
                                                                            // seçili satırın bilgilerini textboxlara yazdık
        {
            string a = listeUrun.CurrentRow == null ? "" : listeUrun.CurrentRow.Cells[0].Value == null ? "" : listeUrun.CurrentRow.Cells[0].Value.ToString();
            SqlDataReader dataReader = db.Urun_Bilgi_Getir_Database(a);
            while (dataReader.Read())
            {
                txtBarkod.Text = dataReader[1].ToString();
                txtUrunAdi.Text = dataReader[2].ToString();
                txtAlisFiyat.Text = dataReader[7].ToString();
                txtSatisFiyat.Text = dataReader[6].ToString();
                txtMiktari.Text = dataReader[5].ToString();
                comboBirim.Text = dataReader[4].ToString();
                comboKategori.Text = dataReader[3].ToString();
                comboTedarikci.Text = dataReader[11].ToString();
                txtAciklama.Text = dataReader[10].ToString();
                iControl = Convert.ToBoolean(dataReader[9].ToString());
                iBaslangic = Convert.ToDateTime(dataReader[13].ToString());
                iBitis = Convert.ToDateTime(dataReader[14].ToString());
                txtIndirimliFiyat.Text = dataReader[8].ToString();
                if (dataReader[15].ToString().Length > 3) 
                {
                    string ppf = dataReader[15].ToString();
                    ppf = ppf.Replace("data:image/jpeg;base64,", "");
                    ppf = ppf.Replace("data:image/png;base64,", "");
                    var bytes = Convert.FromBase64String(ppf);
                    using (MemoryStream ms = new MemoryStream(bytes))
                    {
                        pctrStokLogo.Image = Image.FromStream(ms);
                    }
                }
                else
                {
                    pctrStokLogo.Image = Properties.Resources.fast_food;
                }
            }
            dataReader.Close();
            db.baglanti.Close();
        }
    }
}
