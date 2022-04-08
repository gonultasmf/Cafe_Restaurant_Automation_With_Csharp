using Microsoft.Office.Interop.Excel;
using System;
using System.Collections;
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
    public partial class FrmSatisRapor : Form
    {
        DataBase db = new DataBase();
        System.Data.DataTable dt = new System.Data.DataTable();
        public FrmSatisRapor()
        {
            InitializeComponent();
        }
        private void btnListeGoruntule_Click(object sender, EventArgs e)
        {
            ListeDoldur(0);
            listeAnaliz(listeSatisAyrinti);
        }
        private void btnListeGoruntule1_Click(object sender, EventArgs e)
        {
            ListeDoldur(1);
            listeAnaliz(listeSatisAyrinti_1);
        }
        private void btnListeGoruntule2_Click(object sender, EventArgs e)
        {
            if (txtUrun.TextLength.Equals(0))
                MessageBox.Show("Lütfen Ürün Seçiniz!!!!", "REMIT-PRO",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                ListeDoldur(2);
                listeAnaliz(listeSatisAyrinti_2);
            }
        }
        void ListeDoldur(int listeIndex) // fonksiyon içerisine aldığımız parametreye bağlı olarak SqlDataAdapter'e 
        { //belirlenen koşullarla DB'deki SELL_TBL tablosundan verileri çekip DataTable'a atıp listeye gönderiyoruz.
            if (listeIndex == 0)
            {
                DateTime tarihB = new DateTime(dateBaslangic.Value.Year,
                    dateBaslangic.Value.Month, dateBaslangic.Value.Day, 0, 0, 0);
                DateTime tarihS = new DateTime(dateBitis.Value.Year, 
                    dateBitis.Value.Month, dateBitis.Value.Day, 23, 59, 59);
                SqlDataAdapter da = new SqlDataAdapter("SELECT SELL_DATE, OPERATION_NO," +
                    " PRODUCT_NAME, BARCODE, CATEGORY, AMOUNT, TOTAL_PRICE, EMPLOYEE FROM" +
                    " SELL_TBL WHERE SELL_DATE BETWEEN @bTarihi AND @sTarihi", db.baglanti);
                da.SelectCommand.Parameters.Add("@bTarihi", tarihB);
                da.SelectCommand.Parameters.Add("@sTarihi", tarihS);
                dt = new System.Data.DataTable();
                da.Fill(dt);
                for (int i = 0; i < dt.Columns.Count; i++)
                    dt.Columns[i].ColumnName = listeDeneme.Columns[i].HeaderText;
                listeSatisAyrinti.DataSource = dt;
                db.baglanti.Close();
            }
            else if(listeIndex == 1)
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT SELL_DATE, OPERATION_NO, " +
                    "PRODUCT_NAME, BARCODE, CATEGORY, AMOUNT, TOTAL_PRICE, EMPLOYEE FROM " +
                    "SELL_TBL WHERE CONVERT(VARCHAR,CATEGORY)=@kategori", db.baglanti);
                da.SelectCommand.Parameters.Add("@kategori", comboKategori.Text);
                dt = new System.Data.DataTable();
                da.Fill(dt);
                for (int i = 0; i < dt.Columns.Count; i++)
                    dt.Columns[i].ColumnName = listeDeneme.Columns[i].HeaderText;
                listeSatisAyrinti_1.DataSource = dt;
                db.baglanti.Close();
            }
            else if(listeIndex == 2)
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT SELL_DATE, OPERATION_NO, PRODUCT_NAME, BARCODE, CATEGORY, AMOUNT, TOTAL_PRICE, EMPLOYEE FROM SELL_TBL WHERE CONVERT(VARCHAR,PRODUCT_NAME)=@urun", db.baglanti);
                da.SelectCommand.Parameters.Add("@urun", txtUrun.Text);
                dt = new System.Data.DataTable();
                da.Fill(dt);
                for (int i = 0; i < dt.Columns.Count; i++)
                    dt.Columns[i].ColumnName = listeDeneme.Columns[i].HeaderText;
                listeSatisAyrinti_2.DataSource = dt;
                db.baglanti.Close();
            }
        }
        void listeAnaliz(DataGridView list) // listede herhangibir değişiklik olduğunda açık olan listenin 
                                            // içerisinde dolaşıp analiz yapıyor.
        {
            double miktar = 0, satis = 0;
            for (int i = 0; i < list.Rows.Count; i++)
            {
                miktar += Convert.ToDouble(list.Rows[i].Cells[5].Value);
                satis += Convert.ToDouble(list.Rows[i].Cells[6].Value);
            }
            if (tabControl1.SelectedIndex.Equals(0)) // hangi sayfa açıksa o listedeki textboxları değiştirdik.
            {
                txtTSatisTutar_1.Text = satis.ToString("0.00") + " ₺";
                txtTSatisMiktari_1.Text = miktar.ToString();
                txtTKayitSayisi_1.Text = list.Rows.Count.ToString();
            }
            else if (tabControl1.SelectedIndex.Equals(1))
            {
                txtTSatisTutar_2.Text = satis.ToString("0.00") + " ₺";
                txtTSatisMiktari_2.Text = miktar.ToString();
                txtTKayitSayisi_2.Text = list.Rows.Count.ToString();
            }
            else if (tabControl1.SelectedIndex.Equals(2))
            {
                txtTSatisTutar_3.Text = satis.ToString("0.00") + " ₺";
                txtTSatisMiktari_3.Text = miktar.ToString();
                txtTKayitSayisi_3.Text = list.Rows.Count.ToString();
            }
        }
        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void FrmSatisRapor_Load(object sender, EventArgs e)
        {
            
            listeAnaliz(listeSatisAyrinti);
            comboKategori.Items.Clear();
            SqlDataReader dr = db.Kategori_Bilgi_Getir_Database();
            while (dr.Read())
            {
                comboKategori.Items.Add(dr[1].ToString());
                comboKategori1.Items.Add(dr[1].ToString());
            }
            dr.Close();
            db.baglanti.Close();
            aciklama.SetToolTip(btnExcel, "Listeyi Excel'e Aktar..."); // birinci parametrede belirtilen nesnenin üzerine
                                                                       // gelince ikinci parametreyi balon içerisinde gösterir.
            aciklama.SetToolTip(btnExcel1, "Listeyi Excel'e Aktar...");
            aciklama.SetToolTip(btnExcel2, "Listeyi Excel'e Aktar...");
            aciklama.SetToolTip(btnKapat, "KAPAT!!!");
            aciklama.SetToolTip(btnKapat1, "KAPAT!!!");
            aciklama.SetToolTip(btnKapat2, "KAPAT!!!");
            comboGrafikOlcut.SelectedIndex = 0;
            comboKategori.SelectedIndex = 0;
            comboKategori1.SelectedIndex = 0;
            comboTarihOlcut.SelectedIndex = 0;
        }
        private void btnSec_Click(object sender, EventArgs e)
        {
            FrmStokSec stokSec = new FrmStokSec();
            stokSec.ShowDialog();
            txtUrun.Text = stokSec.urunAdi;
        }
        private void btnExcel_Click(object sender, EventArgs e)
        {
            FrmYukleniyor yukleniyor = new FrmYukleniyor(listeSatisAyrinti);
            yukleniyor.ShowDialog();
        }
        private void btnExcel1_Click(object sender, EventArgs e)
        {
            FrmYukleniyor yukleniyor = new FrmYukleniyor(listeSatisAyrinti_1);
            yukleniyor.ShowDialog();
        }
        private void btnExcel2_Click(object sender, EventArgs e)
        {
            FrmYukleniyor yukleniyor = new FrmYukleniyor(listeSatisAyrinti_2);
            yukleniyor.ShowDialog();
        }
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            //function.ListeYazdır(sender, e, listeSatisAyrinti, Properties.Languages.S0047);
        }
        private void btnYazdir_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    List<SystemDB> list = db.Info_System_Database();
            //    PrintPreviewDialog onizleme = new PrintPreviewDialog();
            //    onizleme.Document = printDocument1;
            //    printDialog1.PrinterSettings.PrinterName = FrmYaziciAyarlari.yazici;
            //    onizleme.ShowDialog(); 
            //}
            //catch (Exception exc)
            //{
            //    MessageBox.Show(exc.Message, "REMIT-PRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }
        private void printDocument2_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            //function.ListeYazdır(sender, e, listeSatisAyrinti_1, Properties.Languages.S0047);
        }
        private void btnYazdir1_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    List<SystemDB> list = db.Info_System_Database();
            //    PrintPreviewDialog onizleme = new PrintPreviewDialog();
            //    onizleme.Document = printDocument2;
            //    printDialog2.PrinterSettings.PrinterName = FrmYaziciAyarlari.yazici;
            //    onizleme.ShowDialog();
            //}
            //catch (Exception exc)
            //{
            //    MessageBox.Show(exc.Message, "REMIT-PRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }
        private void printDocument3_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            //function.ListeYazdır(sender, e, listeSatisAyrinti_2, Properties.Languages.S0047);
        }
        private void btnYazdir2_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    List<SystemDB> list = db.Info_System_Database();
            //    PrintPreviewDialog onizleme = new PrintPreviewDialog();
            //    onizleme.Document = printDocument3;
            //    printDialog3.PrinterSettings.PrinterName = FrmYaziciAyarlari.yazici;
            //    onizleme.ShowDialog();
            //}
            //catch (Exception exc)
            //{
            //    MessageBox.Show(exc.Message, "REMIT-PRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }
        public void GrafikControl() // tablo oluşumunu yapan fonksiyon
        {
            SqlDataReader dr = db.Sell_Bilgi_Database();
            double kar1 = 0, kar2 = 0, kar3 = 0, kar4 = 0, kar5 = 0, kar6 = 0, kar7 = 0, kar8 = 0, kar9 = 0, kar10 = 0, kar11 = 0, kar12 = 0;
            double sat1 = 0, sat2 = 0, sat3 = 0, sat4 = 0, sat5 = 0, sat6 = 0, sat7 = 0, sat8 = 0, sat9 = 0, sat10 = 0, sat11 = 0, sat12 = 0;
            double al1 = 0, al2 = 0, al3 = 0, al4 = 0, al5 = 0, al6 = 0, al7 = 0, al8 = 0, al9 = 0, al10 = 0, al11 = 0, al12 = 0;
            if(comboGrafikOlcut.SelectedIndex == 0) // SELL_TBL içerisindeki son 24 saatte yapılan satışları
                                                    // iki saat periyotla tablo grafiğine yerleştiriyor.
            {
                grfkSatis.Series[0].Points.Clear();
                grfkSatis.Series[1].Points.Clear();
                grfkSatis.Series[2].Points.Clear();
                grfkSatis.Titles[0].Text = "SATIŞ KAR GRAFİĞİ (SAATLİK)";
                while (dr.Read())
                {
                    if (Convert.ToDateTime(dr["SELL_DATE"].ToString()) >= DateTime.Now.AddHours(-2) && Convert.ToDateTime(dr["SELL_DATE"].ToString()) <= DateTime.Now)
                    {
                        sat1 += (Convert.ToDouble((dr["PRICE"].ToString())) * Convert.ToDouble((dr["AMOUNT"].ToString())));
                        al1 += (Convert.ToDouble((dr["PURCHASE_PRICE"].ToString())) * Convert.ToDouble((dr["AMOUNT"].ToString())));
                        kar1 = (sat1 - al1);
                    }
                    else if (Convert.ToDateTime(dr["SELL_DATE"].ToString()) <= DateTime.Now.AddHours(-2) && Convert.ToDateTime(dr["SELL_DATE"].ToString()) >= DateTime.Now.AddHours(-4))
                    {
                        sat2 += (Convert.ToDouble((dr["PRICE"].ToString())) * Convert.ToDouble((dr["AMOUNT"].ToString())));
                        al2 += (Convert.ToDouble((dr["PURCHASE_PRICE"].ToString())) * Convert.ToDouble((dr["AMOUNT"].ToString())));
                        kar2 = (sat2 - al2);
                    }
                    else if (Convert.ToDateTime(dr["SELL_DATE"].ToString()) <= DateTime.Now.AddHours(-4) && Convert.ToDateTime(dr["SELL_DATE"].ToString()) >= DateTime.Now.AddHours(-6))
                    {
                        sat3 += (Convert.ToDouble((dr["PRICE"].ToString())) * Convert.ToDouble((dr["AMOUNT"].ToString())));
                        al3 += (Convert.ToDouble((dr["PURCHASE_PRICE"].ToString())) * Convert.ToDouble((dr["AMOUNT"].ToString())));
                        kar3 = (sat3 - al3);
                    }
                    else if (Convert.ToDateTime(dr["SELL_DATE"].ToString()) <= DateTime.Now.AddHours(-6) && Convert.ToDateTime(dr["SELL_DATE"].ToString()) >= DateTime.Now.AddHours(-8))
                    {
                        sat4 += (Convert.ToDouble((dr["PRICE"].ToString())) * Convert.ToDouble((dr["AMOUNT"].ToString())));
                        al4 += (Convert.ToDouble((dr["PURCHASE_PRICE"].ToString())) * Convert.ToDouble((dr["AMOUNT"].ToString())));
                        kar4 = (sat4 - al4);
                    }
                    else if (Convert.ToDateTime(dr["SELL_DATE"].ToString()) <= DateTime.Now.AddHours(-8) && Convert.ToDateTime(dr["SELL_DATE"].ToString()) >= DateTime.Now.AddHours(-10))
                    {
                        sat5 += (Convert.ToDouble((dr["PRICE"].ToString())) * Convert.ToDouble((dr["AMOUNT"].ToString())));
                        al5 += (Convert.ToDouble((dr["PURCHASE_PRICE"].ToString())) * Convert.ToDouble((dr["AMOUNT"].ToString())));
                        kar5 = (sat5 - al5);
                    }
                    else if (Convert.ToDateTime(dr["SELL_DATE"].ToString()) <= DateTime.Now.AddHours(-10) && Convert.ToDateTime(dr["SELL_DATE"].ToString()) >= DateTime.Now.AddHours(-12))
                    {
                        sat6 += (Convert.ToDouble((dr["PRICE"].ToString())) * Convert.ToDouble((dr["AMOUNT"].ToString())));
                        al6 += (Convert.ToDouble((dr["PURCHASE_PRICE"].ToString())) * Convert.ToDouble((dr["AMOUNT"].ToString())));
                        kar6 = (sat6 - al6);
                    }
                    else if (Convert.ToDateTime(dr["SELL_DATE"].ToString()) <= DateTime.Now.AddHours(-12) && Convert.ToDateTime(dr["SELL_DATE"].ToString()) >= DateTime.Now.AddHours(-14))
                    {
                        sat7 += (Convert.ToDouble((dr["PRICE"].ToString())) * Convert.ToDouble((dr["AMOUNT"].ToString())));
                        al7 += (Convert.ToDouble((dr["PURCHASE_PRICE"].ToString())) * Convert.ToDouble((dr["AMOUNT"].ToString())));
                        kar7 = (sat7 - al7);
                    }
                    else if (Convert.ToDateTime(dr["SELL_DATE"].ToString()) <= DateTime.Now.AddHours(-14) && Convert.ToDateTime(dr["SELL_DATE"].ToString()) >= DateTime.Now.AddHours(-16))
                    {
                        sat8 += (Convert.ToDouble((dr["PRICE"].ToString())) * Convert.ToDouble((dr["AMOUNT"].ToString())));
                        al8 += (Convert.ToDouble((dr["PURCHASE_PRICE"].ToString())) * Convert.ToDouble((dr["AMOUNT"].ToString())));
                        kar8 = (sat8 - al8);
                    }
                    else if (Convert.ToDateTime(dr["SELL_DATE"].ToString()) <= DateTime.Now.AddHours(-16) && Convert.ToDateTime(dr["SELL_DATE"].ToString()) >= DateTime.Now.AddHours(-18))
                    {
                        sat9 += (Convert.ToDouble((dr["PRICE"].ToString())) * Convert.ToDouble((dr["AMOUNT"].ToString())));
                        al9 += (Convert.ToDouble((dr["PURCHASE_PRICE"].ToString())) * Convert.ToDouble((dr["AMOUNT"].ToString())));
                        kar9 = (sat9 - al9);
                    }
                    else if (Convert.ToDateTime(dr["SELL_DATE"].ToString()) <= DateTime.Now.AddHours(-18) && Convert.ToDateTime(dr["SELL_DATE"].ToString()) >= DateTime.Now.AddHours(-20))
                    {
                        sat10 += (Convert.ToDouble((dr["PRICE"].ToString())) * Convert.ToDouble((dr["AMOUNT"].ToString())));
                        al10 += (Convert.ToDouble((dr["PURCHASE_PRICE"].ToString())) * Convert.ToDouble((dr["AMOUNT"].ToString())));
                        kar10 = (sat10 - al10);
                    }
                    else if (Convert.ToDateTime(dr["SELL_DATE"].ToString()) <= DateTime.Now.AddHours(-20) && Convert.ToDateTime(dr["SELL_DATE"].ToString()) >= DateTime.Now.AddHours(-22))
                    {
                        sat11 += (Convert.ToDouble((dr["PRICE"].ToString())) * Convert.ToDouble((dr["AMOUNT"].ToString())));
                        al11 += (Convert.ToDouble((dr["PURCHASE_PRICE"].ToString())) * Convert.ToDouble((dr["AMOUNT"].ToString())));
                        kar11 = (sat11 - al11);
                    }
                    else if (Convert.ToDateTime(dr["SELL_DATE"].ToString()) <= DateTime.Now.AddHours(-22) && Convert.ToDateTime(dr["SELL_DATE"].ToString()) >= DateTime.Now.AddHours(-24))
                    {
                        sat12 += (Convert.ToDouble((dr["PRICE"].ToString())) * Convert.ToDouble((dr["AMOUNT"].ToString())));
                        al12 += (Convert.ToDouble((dr["PURCHASE_PRICE"].ToString())) * Convert.ToDouble((dr["AMOUNT"].ToString())));
                        kar12 = (sat12 - al12);
                    }
                }
                dr.Close();
                db.baglanti.Close();
                grfkSatis.Series[0].Points.AddXY(DateTime.Now.AddHours(-22).ToString("HH:mm"), kar12);
                grfkSatis.Series[0].Points.AddXY(DateTime.Now.AddHours(-20).ToString("HH:mm"), kar11);
                grfkSatis.Series[0].Points.AddXY(DateTime.Now.AddHours(-18).ToString("HH:mm"), kar10);
                grfkSatis.Series[0].Points.AddXY(DateTime.Now.AddHours(-16).ToString("HH:mm"), kar9);
                grfkSatis.Series[0].Points.AddXY(DateTime.Now.AddHours(-14).ToString("HH:mm"), kar8);
                grfkSatis.Series[0].Points.AddXY(DateTime.Now.AddHours(-12).ToString("HH:mm"), kar7);
                grfkSatis.Series[0].Points.AddXY(DateTime.Now.AddHours(-10).ToString("HH:mm"), kar6);
                grfkSatis.Series[0].Points.AddXY(DateTime.Now.AddHours(-8).ToString("HH:mm"), kar5);
                grfkSatis.Series[0].Points.AddXY(DateTime.Now.AddHours(-6).ToString("HH:mm"), kar4);
                grfkSatis.Series[0].Points.AddXY(DateTime.Now.AddHours(-4).ToString("HH:mm"), kar3);
                grfkSatis.Series[0].Points.AddXY(DateTime.Now.AddHours(-2).ToString("HH:mm"), kar2);
                grfkSatis.Series[0].Points.AddXY(DateTime.Now.ToString("HH:mm"), kar1);
                grfkSatis.Series[1].Points.AddXY(DateTime.Now.AddHours(-22).ToString("HH:mm"), sat12);
                grfkSatis.Series[1].Points.AddXY(DateTime.Now.AddHours(-20).ToString("HH:mm"), sat11);
                grfkSatis.Series[1].Points.AddXY(DateTime.Now.AddHours(-18).ToString("HH:mm"), sat10);
                grfkSatis.Series[1].Points.AddXY(DateTime.Now.AddHours(-16).ToString("HH:mm"), sat9);
                grfkSatis.Series[1].Points.AddXY(DateTime.Now.AddHours(-14).ToString("HH:mm"), sat8);
                grfkSatis.Series[1].Points.AddXY(DateTime.Now.AddHours(-12).ToString("HH:mm"), sat7);
                grfkSatis.Series[1].Points.AddXY(DateTime.Now.AddHours(-10).ToString("HH:mm"), sat6);
                grfkSatis.Series[1].Points.AddXY(DateTime.Now.AddHours(-8).ToString("HH:mm"), sat5);
                grfkSatis.Series[1].Points.AddXY(DateTime.Now.AddHours(-6).ToString("HH:mm"), sat4);
                grfkSatis.Series[1].Points.AddXY(DateTime.Now.AddHours(-4).ToString("HH:mm"), sat3);
                grfkSatis.Series[1].Points.AddXY(DateTime.Now.AddHours(-2).ToString("HH:mm"), sat2);
                grfkSatis.Series[1].Points.AddXY(DateTime.Now.ToString("HH:mmM"), sat1);
                grfkSatis.Series[2].Points.AddXY(DateTime.Now.AddHours(-22).ToString("HH:mm"), al12);
                grfkSatis.Series[2].Points.AddXY(DateTime.Now.AddHours(-20).ToString("HH:mm"), al11);
                grfkSatis.Series[2].Points.AddXY(DateTime.Now.AddHours(-18).ToString("HH:mm"), al10);
                grfkSatis.Series[2].Points.AddXY(DateTime.Now.AddHours(-16).ToString("HH:mm"), al9);
                grfkSatis.Series[2].Points.AddXY(DateTime.Now.AddHours(-14).ToString("HH:mm"), al8);
                grfkSatis.Series[2].Points.AddXY(DateTime.Now.AddHours(-12).ToString("HH:mm"), al7);
                grfkSatis.Series[2].Points.AddXY(DateTime.Now.AddHours(-10).ToString("HH:mm"), al6);
                grfkSatis.Series[2].Points.AddXY(DateTime.Now.AddHours(-8).ToString("HH:mm"), al5);
                grfkSatis.Series[2].Points.AddXY(DateTime.Now.AddHours(-6).ToString("HH:mm"), al4);
                grfkSatis.Series[2].Points.AddXY(DateTime.Now.AddHours(-4).ToString("HH:mm"), al3);
                grfkSatis.Series[2].Points.AddXY(DateTime.Now.AddHours(-2).ToString("HH:mm"), al2);
                grfkSatis.Series[2].Points.AddXY(DateTime.Now.ToString("HH:mm"), al1);
            }
            else if (comboGrafikOlcut.SelectedIndex == 1)// SELL_TBL içerisindeki son bir haftada yapılan satışları
                                                         // bir günlük periyotla tablo grafiğine yerleştiriyor.
            {
                grfkSatis.Series[0].Points.Clear();
                grfkSatis.Series[2].Points.Clear();
                grfkSatis.Series[1].Points.Clear();
                grfkSatis.Titles[0].Text = "SATIŞ KAR GRAFİĞİ (GÜNLÜK)";
                while (dr.Read())
                {
                    if (Convert.ToDateTime(dr["SELL_DATE"].ToString()).ToString("dddd/MM/yyyy") == DateTime.Now.Date.ToString("dddd/MM/yyyy"))
                    {
                        sat1 += (Convert.ToDouble((dr["PRICE"].ToString()))) * Convert.ToDouble((dr["AMOUNT"].ToString()));
                        al1 += (Convert.ToDouble((dr["PURCHASE_PRICE"].ToString())) * Convert.ToDouble((dr["AMOUNT"].ToString())));
                        kar1 = (sat1 - al1);
                    }
                    else if (Convert.ToDateTime(dr["SELL_DATE"].ToString()).ToString("dddd/MM/yyyy") == DateTime.Now.Date.AddDays(-1).ToString("dddd/MM/yyyy"))
                    {
                        sat2 += (Convert.ToDouble((dr["PRICE"].ToString())) * Convert.ToDouble((dr["AMOUNT"].ToString())));
                        al2 += (Convert.ToDouble((dr["PURCHASE_PRICE"].ToString())) * Convert.ToDouble((dr["AMOUNT"].ToString())));
                        kar2 = (sat2 - al2);
                    }
                    else if (Convert.ToDateTime(dr["SELL_DATE"].ToString()).ToString("dddd/MM/yyyy") == DateTime.Now.Date.AddDays(-2).ToString("dddd/MM/yyyy"))
                    {
                        sat3 += (Convert.ToDouble((dr["PRICE"].ToString())) * Convert.ToDouble((dr["AMOUNT"].ToString())));
                        al3 += (Convert.ToDouble((dr["PURCHASE_PRICE"].ToString())) * Convert.ToDouble((dr["AMOUNT"].ToString())));
                        kar3 = (sat3 - al3);
                    }
                    else if (Convert.ToDateTime(dr["SELL_DATE"].ToString()).ToString("dddd/MM/yyyy") == DateTime.Now.Date.AddDays(-3).ToString("dddd/MM/yyyy"))
                    {
                        sat4 += (Convert.ToDouble((dr["PRICE"].ToString())) * Convert.ToDouble((dr["AMOUNT"].ToString())));
                        al4 += (Convert.ToDouble((dr["PURCHASE_PRICE"].ToString())) * Convert.ToDouble((dr["AMOUNT"].ToString())));
                        kar4 = (sat4 - al4);
                    }
                    else if (Convert.ToDateTime(dr["SELL_DATE"].ToString()).ToString("dddd/MM/yyyy") == DateTime.Now.Date.AddDays(-4).ToString("dddd/MM/yyyy"))
                    {
                        sat5 += (Convert.ToDouble((dr["PRICE"].ToString())) * Convert.ToDouble((dr["AMOUNT"].ToString())));
                        al5 += (Convert.ToDouble((dr["PURCHASE_PRICE"].ToString())) * Convert.ToDouble((dr["AMOUNT"].ToString())));
                        kar5 = (sat5 - al5);
                    }
                    else if (Convert.ToDateTime(dr["SELL_DATE"].ToString()).ToString("dddd/MM/yyyy") == DateTime.Now.Date.AddDays(-5).ToString("dddd/MM/yyyy"))
                    {
                        sat6 += (Convert.ToDouble((dr["PRICE"].ToString())) * Convert.ToDouble((dr["AMOUNT"].ToString())));
                        al6 += (Convert.ToDouble((dr["PURCHASE_PRICE"].ToString())) * Convert.ToDouble((dr["AMOUNT"].ToString())));
                        kar6 = (sat6 - al6);
                    }
                    else if (Convert.ToDateTime(dr["SELL_DATE"].ToString()).ToString("dddd/MM/yyyy") == DateTime.Now.Date.AddDays(-6).ToString("dddd/MM/yyyy"))
                    {
                        sat7 += (Convert.ToDouble((dr["PRICE"].ToString())) * Convert.ToDouble((dr["AMOUNT"].ToString())));
                        al7 += (Convert.ToDouble((dr["PURCHASE_PRICE"].ToString())) * Convert.ToDouble((dr["AMOUNT"].ToString())));
                        kar7 = (sat7 - al7);
                    }
                }
                dr.Close();
                db.baglanti.Close();
                grfkSatis.Series[0].Points.AddXY(DateTime.Now.Date.AddDays(-6).ToString("dddd"), kar7);
                grfkSatis.Series[0].Points.AddXY(DateTime.Now.Date.AddDays(-5).ToString("dddd"), kar6);
                grfkSatis.Series[0].Points.AddXY(DateTime.Now.Date.AddDays(-4).ToString("dddd"), kar5);
                grfkSatis.Series[0].Points.AddXY(DateTime.Now.Date.AddDays(-3).ToString("dddd"), kar4);
                grfkSatis.Series[0].Points.AddXY(DateTime.Now.Date.AddDays(-2).ToString("dddd"), kar3);
                grfkSatis.Series[0].Points.AddXY(DateTime.Now.Date.AddDays(-1).ToString("dddd"), kar2);
                grfkSatis.Series[0].Points.AddXY(DateTime.Now.Date.ToString("dddd"), kar1);
                grfkSatis.Series[1].Points.AddXY(DateTime.Now.Date.AddDays(-6).ToString("dddd"), sat7);
                grfkSatis.Series[1].Points.AddXY(DateTime.Now.Date.AddDays(-5).ToString("dddd"), sat6);
                grfkSatis.Series[1].Points.AddXY(DateTime.Now.Date.AddDays(-4).ToString("dddd"), sat5);
                grfkSatis.Series[1].Points.AddXY(DateTime.Now.Date.AddDays(-3).ToString("dddd"), sat4);
                grfkSatis.Series[1].Points.AddXY(DateTime.Now.Date.AddDays(-2).ToString("dddd"), sat3);
                grfkSatis.Series[1].Points.AddXY(DateTime.Now.Date.AddDays(-1).ToString("dddd"), sat2);
                grfkSatis.Series[1].Points.AddXY(DateTime.Now.Date.ToString("dddd"), sat1);
                grfkSatis.Series[2].Points.AddXY(DateTime.Now.Date.AddDays(-6).ToString("dddd"), al7);
                grfkSatis.Series[2].Points.AddXY(DateTime.Now.Date.AddDays(-5).ToString("dddd"), al6);
                grfkSatis.Series[2].Points.AddXY(DateTime.Now.Date.AddDays(-4).ToString("dddd"), al5);
                grfkSatis.Series[2].Points.AddXY(DateTime.Now.Date.AddDays(-3).ToString("dddd"), al4);
                grfkSatis.Series[2].Points.AddXY(DateTime.Now.Date.AddDays(-2).ToString("dddd"), al3);
                grfkSatis.Series[2].Points.AddXY(DateTime.Now.Date.AddDays(-1).ToString("dddd"), al2);
                grfkSatis.Series[2].Points.AddXY(DateTime.Now.Date.ToString("dddd"), al1);
            }
            else if (comboGrafikOlcut.SelectedIndex == 2)// SELL_TBL içerisindeki son bir yılda yapılan satışları
                                                         // aylık periyotlarla tablo grafiğine yerleştiriyor.
            {
                grfkSatis.Series[0].Points.Clear();
                grfkSatis.Series[1].Points.Clear();
                grfkSatis.Series[2].Points.Clear();
                grfkSatis.Titles[0].Text = "SATIŞ KAR GRAFİĞİ (AYLIK)";
                while (dr.Read())
                {
                    if (Convert.ToDateTime(dr["SELL_DATE"].ToString()) >= DateTime.Now.Date.AddMonths(-1) && Convert.ToDateTime(dr["SELL_DATE"].ToString()) <= DateTime.Now.Date)
                    {
                        sat1 += (Convert.ToDouble((dr["PRICE"].ToString())) * Convert.ToDouble((dr["AMOUNT"].ToString())));
                        al1 += (Convert.ToDouble((dr["PURCHASE_PRICE"].ToString())) * Convert.ToDouble((dr["AMOUNT"].ToString())));
                        kar1 = (sat1 - al1);
                    }
                    else if (Convert.ToDateTime(dr["SELL_DATE"].ToString()) <= DateTime.Now.Date.AddMonths(-1) && Convert.ToDateTime(dr["SELL_DATE"].ToString()) >= DateTime.Now.Date.AddMonths(-2))
                    {
                        sat2 += (Convert.ToDouble((dr["PRICE"].ToString())) * Convert.ToDouble((dr["AMOUNT"].ToString())));
                        al2 += (Convert.ToDouble((dr["PURCHASE_PRICE"].ToString())) * Convert.ToDouble((dr["AMOUNT"].ToString())));
                        kar2 = (sat2 - al2);
                    }
                    else if (Convert.ToDateTime(dr["SELL_DATE"].ToString()) <= DateTime.Now.Date.AddMonths(-2) && Convert.ToDateTime(dr["SELL_DATE"].ToString()) >= DateTime.Now.Date.AddMonths(-3))
                    {
                        sat3 += (Convert.ToDouble((dr["PRICE"].ToString())) * Convert.ToDouble((dr["AMOUNT"].ToString())));
                        al3 += (Convert.ToDouble((dr["PURCHASE_PRICE"].ToString())) * Convert.ToDouble((dr["AMOUNT"].ToString())));
                        kar3 = (sat3 - al3);
                    }
                    else if (Convert.ToDateTime(dr["SELL_DATE"].ToString()) <= DateTime.Now.Date.AddMonths(-3) && Convert.ToDateTime(dr["SELL_DATE"].ToString()) >= DateTime.Now.Date.AddMonths(-4))
                    {
                        sat4 += (Convert.ToDouble((dr["PRICE"].ToString())) * Convert.ToDouble((dr["AMOUNT"].ToString())));
                        al4 += (Convert.ToDouble((dr["PURCHASE_PRICE"].ToString())) * Convert.ToDouble((dr["AMOUNT"].ToString())));
                        kar4 = (sat4 - al4);
                    }
                    else if (Convert.ToDateTime(dr["SELL_DATE"].ToString()) <= DateTime.Now.Date.AddMonths(-4) && Convert.ToDateTime(dr["SELL_DATE"].ToString()) >= DateTime.Now.Date.AddMonths(-5))
                    {
                        sat5 += (Convert.ToDouble((dr["PRICE"].ToString())) * Convert.ToDouble((dr["AMOUNT"].ToString())));
                        al5 += (Convert.ToDouble((dr["PURCHASE_PRICE"].ToString())) * Convert.ToDouble((dr["AMOUNT"].ToString())));
                        kar5 = (sat5 - al5);
                    }
                    else if (Convert.ToDateTime(dr["SELL_DATE"].ToString()) <= DateTime.Now.Date.AddMonths(-5) && Convert.ToDateTime(dr["SELL_DATE"].ToString()) >= DateTime.Now.Date.AddMonths(-6))
                    {
                        sat6 += (Convert.ToDouble((dr["PRICE"].ToString())) * Convert.ToDouble((dr["AMOUNT"].ToString())));
                        al6 += (Convert.ToDouble((dr["PURCHASE_PRICE"].ToString())) * Convert.ToDouble((dr["AMOUNT"].ToString())));
                        kar6 = (sat6 - al6);
                    }
                    else if (Convert.ToDateTime(dr["SELL_DATE"].ToString()) <= DateTime.Now.Date.AddMonths(-6) && Convert.ToDateTime(dr["SELL_DATE"].ToString()) >= DateTime.Now.Date.AddMonths(-7))
                    {
                        sat7 += (Convert.ToDouble((dr["PRICE"].ToString())) * Convert.ToDouble((dr["AMOUNT"].ToString())));
                        al7 += (Convert.ToDouble((dr["PURCHASE_PRICE"].ToString())) * Convert.ToDouble((dr["AMOUNT"].ToString())));
                        kar7 = (sat7 - al7);
                    }
                    else if (Convert.ToDateTime(dr["SELL_DATE"].ToString()) <= DateTime.Now.Date.AddMonths(-7) && Convert.ToDateTime(dr["SELL_DATE"].ToString()) >= DateTime.Now.Date.AddMonths(-8))
                    {
                        sat8 += (Convert.ToDouble((dr["PRICE"].ToString())) * Convert.ToDouble((dr["AMOUNT"].ToString())));
                        al8 += (Convert.ToDouble((dr["PURCHASE_PRICE"].ToString())) * Convert.ToDouble((dr["AMOUNT"].ToString())));
                        kar8 = (sat8 - al8);
                    }
                    else if (Convert.ToDateTime(dr["SELL_DATE"].ToString()) <= DateTime.Now.Date.AddMonths(-8) && Convert.ToDateTime(dr["SELL_DATE"].ToString()) >= DateTime.Now.Date.AddMonths(-9))
                    {
                        sat9 += (Convert.ToDouble((dr["PRICE"].ToString())) * Convert.ToDouble((dr["AMOUNT"].ToString())));
                        al9 += (Convert.ToDouble((dr["PURCHASE_PRICE"].ToString())) * Convert.ToDouble((dr["AMOUNT"].ToString())));
                        kar9 = (sat9 - al9);
                    }
                    else if (Convert.ToDateTime(dr["SELL_DATE"].ToString()) <= DateTime.Now.Date.AddMonths(-9) && Convert.ToDateTime(dr["SELL_DATE"].ToString()) >= DateTime.Now.Date.AddMonths(-10))
                    {
                        sat10 += (Convert.ToDouble((dr["PRICE"].ToString())) * Convert.ToDouble((dr["AMOUNT"].ToString())));
                        al10 += (Convert.ToDouble((dr["PURCHASE_PRICE"].ToString())) * Convert.ToDouble((dr["AMOUNT"].ToString())));
                        kar10 = (sat10 - al10);
                    }
                    else if (Convert.ToDateTime(dr["SELL_DATE"].ToString()) <= DateTime.Now.Date.AddMonths(-10) && Convert.ToDateTime(dr["SELL_DATE"].ToString()) >= DateTime.Now.Date.AddMonths(-11))
                    {
                        sat11 += (Convert.ToDouble((dr["PRICE"].ToString())) * Convert.ToDouble((dr["AMOUNT"].ToString())));
                        al11 += (Convert.ToDouble((dr["PURCHASE_PRICE"].ToString())) * Convert.ToDouble((dr["AMOUNT"].ToString())));
                        kar11 = (sat11 - al11);
                    }
                    else if (Convert.ToDateTime(dr["SELL_DATE"].ToString()) <= DateTime.Now.Date.AddMonths(-11) && Convert.ToDateTime(dr["SELL_DATE"].ToString()) >= DateTime.Now.Date.AddMonths(-12))
                    {
                        sat12 += (Convert.ToDouble((dr["PRICE"].ToString())) * Convert.ToDouble((dr["AMOUNT"].ToString())));
                        al12 += (Convert.ToDouble((dr["PURCHASE_PRICE"].ToString())) * Convert.ToDouble((dr["AMOUNT"].ToString())));
                        kar12 = (sat12 - al12);
                    }
                }
                dr.Close();
                db.baglanti.Close();
                grfkSatis.Series[0].Points.AddXY(DateTime.Now.Date.AddMonths(-11).ToString("MMMM"), kar12);
                grfkSatis.Series[0].Points.AddXY(DateTime.Now.Date.AddMonths(-10).ToString("MMMM"), kar11);
                grfkSatis.Series[0].Points.AddXY(DateTime.Now.Date.AddMonths(-9).ToString("MMMM"), kar10);
                grfkSatis.Series[0].Points.AddXY(DateTime.Now.Date.AddMonths(-8).ToString("MMMM"), kar9);
                grfkSatis.Series[0].Points.AddXY(DateTime.Now.Date.AddMonths(-7).ToString("MMMM"), kar8);
                grfkSatis.Series[0].Points.AddXY(DateTime.Now.Date.AddMonths(-6).ToString("MMMM"), kar7);
                grfkSatis.Series[0].Points.AddXY(DateTime.Now.Date.AddMonths(-5).ToString("MMMM"), kar6);
                grfkSatis.Series[0].Points.AddXY(DateTime.Now.Date.AddMonths(-4).ToString("MMMM"), kar5);
                grfkSatis.Series[0].Points.AddXY(DateTime.Now.Date.AddMonths(-3).ToString("MMMM"), kar4);
                grfkSatis.Series[0].Points.AddXY(DateTime.Now.Date.AddMonths(-2).ToString("MMMM"), kar3);
                grfkSatis.Series[0].Points.AddXY(DateTime.Now.Date.AddMonths(-1).ToString("MMMM"), kar2);
                grfkSatis.Series[0].Points.AddXY(DateTime.Now.Date.ToString("MMMM"), kar1);
                grfkSatis.Series[1].Points.AddXY(DateTime.Now.Date.AddMonths(-11).ToString("MMMM"), sat12);
                grfkSatis.Series[1].Points.AddXY(DateTime.Now.Date.AddMonths(-10).ToString("MMMM"), sat11);
                grfkSatis.Series[1].Points.AddXY(DateTime.Now.Date.AddMonths(-9).ToString("MMMM"), sat10);
                grfkSatis.Series[1].Points.AddXY(DateTime.Now.Date.AddMonths(-8).ToString("MMMM"), sat9);
                grfkSatis.Series[1].Points.AddXY(DateTime.Now.Date.AddMonths(-7).ToString("MMMM"), sat8);
                grfkSatis.Series[1].Points.AddXY(DateTime.Now.Date.AddMonths(-6).ToString("MMMM"), sat7);
                grfkSatis.Series[1].Points.AddXY(DateTime.Now.Date.AddMonths(-5).ToString("MMMM"), sat6);
                grfkSatis.Series[1].Points.AddXY(DateTime.Now.Date.AddMonths(-4).ToString("MMMM"), sat5);
                grfkSatis.Series[1].Points.AddXY(DateTime.Now.Date.AddMonths(-3).ToString("MMMM"), sat4);
                grfkSatis.Series[1].Points.AddXY(DateTime.Now.Date.AddMonths(-2).ToString("MMMM"), sat3);
                grfkSatis.Series[1].Points.AddXY(DateTime.Now.Date.AddMonths(-1).ToString("MMMM"), sat2);
                grfkSatis.Series[1].Points.AddXY(DateTime.Now.Date.ToString("MMMMM"), sat1);
                grfkSatis.Series[2].Points.AddXY(DateTime.Now.Date.AddMonths(-11).ToString("MMMM"), al12);
                grfkSatis.Series[2].Points.AddXY(DateTime.Now.Date.AddMonths(-10).ToString("MMMM"), al11);
                grfkSatis.Series[2].Points.AddXY(DateTime.Now.Date.AddMonths(-9).ToString("MMMM"), al10);
                grfkSatis.Series[2].Points.AddXY(DateTime.Now.Date.AddMonths(-8).ToString("MMMM"), al9);
                grfkSatis.Series[2].Points.AddXY(DateTime.Now.Date.AddMonths(-7).ToString("MMMM"), al8);
                grfkSatis.Series[2].Points.AddXY(DateTime.Now.Date.AddMonths(-6).ToString("MMMM"), al7);
                grfkSatis.Series[2].Points.AddXY(DateTime.Now.Date.AddMonths(-5).ToString("MMMM"), al6);
                grfkSatis.Series[2].Points.AddXY(DateTime.Now.Date.AddMonths(-4).ToString("MMMM"), al5);
                grfkSatis.Series[2].Points.AddXY(DateTime.Now.Date.AddMonths(-3).ToString("MMMM"), al4);
                grfkSatis.Series[2].Points.AddXY(DateTime.Now.Date.AddMonths(-2).ToString("MMMM"), al3);
                grfkSatis.Series[2].Points.AddXY(DateTime.Now.Date.AddMonths(-1).ToString("MMMM"), al2);
                grfkSatis.Series[2].Points.AddXY(DateTime.Now.Date.ToString("MMMM"), al1);
            }
            else if (comboGrafikOlcut.SelectedIndex == 3)// SELL_TBL içerisindeki son 10 yılda yapılan satışları
                                                         // yıllık periyotlarla tablo grafiğine yerleştiriyor.
            {
                grfkSatis.Series[0].Points.Clear();
                grfkSatis.Series[1].Points.Clear();
                grfkSatis.Series[2].Points.Clear();
                grfkSatis.Titles[0].Text = "SATIŞ KAR GRAFİĞİ (YILLIK)";
                while (dr.Read())
                {
                    if (Convert.ToDateTime(dr["SELL_DATE"].ToString()) >= DateTime.Now.Date.AddYears(-1) && Convert.ToDateTime(dr["SELL_DATE"].ToString()) <= DateTime.Now.Date)
                    {
                        sat1 += (Convert.ToDouble((dr["PRICE"].ToString())) * Convert.ToDouble((dr["AMOUNT"].ToString())));
                        al1 += (Convert.ToDouble((dr["PURCHASE_PRICE"].ToString())) * Convert.ToDouble((dr["AMOUNT"].ToString())));
                        kar1 = (sat1 - al1);
                    }
                    else if (Convert.ToDateTime(dr["SELL_DATE"].ToString()) <= DateTime.Now.Date.AddYears(-1) && Convert.ToDateTime(dr["SELL_DATE"].ToString()) >= DateTime.Now.Date.AddYears(-2))
                    {
                        sat2 += (Convert.ToDouble((dr["PRICE"].ToString())) * Convert.ToDouble((dr["AMOUNT"].ToString())));
                        al2 += (Convert.ToDouble((dr["PURCHASE_PRICE"].ToString())) * Convert.ToDouble((dr["AMOUNT"].ToString())));
                        kar2 = (sat2 - al2);
                    }
                    else if (Convert.ToDateTime(dr["SELL_DATE"].ToString()) <= DateTime.Now.Date.AddYears(-2) && Convert.ToDateTime(dr["SELL_DATE"].ToString()) >= DateTime.Now.Date.AddYears(-3))
                    {
                        sat3 += (Convert.ToDouble((dr["PRICE"].ToString())) * Convert.ToDouble((dr["AMOUNT"].ToString())));
                        al3 += (Convert.ToDouble((dr["PURCHASE_PRICE"].ToString())) * Convert.ToDouble((dr["AMOUNT"].ToString())));
                        kar3 = (sat3 - al3);
                    }
                    else if (Convert.ToDateTime(dr["SELL_DATE"].ToString()) <= DateTime.Now.Date.AddYears(-3) && Convert.ToDateTime(dr["SELL_DATE"].ToString()) >= DateTime.Now.Date.AddYears(-4))
                    {
                        sat4 += (Convert.ToDouble((dr["PRICE"].ToString())) * Convert.ToDouble((dr["AMOUNT"].ToString())));
                        al4 += (Convert.ToDouble((dr["PURCHASE_PRICE"].ToString())) * Convert.ToDouble((dr["AMOUNT"].ToString())));
                        kar4 = (sat4 - al4);
                    }
                    else if (Convert.ToDateTime(dr["SELL_DATE"].ToString()) <= DateTime.Now.Date.AddYears(-4) && Convert.ToDateTime(dr["SELL_DATE"].ToString()) >= DateTime.Now.Date.AddYears(-5))
                    {
                        sat5 += (Convert.ToDouble((dr["PRICE"].ToString())) * Convert.ToDouble((dr["AMOUNT"].ToString())));
                        al5 += (Convert.ToDouble((dr["PURCHASE_PRICE"].ToString())) * Convert.ToDouble((dr["AMOUNT"].ToString())));
                        kar5 = (sat5 - al5);
                    }
                    else if (Convert.ToDateTime(dr["SELL_DATE"].ToString()) <= DateTime.Now.Date.AddYears(-5) && Convert.ToDateTime(dr["SELL_DATE"].ToString()) >= DateTime.Now.Date.AddYears(-6))
                    {
                        sat6 += (Convert.ToDouble((dr["PRICE"].ToString())) * Convert.ToDouble((dr["AMOUNT"].ToString())));
                        al6 += (Convert.ToDouble((dr["PURCHASE_PRICE"].ToString())) * Convert.ToDouble((dr["AMOUNT"].ToString())));
                        kar6 = (sat6 - al6);
                    }
                    else if (Convert.ToDateTime(dr["SELL_DATE"].ToString()) <= DateTime.Now.Date.AddYears(-6) && Convert.ToDateTime(dr["SELL_DATE"].ToString()) >= DateTime.Now.Date.AddYears(-7))
                    {
                        sat7 += (Convert.ToDouble((dr["PRICE"].ToString())) * Convert.ToDouble((dr["AMOUNT"].ToString())));
                        al7 += (Convert.ToDouble((dr["PURCHASE_PRICE"].ToString())) * Convert.ToDouble((dr["AMOUNT"].ToString())));
                        kar7 = (sat7 - al7);
                    }
                    else if (Convert.ToDateTime(dr["SELL_DATE"].ToString()) <= DateTime.Now.Date.AddYears(-7) && Convert.ToDateTime(dr["SELL_DATE"].ToString()) >= DateTime.Now.Date.AddYears(-8))
                    {
                        sat8 += (Convert.ToDouble((dr["PRICE"].ToString())) * Convert.ToDouble((dr["AMOUNT"].ToString())));
                        al8 += (Convert.ToDouble((dr["PURCHASE_PRICE"].ToString())) * Convert.ToDouble((dr["AMOUNT"].ToString())));
                        kar8 = (sat8 - al8);
                    }
                    else if (Convert.ToDateTime(dr["SELL_DATE"].ToString()) <= DateTime.Now.Date.AddYears(-8) && Convert.ToDateTime(dr["SELL_DATE"].ToString()) >= DateTime.Now.Date.AddYears(-9))
                    {
                        sat9 += (Convert.ToDouble((dr["PRICE"].ToString())) * Convert.ToDouble((dr["AMOUNT"].ToString())));
                        al9 += (Convert.ToDouble((dr["PURCHASE_PRICE"].ToString())) * Convert.ToDouble((dr["AMOUNT"].ToString())));
                        kar9 = (sat9 - al9);
                    }
                    else if (Convert.ToDateTime(dr["SELL_DATE"].ToString()) <= DateTime.Now.Date.AddYears(-9) && Convert.ToDateTime(dr["SELL_DATE"].ToString()) >= DateTime.Now.Date.AddYears(-10))
                    {
                        sat10 += (Convert.ToDouble((dr["PRICE"].ToString())) * Convert.ToDouble((dr["AMOUNT"].ToString())));
                        al10 += (Convert.ToDouble((dr["PURCHASE_PRICE"].ToString())) * Convert.ToDouble((dr["AMOUNT"].ToString())));
                        kar10 = (sat10 - al10);
                    }
                }
                dr.Close();
                db.baglanti.Close();
                grfkSatis.Series[0].Points.AddXY(DateTime.Now.Date.AddYears(-9).ToString("yyyy"), kar10);
                grfkSatis.Series[0].Points.AddXY(DateTime.Now.Date.AddYears(-8).ToString("yyyy"), kar9);
                grfkSatis.Series[0].Points.AddXY(DateTime.Now.Date.AddYears(-7).ToString("yyyy"), kar8);
                grfkSatis.Series[0].Points.AddXY(DateTime.Now.Date.AddYears(-6).ToString("yyyy"), kar7);
                grfkSatis.Series[0].Points.AddXY(DateTime.Now.Date.AddYears(-5).ToString("yyyy"), kar6);
                grfkSatis.Series[0].Points.AddXY(DateTime.Now.Date.AddYears(-4).ToString("yyyy"), kar5);
                grfkSatis.Series[0].Points.AddXY(DateTime.Now.Date.AddYears(-3).ToString("yyyy"), kar4);
                grfkSatis.Series[0].Points.AddXY(DateTime.Now.Date.AddYears(-2).ToString("yyyy"), kar3);
                grfkSatis.Series[0].Points.AddXY(DateTime.Now.Date.AddYears(-1).ToString("yyyy"), kar2);
                grfkSatis.Series[0].Points.AddXY(DateTime.Now.Date.ToString("yyyy"), kar1);
                grfkSatis.Series[1].Points.AddXY(DateTime.Now.Date.AddYears(-9).ToString("yyyy"), sat10);
                grfkSatis.Series[1].Points.AddXY(DateTime.Now.Date.AddYears(-8).ToString("yyyy"), sat9);
                grfkSatis.Series[1].Points.AddXY(DateTime.Now.Date.AddYears(-7).ToString("yyyy"), sat8);
                grfkSatis.Series[1].Points.AddXY(DateTime.Now.Date.AddYears(-6).ToString("yyyy"), sat7);
                grfkSatis.Series[1].Points.AddXY(DateTime.Now.Date.AddYears(-5).ToString("yyyy"), sat6);
                grfkSatis.Series[1].Points.AddXY(DateTime.Now.Date.AddYears(-4).ToString("yyyy"), sat5);
                grfkSatis.Series[1].Points.AddXY(DateTime.Now.Date.AddYears(-3).ToString("yyyy"), sat4);
                grfkSatis.Series[1].Points.AddXY(DateTime.Now.Date.AddYears(-2).ToString("yyyy"), sat3);
                grfkSatis.Series[1].Points.AddXY(DateTime.Now.Date.AddYears(-1).ToString("yyyy"), sat2);
                grfkSatis.Series[1].Points.AddXY(DateTime.Now.Date.ToString("yyyy"), sat1);
                grfkSatis.Series[2].Points.AddXY(DateTime.Now.Date.AddYears(-9).ToString("yyyy"), al10);
                grfkSatis.Series[2].Points.AddXY(DateTime.Now.Date.AddYears(-8).ToString("yyyy"), al9);
                grfkSatis.Series[2].Points.AddXY(DateTime.Now.Date.AddYears(-7).ToString("yyyy"), al8);
                grfkSatis.Series[2].Points.AddXY(DateTime.Now.Date.AddYears(-6).ToString("yyyy"), al7);
                grfkSatis.Series[2].Points.AddXY(DateTime.Now.Date.AddYears(-5).ToString("yyyy"), al6);
                grfkSatis.Series[2].Points.AddXY(DateTime.Now.Date.AddYears(-4).ToString("yyyy"), al5);
                grfkSatis.Series[2].Points.AddXY(DateTime.Now.Date.AddYears(-3).ToString("yyyy"), al4);
                grfkSatis.Series[2].Points.AddXY(DateTime.Now.Date.AddYears(-2).ToString("yyyy"), al3);
                grfkSatis.Series[2].Points.AddXY(DateTime.Now.Date.AddYears(-1).ToString("yyyy"), al2);
                grfkSatis.Series[2].Points.AddXY(DateTime.Now.Date.ToString("yyyy"), al1);
            }
        }
        private void comboGrafikOlcut_SelectedIndexChanged(object sender, EventArgs e)
        {
            GrafikControl();
        }
        private void btnKapat3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        void GrafikGetir()
        {
            SqlDataReader dr = db.Sell_Bilgi_Database();
            chart2.Series[0].Points.Clear();
            chart2.Series[1].Points.Clear();
            List<double> listDbl = new List<double>();
            List<string> listStr = new List<string>();
            double tempDbl;
            string tempStr;
            while (dr.Read())
            {
                if (dr["CATEGORY"].ToString() == comboKategori1.Text || comboKategori1.Text == "GENEL")
                {
                    if (comboTarihOlcut.SelectedIndex == 0) // bütün ürünlerin satış ve stok miktarını listeye atadık.
                    {
                        tempDbl = Convert.ToDouble(dr[5].ToString());
                        tempStr = dr[4].ToString();
                        bool control = false;
                        for (int i = 0; i < listStr.Count; i++)
                        {
                            if (tempStr == listStr[i])
                            {
                                listDbl[i] += tempDbl;
                                control = true;
                            }
                        }
                        if (!control)
                        {
                            listDbl.Add(tempDbl);
                            listStr.Add(tempStr);
                        } 
                    }
                    else if(comboTarihOlcut.SelectedIndex == 1)// son bir hafta içerisindeki satılan ürünlerin
                                                               //  belirlenen gündeki satış ve stok miktarını listeye atadık
                    {
                        if (Convert.ToDateTime(dr["SELL_DATE"].ToString()) >= DateTime.Now.AddDays(-6))
                        {
                            if (Convert.ToDateTime(dr["SELL_DATE"].ToString()).ToString("dddd") == comboTarihAyrinti.Text)
                            {
                                tempDbl = Convert.ToDouble(dr[5].ToString());
                                tempStr = dr[4].ToString();
                                bool control = false;
                                for (int i = 0; i < listStr.Count; i++)
                                {
                                    if (tempStr == listStr[i])
                                    {
                                        listDbl[i] += tempDbl;
                                        control = true;
                                    }
                                }
                                if (!control)
                                {
                                    listDbl.Add(tempDbl);
                                    listStr.Add(tempStr);
                                }
                            } 
                        }
                    }
                    else if (comboTarihOlcut.SelectedIndex == 2)// son bir hafta içerisindeki satılan ürünlerin
                                                                // satış ve stok miktarını listeye atadık
                    {
                        if (Convert.ToDateTime(dr["SELL_DATE"].ToString()) >= DateTime.Now.AddDays(-6))
                        {
                            tempDbl = Convert.ToDouble(dr[5].ToString());
                            tempStr = dr[4].ToString();
                            bool control = false;
                            for (int i = 0; i < listStr.Count; i++)
                            {
                                if (tempStr == listStr[i])
                                {
                                    listDbl[i] += tempDbl;
                                    control = true;
                                }
                            }
                            if (!control)
                            {
                                listDbl.Add(tempDbl);
                                listStr.Add(tempStr);
                            }
                        }
                    }
                    else if(comboTarihOlcut.SelectedIndex == 3)// son bir yıl içerisindeki satılan ürünlerin
                                                               //  belirlenen aydaki satış ve stok miktarını listeye atadık
                    {
                        if (Convert.ToDateTime(dr["SELL_DATE"].ToString()).Date.Year == DateTime.Now.Date.Year)
                        {
                            if (Convert.ToDateTime(dr["SELL_DATE"].ToString()).ToString("MMMM") == comboTarihAyrinti.Text)
                            {
                                tempDbl = Convert.ToDouble(dr[5].ToString());
                                tempStr = dr[4].ToString();
                                bool control = false;
                                for (int i = 0; i < listStr.Count; i++)
                                {
                                    if (tempStr == listStr[i])
                                    {
                                        listDbl[i] += tempDbl;
                                        control = true;
                                    }
                                }
                                if (!control)
                                {
                                    listDbl.Add(tempDbl);
                                    listStr.Add(tempStr);
                                }
                            } 
                        }
                    }
                    else if (comboTarihOlcut.SelectedIndex == 4)// son bir yıl içerisindeki satılan ürünlerin
                                                                // satış ve stok miktarını listeye atadık
                    {
                        if (Convert.ToDateTime(dr["SELL_DATE"].ToString()).Date.Year == DateTime.Now.Date.Year)
                        {
                            tempDbl = Convert.ToDouble(dr[5].ToString());
                            tempStr = dr[4].ToString();
                            bool control = false;
                            for (int i = 0; i < listStr.Count; i++)
                            {
                                if (tempStr == listStr[i])
                                {
                                    listDbl[i] += tempDbl;
                                    control = true;
                                }
                            }
                            if (!control)
                            {
                                listDbl.Add(tempDbl);
                                listStr.Add(tempStr);
                            }
                        }
                    }
                }
            }
            dr.Close();
            db.baglanti.Close();
            double miktar = 0;
            chart2.ChartAreas[0].AxisX.Maximum = 1.1;
            for (int i = 0; i < listStr.Count; i++) // liste içerisinde dolaşıp stok miktarını
                                                    // veritabanından çekerek tablo grafiğini oluşturduk.
            {
                dr = db.Urun_Bilgi_Database(listStr[i]);
                while (dr.Read())
                    miktar = Convert.ToDouble(dr["STOCK"].ToString());
                dr.Close();
                db.baglanti.Close();
                chart2.Series[0].Points.AddXY(listStr[i], listDbl[i]);
                chart2.Series[1].Points.AddXY(listStr[i], miktar);
                chart2.Series[0].Points[i].ToolTip = listDbl[i].ToString();//Tablo da mouse ile züerine gelinen column1un miktarını baloncuk içersinde ekrsana verir.
                chart2.Series[1].Points[i].ToolTip = miktar.ToString();
                chart2.ChartAreas[0].AxisX.Maximum++;
            }
           
        }
        private void comboTarihOlcut_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboTarihOlcut.SelectedIndex == 0) // comboTarihAyrinti ve label16'yı görünmez yaptık.
            {
                comboTarihAyrinti.Visible = false;
                label16.Visible = false;
            }
            else if (comboTarihOlcut.SelectedIndex == 1) // comboTarihOlcut'te günlük seçili ise
                                                         // comboTarihAyrinti itemslerini değiştirdik.
            {
                comboTarihAyrinti.Items.Clear();
                comboTarihAyrinti.Items.AddRange(new object[] {
                "Pazartesi",
                "Salı",
                "Çarşamba",
                "Perşembe",
                "Cuma",
                "Cumartesi",
                "Pazar"
                });
                comboTarihAyrinti.Visible = true;
                label16.Visible = true;
            }
            else if(comboTarihOlcut.SelectedIndex == 2)
            {
                comboTarihAyrinti.Visible = false;
                label16.Visible = false;
            }
            else if(comboTarihOlcut.SelectedIndex == 3)// comboTarihOlcut'te aylık seçili ise
                                                       // comboTarihAyrinti itemslerini değiştirdik.
            {
                comboTarihAyrinti.Items.Clear();
                comboTarihAyrinti.Items.AddRange(new object[] {
                "Ocak",
                "Şubat",
                "Mart",
                "Nisan",
                "Mayıs",
                "Haziran",
                "Temmuz",
                "Ağustos",
                "Eylül",
                "Ekim",
                "Kasım",
                "Aralık"
                });
                comboTarihAyrinti.Visible = true;
                label16.Visible = true;
            }
            else if(comboTarihOlcut.SelectedIndex == 4)
            {
                comboTarihAyrinti.Visible = false;
                label16.Visible = false;
            }
            comboTarihAyrinti.SelectedIndex = 0;
        }
        private void btnRaporla_Click(object sender, EventArgs e)
        {
            GrafikGetir();
        }
    }
}
