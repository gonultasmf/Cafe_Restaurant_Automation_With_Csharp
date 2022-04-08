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
    public partial class FrmTedarikciIslemleri : Form
    {
        DataBase db = new DataBase();
        DataTable dt = new DataTable();
        public FrmTedarikciIslemleri()
        {
            InitializeComponent();
        }
        private void FrmTedarikciIslemleri_Load(object sender, EventArgs e)
        {
            ListeDoldur();
        }
        void ListeDoldur()// SUPPLIER_TBL içerisindeki verileri aldık
        {
            if (db.baglanti.State == ConnectionState.Closed)
                db.baglanti.Open();
            dt = new DataTable();
            using (SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM SUPPLIER_TBL", db.baglanti))
            {
                da.Fill(dt);
            }
            db.baglanti.Close();
            listeTedarikci.DataSource = dt;
        }
        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (txtTedarikci.TextLength.Equals(0))
                MessageBox.Show("Tedarikçi Adı Boş Bırakılamaz!!!", "REMIT-PRO",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                
                bool control = false;
                SqlDataReader dr = db.Tedarikci_Bilgi_Getir_Database();
                while (dr.Read())
                {
                    if (dr[1].ToString() == (txtTedarikci.Text))// veritabanında daha önceden bu tedarikçi eklenmiş mi diye kontrol ediyoruz.
                    {
                        MessageBox.Show("Eklemek İstediğiniz Tedarikçi Zaten Bulunmaktadır...", "REMIT-PRO",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        control = true;
                        break;
                    }
                }
                dr.Close();
                db.baglanti.Close();
                if (!control)//veritabanında daha önceden bu tedarikçi eklenmemişse tedarikçiyi ekliyoruz.
                {
                    db.Tedarikci_Ekle_Database(txtTedarikci.Text);
                    ListeDoldur();
                    txtTedarikci.ResetText();
                }
                    
            }
        }
        private void btnSil_Click(object sender, EventArgs e)
        {
            if (listeTedarikci.Rows.Count.Equals(0))
                MessageBox.Show("Tedarikçi Bulunmamaktadır!!!", "REMIT-PRO",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                if (MessageBox.Show("Seçili Tedarikçi SİLMEK İstediğinizden Emin misiniz?", "REMIT-PRO",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    db.Tedarikci_Sil_Database(Convert.ToInt32(listeTedarikci.CurrentRow.Cells[1].Value.ToString()));
                    ListeDoldur();
                }
            }
        }
        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtTedarikci_TextChanged(object sender, EventArgs e)
        {
            txtTedarikci.Text = txtTedarikci.Text.ToUpper();
        }
    }
}
