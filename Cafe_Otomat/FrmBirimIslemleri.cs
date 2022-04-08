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
    public partial class FrmBirimIslemleri : Form
    {
        DataBase db = new DataBase();
        DataTable dt = new DataTable();
        public FrmBirimIslemleri()
        {
            InitializeComponent();
        }
        private void FrmBirimIslemleri_Load(object sender, EventArgs e)
        {
            ListeDoldur();
        }
        void ListeDoldur() // listeBirimi doldurur...
        {
            if (db.baglanti.State == ConnectionState.Closed)
                db.baglanti.Open();
            dt = new DataTable();
            using (SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM UNIT_TBL", db.baglanti))
            {
                da.Fill(dt);
            }
            db.baglanti.Close();
            listeBirim.DataSource = dt;
        }
        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (txtBirim.TextLength.Equals(0))
                MessageBox.Show("Birim Adı Boş Bırakılamaz!!!", "REMIT-PRO",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                bool control = false;
                SqlDataReader dr = db.Birim_Bilgi_Getir_Database();// DB'den UNIT_TBL tablosunun içerisindeki verileri dr değişkenine atadık.
                while (dr.Read())
                {
                    if (dr[1].ToString()==(txtBirim.Text)) // veritabanında daha önceden bu birim eklenmiş mi diye kontrol ediyoruz.
                    {
                        MessageBox.Show("Eklemek İstediğiniz Birim Zaten Bulunmaktadır...", "REMIT-PRO",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        control = true;
                        break;
                    }
                }
                dr.Close();
                db.baglanti.Close();
                if (!control) // veritabanında daha önceden bu birim eklenmemişse birimi ekliyoruz.
                {
                    db.Birim_Ekle_Database(txtBirim.Text);
                    ListeDoldur();
                    txtBirim.ResetText();
                }
                dr.Close();
                db.baglanti.Close();
            }
        }
        private void btnSil_Click(object sender, EventArgs e)
        {
            if (listeBirim.Rows.Count.Equals(0)) // birim var mı diye kontrol ettik
                MessageBox.Show("Birim Bulunmamaktadır!!!", "REMIT-PRO",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                if(MessageBox.Show("Seçili Birimi SİLMEK İstediğinizden Emin misiniz?", "REMIT-PRO",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    db.Birim_Sil_Database(Convert.ToInt32(listeBirim.CurrentRow.Cells[0].Value.ToString())); // birimi sildik.
                    ListeDoldur();
                }
            }
        }
        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtBirim_TextChanged(object sender, EventArgs e)
        {
            txtBirim.Text = txtBirim.Text.ToUpper();
        }
    }
}
