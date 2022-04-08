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
    public partial class FrmStokEkle : Form
    {
        DataBase db = new DataBase();
        string barkod;
        public FrmStokEkle(string barcode)
        {
            barkod = barcode;
            InitializeComponent();
        }

        private void FrmStokEkle_Load(object sender, EventArgs e)
        {
            SqlDataReader dataReader = db.Urun_Bilgi_Getir_Database(barkod);
            while (dataReader.Read())
            {
                txtUrunAdi.Text = dataReader[2].ToString();
                txtMevcutMiktar.Text = dataReader[5].ToString();
            }
            dataReader.Close();
            db.baglanti.Close();
        }
        private void btnIptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnEkle_Click(object sender, EventArgs e) // veritabanında sadece
                                                               // miktar değişikliği olacağı için değişkenler
                                                               // üretip atadık ve sonrasında ise değerleri aynı
                                                               // şekilde güncelleyerek sadece miktar değişikliği
                                                               // yaptırmış olduk.
        {
            string a="";
            string b="";
            string c="";
            double h=0;
            double i=0;
            double j=0;
            double k=0;
            bool l=false;
            string d="";
            string f="";
            DateTime m=DateTime.Now;
            DateTime n = DateTime.Now;
            string g="";
            int o=0;
            SqlDataReader dataReader = db.Urun_Bilgi_Getir_Database(barkod);
            while (dataReader.Read())
            {
                a = dataReader[2].ToString();
                b = dataReader[3].ToString();
                c = dataReader[4].ToString();
                h = Convert.ToDouble(dataReader[5].ToString()) + Convert.ToDouble(nmrcMiktar.Value);
                i = Convert.ToDouble(dataReader[6].ToString());
                j = Convert.ToDouble(dataReader[7].ToString());
                k = Convert.ToDouble(dataReader[8].ToString());
                l = Convert.ToBoolean(dataReader[9].ToString());
                d = dataReader[10].ToString();
                f = dataReader[11].ToString();
                m = Convert.ToDateTime(dataReader[13].ToString());
                n = Convert.ToDateTime(dataReader[14].ToString());
                g = dataReader[15].ToString();
                o = Convert.ToInt32(dataReader[0].ToString());
            }
            dataReader.Close();
            db.baglanti.Close();
            db.Urun_Guncelle_Database(barkod, a,
                    b, c,h,i, j, k, l, d, f, m, n, g, o);
            this.Close();
        }
    }
}
