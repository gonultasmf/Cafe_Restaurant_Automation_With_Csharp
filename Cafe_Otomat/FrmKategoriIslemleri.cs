using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Cafe_Otomat
{
    public partial class FrmKategoriIslemleri : Form
    {
        DataBase db = new DataBase();
        DataTable dt = new DataTable();
        public FrmKategoriIslemleri()
        {
            InitializeComponent();
        }

        private void FrmKategoriIslemleri_Load(object sender, EventArgs e)
        {
            ListeDoldur();
        }
        void ListeDoldur() // CATEGORY_TBL içerisindeki verileri aldık
        {
            if (db.baglanti.State == ConnectionState.Closed)
                db.baglanti.Open();
            dt = new DataTable();
            using (SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM CATEGORY_TBL", db.baglanti))
            {
                da.Fill(dt);
            }
            db.baglanti.Close();
            listeKategori.DataSource = dt;
        }
        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (txtKategori.TextLength.Equals(0))
                MessageBox.Show("Kategori Adı Boş Bırakılamaz!!!", "REMIT-PRO",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                bool control = false;
                SqlDataReader dr = db.Kategori_Bilgi_Getir_Database();
                while (dr.Read())
                {
                    if (dr[1].ToString() == (txtKategori.Text))// veritabanında daha önceden bu kategori eklenmiş mi diye kontrol ediyoruz.
                    {
                        MessageBox.Show("Eklemek İstediğiniz Kategori Zaten Bulunmaktadır...", "REMIT-PRO",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        control = true;
                        break;
                    }
                }
                dr.Close();
                db.baglanti.Close();
                if (!control) //veritabanında daha önceden bu kategori eklenmemişse kategoriyi ekliyoruz.
                {
                    db.Kategori_Ekle_Database(txtKategori.Text);
                    ListeDoldur();
                    txtKategori.ResetText();
                }
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (listeKategori.RowCount.Equals(0))
                MessageBox.Show("Kategori Bulunmamaktadır!!!", "REMIT-PRO",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                if (MessageBox.Show("Seçili Kategori SİLMEK İstediğinizden Emin misiniz?", "REMIT-PRO",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    db.Kategori_Sil_Database(Convert.ToInt32(listeKategori.CurrentRow.Cells[1].Value.ToString()));
                    ListeDoldur();
                }
            }
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtKategori_TextChanged(object sender, EventArgs e)
        {
            txtKategori.Text = txtKategori.Text.ToUpper();
        }
    }
}
