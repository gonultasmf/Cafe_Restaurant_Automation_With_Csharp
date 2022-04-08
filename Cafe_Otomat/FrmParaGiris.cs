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
    public partial class FrmParaGiris : Form
    {
        DataBase db = new DataBase();
        static double fiyat = 0.00;
        public FrmParaGiris()
        {
            InitializeComponent();
        }
        public string FisIslemNo_Uret()// veritabanından işlem numaralarını kontrol
                                       // ederek farklı bir işlem numarası üreten fonksiyon
        {
            SqlDataReader dr = db.Safe_Bilgi_Database();
            Random random = new Random();
            string sayi = random.Next(100000, 999999).ToString() +
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
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void FrmParaGiris_Load(object sender, EventArgs e)
        {
        }
        private void btnIslemNoVer_Click(object sender, EventArgs e)
        {
           
            txtIslemNo.Text = FisIslemNo_Uret();
        }
        private void btnEkle_Click(object sender, EventArgs e)// kasaya işlem ekliyoruz.
        {
            if (txtIslemNo.TextLength.Equals(0) || txtGirenMiktar.TextLength.Equals(0))
                MessageBox.Show("İşlem Numarası Boş Bırakılamaz!!!", "REMIT-PRO",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                if (comboAciklama.SelectedIndex == 0)
                {
                    db.Kasa_Ekle_Database("KASA-1", DataBase.kullanici, DateTime.Now,
                        txtIslemNo.Text, comboAciklama.Text, "NAKİT", "GİREN", 
                        Convert.ToDouble(txtGirenMiktar.Text), 0);
                }
                else if (comboAciklama.SelectedIndex == 1)
                {
                    db.Kasa_Ekle_Database("KASA-1", DataBase.kullanici, DateTime.Now,
                        txtIslemNo.Text, comboAciklama.Text, "POS", "GİREN",
                        Convert.ToDouble(txtGirenMiktar.Text), 0);
                }
                else
                {
                    db.Kasa_Ekle_Database("KASA-1", DataBase.kullanici, DateTime.Now,
                        txtIslemNo.Text, comboAciklama.Text, "NAKİT", "GİREN",
                        Convert.ToDouble(txtGirenMiktar.Text), 0);
                }
                this.Close();
            }
        }
        private void txtGirenMiktar_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) &&
                e.KeyChar != ',' && e.KeyChar != '.';
        }
        private void txtGirenMiktar_Leave(object sender, EventArgs e)// textboxtan ayrıldığında bişey yazmıyorsa 0 yazıyor otomatik
        {
            fiyat = Convert.ToDouble(txtGirenMiktar.TextLength == 0 ? "0" : txtGirenMiktar.Text);
            fiyat = Convert.ToDouble(fiyat.ToString("0.00"));
        }
    }
}
