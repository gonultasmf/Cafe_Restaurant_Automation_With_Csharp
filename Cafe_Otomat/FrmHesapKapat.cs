using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cafe_Otomat
{
    public partial class FrmHesapKapat : Form
    {
        DataBase db = new DataBase();
        DataTable dt = new DataTable();
        int id;
        public FrmHesapKapat(int id)
        {
            this.id = id;
            InitializeComponent();
        }

        private void FrmHesapKapat_Load(object sender, EventArgs e)
        {
            SqlDataReader dr = db.Table_Bilgi_Database(); //Masa bilgilerini DB'den getirir.
            while (dr.Read())
            {
                if(dr[0].ToString() == id.ToString())
                {
                    txtMasaAdi.Text = dr[1].ToString();
                    txtTTutar.Text = dr[3].ToString() + " ₺"; //Masa adı ve toplam tutarı aldık.
                }
            }
            dr.Close();
            db.baglanti.Close();
            if (db.baglanti.State == ConnectionState.Closed) //Bağlantı kapalıysa açıyoruz.
                db.baglanti.Open();
            dt = new DataTable();
            using (SqlDataAdapter da = new SqlDataAdapter("SELECT PRODUCT_NAME, AMOUNT, " +
                "TOTAL_PRICE, EMPLOYEE FROM ORDER_TBL WHERE CONVERT(VARCHAR, TABLE_NAME) = @masa", db.baglanti))//Masa adına göre sorgu yapmamızı sağlar.
            {
                da.SelectCommand.Parameters.Add("@masa", txtMasaAdi.Text);
                da.Fill(dt);
            }
            db.baglanti.Close();
            dt.Columns[0].ColumnName = "ÜRÜN";
            dt.Columns[1].ColumnName = "MİKTAR";
            dt.Columns[2].ColumnName = "TUTAR";
            dt.Columns[3].ColumnName = "PERSONEL"; //Masadaki siparişleri dataTable'a atıyoruz.
            listeSiparisler.DataSource = dt; //dataTable'da ki verileri listeSiparislere aktarıyoruz.
            toolTip1.SetToolTip(btnEkle, "Bu Listeye EKLER...");
            comboOdeme.SelectedIndex = 0;
            listeSiparisler.Select();
            ListeAnaliz(); //Tutar hesaplamaları için çağrılır.
        }
        private void btnIptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnOdeme_Click(object sender, EventArgs e) //listeHesap içerisine aktarılan ürünlerin tutarını öder.
        {
            //db.Masa_Aktiflik_Guncelle_Database(false, id);
            //db.Masa_Tutar_Guncelle_Database(0, id);
            if (listeHesap.RowCount > 0)
            {
                List<SiparisDB> siparisler = new List<SiparisDB>();
                foreach (DataGridViewRow row in listeHesap.Rows)
                {
                    SqlDataReader dr = db.Siparis_MasaBilgiGetir_Database(txtMasaAdi.Text);
                    while (dr.Read())
                    {
                        if (row.Cells[0].Value.ToString() == dr[4].ToString())
                        {
                            SiparisDB siparis = new SiparisDB
                            {
                                Id = Convert.ToInt32(dr[0].ToString()),
                                Barkod = dr[3].ToString(),
                                ToplamTutar = Convert.ToDouble(row.Cells[2].Value),
                                IslemNo = dr[2].ToString(),
                                Kategori = dr[9].ToString(),
                                MasaAd = dr[1].ToString(),
                                Miktar = Convert.ToDouble(row.Cells[1].Value),
                                Personel = dr[10].ToString(),
                                Tarih = Convert.ToDateTime(dr[5].ToString()),
                                UrunAd = dr[4].ToString(),
                                Fiyat = Convert.ToDouble(dr[7].ToString()),
                                AlisFiyat = Convert.ToDouble(dr[11].ToString())
                            };
                            siparisler.Add(siparis);
                        }
                    }
                    dr.Close();
                    db.baglanti.Close();
                }
                double tutar = 0;
                bool control = false;
                foreach (SiparisDB item in siparisler)
                {
                    db.Satis_Ekle_Database(item.IslemNo, item.Barkod,
                        item.UrunAd, item.Tarih, item.Miktar, item.ToplamTutar,
                        item.Kategori, item.Personel, item.MasaAd, item.AlisFiyat,
                        item.Fiyat);
                    tutar += item.ToplamTutar;
                    foreach (DataGridViewRow row in listeSiparisler.Rows)
                    {
                        if (row.Cells[0].Value.ToString() == item.UrunAd)
                        {
                            db.Siparis_Guncelle_Database(item.IslemNo, item.Barkod,
                                item.UrunAd, item.Tarih, Convert.ToDouble(row.Cells[1].Value),
                                Convert.ToDouble(row.Cells[2].Value), item.Kategori, item.Personel,
                                item.MasaAd, item.Fiyat, item.AlisFiyat, item.Id);
                            control = true;
                        }
                    }
                    if (!control)
                    {
                        db.Siparis_Sil_Database(item.Id);
                    }
                }

                db.Kasa_Ekle_Database("KASA-2", DataBase.kullanici, DateTime.Now,
                    siparisler[0].IslemNo, "KASA SATIŞI", "NAKİT", "GİREN", tutar, 0);
                db.Masa_Tutar_Guncelle_Database(Convert.ToDouble(txtTutar.Text), id);
                listeHesap.Rows.Clear();

                ListeAnaliz(); 
            }
        }
        private void btnEkle_Click(object sender, EventArgs e)//Sipariş listesinden belirlenen 
        {                                                     //miktar kadar hesap listesine aktarır.
            if (listeSiparisler.RowCount != 0)
            {
                foreach (DataGridViewRow row in listeSiparisler.SelectedRows)
                {
                    object[] rowData = new object[row.Cells.Count];
                    for (int i = 0; i < rowData.Length; i++)
                    {
                        rowData[i] = row.Cells[i].Value;
                    }
                    if (nmrcMiktar.Value == Convert.ToDecimal(row.Cells[1].Value))
                    {
                        listeHesap.Rows.Add(rowData);
                        listeSiparisler.Rows.Remove(row);
                    }
                    else
                    {
                        rowData[1] = nmrcMiktar.Value;
                        decimal b = Convert.ToDecimal(listeSiparisler.CurrentRow.Cells[2].Value);
                        decimal a = Convert.ToDecimal(listeSiparisler.CurrentRow.Cells[1].Value);
                        listeSiparisler.CurrentRow.Cells[2].Value = ((b / a) * (a - nmrcMiktar.Value));
                        rowData[2] = ((b / a) * nmrcMiktar.Value);
                        a -= nmrcMiktar.Value;
                        listeSiparisler.CurrentRow.Cells[1].Value = a;
                        listeHesap.Rows.Add(rowData);
                    }
                }
            }
            ListeAnaliz();
        }
        private void btnCikar_Click(object sender, EventArgs e) //Hesap listesinde seçilmiş ürünleri sipariş listesine geri yollar.
        {
            dt = (DataTable)listeSiparisler.DataSource;
            dt.AcceptChanges();
            if (listeHesap.RowCount != 0)
            {
                foreach (DataGridViewRow row in listeHesap.SelectedRows)
                {
                    bool control = false;
                    object[] rowData = new object[row.Cells.Count];
                    for (int i = 0; i < rowData.Length; ++i)
                    {
                        rowData[i] = row.Cells[i].Value;
                    }
                    double miktar = 0, tutar = 0;
                    for (int i = 0; i < dt.Rows.Count; ++i)
                    {
                        if(dt.Rows[i][0] == rowData[0])
                        {
                            miktar = Convert.ToDouble(dt.Rows[i][1]);
                            miktar += Convert.ToDouble(rowData[1]);
                            tutar = Convert.ToDouble(dt.Rows[i][2]);
                            tutar += Convert.ToDouble(rowData[2]);
                            dt.Rows[i][1] = miktar;
                            dt.Rows[i][2] = tutar;
                            dt.Rows[i].AcceptChanges();
                            control = true;
                        }
                    }
                    if (!control)
                        dt.Rows.Add(rowData);
                    dt.Columns[0].ColumnName = "ÜRÜN";
                    dt.Columns[1].ColumnName = "MİKTAR";
                    dt.Columns[2].ColumnName = "TUTAR";
                    dt.Columns[3].ColumnName = "PERSONEL";
                    listeSiparisler.DataSource = dt;
                    listeHesap.Rows.Remove(row);
                }
            }
            ListeAnaliz();
        }
        private void listeSiparisler_SelectionChanged(object sender, EventArgs e)//Sipariş listesinde seçili satır değiştiğinde miktar ayarlama formuna seçili olan ürünün bilgilerini getirir.
        {
            if(listeSiparisler.RowCount > 0)
                if(listeSiparisler.CurrentRow.Index >= 0)
                {
                    txtUrunAdi.Text = listeSiparisler.CurrentRow.Cells[0].Value.ToString();
                    nmrcMiktar.Value = 1;
                    nmrcMiktar.Maximum = Convert.ToDecimal(listeSiparisler.CurrentRow.Cells[1].Value);//max değer sipariş edilen miktar olarak atanır.
                }
        }
        void ListeAnaliz() //Tutar güncellenir.
        {
            double tutarSiparis = 0, tutarHesap = 0;
            foreach (DataGridViewRow row in listeSiparisler.Rows)
                tutarSiparis += Convert.ToDouble(row.Cells[2].Value);
            foreach (DataGridViewRow row in listeHesap.Rows)
                tutarHesap += Convert.ToDouble(row.Cells[2].Value);
            txtTutar.Text = tutarSiparis.ToString("0.00");
            txtTTutar.Text = tutarHesap.ToString("0.00");
        }

        private void btnHesapKapat_Click(object sender, EventArgs e)//Tüm hesabı kapatır.
        {
            if (listeHesap.RowCount > 0 || listeSiparisler.RowCount > 0)
            {
                db.Masa_Aktiflik_Guncelle_Database(false, id);
                db.Masa_Tutar_Guncelle_Database(0, id);
                List<SiparisDB> siparisler = new List<SiparisDB>();
                SqlDataReader dr = db.Siparis_MasaBilgiGetir_Database(txtMasaAdi.Text);
                while (dr.Read())
                {
                    SiparisDB siparis = new SiparisDB
                    {
                        Id = Convert.ToInt32(dr[0].ToString()),
                        Barkod = dr[3].ToString(),
                        ToplamTutar = Convert.ToDouble(dr[8].ToString()),
                        IslemNo = dr[2].ToString(),
                        Kategori = dr[9].ToString(),
                        MasaAd = dr[1].ToString(),
                        Miktar = Convert.ToDouble(dr[6].ToString()),
                        Personel = dr[10].ToString(),
                        Tarih = Convert.ToDateTime(dr[5].ToString()),
                        UrunAd = dr[4].ToString(),
                        Fiyat = Convert.ToDouble(dr[7].ToString())
                    };
                    siparisler.Add(siparis);
                }
                dr.Close();
                db.baglanti.Close();
                double tutar = 0;
                foreach (SiparisDB item in siparisler)
                {
                    db.Satis_Ekle_Database(item.IslemNo, item.Barkod,
                        item.UrunAd, item.Tarih, item.Miktar, item.ToplamTutar,
                        item.Kategori, item.Personel, item.MasaAd, item.AlisFiyat,
                        item.Fiyat);
                    tutar += item.ToplamTutar;
                    db.Siparis_Sil_Database(item.Id);
                }
                db.Kasa_Ekle_Database("KASA-2", DataBase.kullanici, DateTime.Now,
                    siparisler[0].IslemNo, "KASA SATIŞI", "NAKİT", "GİREN", tutar, 0); 
            }
            this.Close();
        }
    }
    /* EKLE
     if (listeSiparisler.RowCount != 0)
            {
                foreach (DataGridViewRow row in listeSiparisler.SelectedRows)
                {
                    object[] rowData = new object[row.Cells.Count];
                    for (int i = 0; i < rowData.Length; i++)
                    {
                        rowData[i] = row.Cells[i].Value;
                    }
                    if (nmrcMiktar.Value == Convert.ToDecimal(row.Cells[1].Value))
                    {
                        listeHesap.Rows.Add(rowData);
                        listeSiparisler.Rows.Remove(row);
                    }
                    else
                    {
                        rowData[1] = nmrcMiktar.Value;
                        decimal b = Convert.ToDecimal(listeSiparisler.CurrentRow.Cells[2].Value);
                        decimal a = Convert.ToDecimal(listeSiparisler.CurrentRow.Cells[1].Value);
                        listeSiparisler.CurrentRow.Cells[2].Value = ((b / a) * (a - nmrcMiktar.Value));
                        rowData[2] = ((b / a) * nmrcMiktar.Value);
                        a -= nmrcMiktar.Value;
                        listeSiparisler.CurrentRow.Cells[1].Value = a;
                        listeHesap.Rows.Add(rowData);
                    }
                }
            }
     */
    /* ÇIKAR
     if (listeHesap.RowCount != 0)
            {
                foreach (DataGridViewRow row in listeHesap.SelectedRows)
                {
                    bool control = false;
                    object[] rowData = new object[row.Cells.Count];
                    for (int i = 0; i < rowData.Length; i++)
                    {
                        rowData[i] = row.Cells[i].Value;
                    }
                    double miktar = 0, tutar = 0;
                    for (int i = 0; i < listeSiparisler.RowCount; i++)
                    {
                        if(listeSiparisler.Rows[i].Cells[0].Value == rowData[0])
                        {
                            miktar = Convert.ToDouble(listeSiparisler.Rows[i].Cells[1].Value);
                            miktar += Convert.ToDouble(rowData[1]);
                            tutar = Convert.ToDouble(listeSiparisler.Rows[i].Cells[2].Value);
                            tutar += Convert.ToDouble(rowData[2]);
                            dt.Rows[i][1] = miktar;
                            dt.Rows[i][2] = tutar;
                            dt.Rows[i].AcceptChanges();
                            control = true;
                        }
                    }
                    if (!control)
                        dt.Rows.Add(rowData);
                    dt.Columns[0].ColumnName = "ÜRÜN";
                    dt.Columns[1].ColumnName = "MİKTAR";
                    dt.Columns[2].ColumnName = "TUTAR";
                    dt.Columns[3].ColumnName = "PERSONEL";
                    listeSiparisler.DataSource = dt;
                    listeHesap.Rows.Remove(row);
                }
            }
     */
}
