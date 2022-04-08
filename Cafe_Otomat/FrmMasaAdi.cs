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
    public partial class FrmMasaAdi : Form
    {
        DataBase db = new DataBase();
        public static string masaAdi;
        int id;
        public FrmMasaAdi(string masaAd)
        {
            masaAdi = masaAd;
            InitializeComponent();
        }
        private void YeniMasa_Load(object sender, EventArgs e)
        {
            SqlDataReader dr = db.Table_Bilgi_Database();
            while (dr.Read())
            {
                if (dr[1].ToString() == masaAdi)
                    id = Convert.ToInt32(dr[0].ToString());
            }
            dr.Close();
            db.baglanti.Close();
            txtMasaAd.Text = masaAdi;
        }

        private void btnKaydet_Click(object sender, EventArgs e) // Masa adı güncellendi
        {
            if(txtMasaAd.TextLength != 0)
            {
                db.Masa_Adi_Guncelle_Database(txtMasaAd.Text, id);
                masaAdi = txtMasaAd.Text;
                this.Close();
            }
            else
            {
                MessageBox.Show("Masa Adı Boş Bırakılamaz!!!", "HATA",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtMasaAd_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                btnKaydet_Click(null, null);
            }
        }

        private void txtMasaAd_KeyPress(object sender, KeyPressEventArgs e) // textbox içerisine , . ' gibi karakterlerin girilmesini engelledik.
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) &&
                e.KeyChar == '\'' && e.KeyChar != '.' && e.KeyChar != ',';
        }
    }
}
