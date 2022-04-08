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
    public partial class FrmStokSec : Form
    {
        DataBase db = new DataBase();
        DataTable dt = new DataTable();
        public string urunAdi;
        public static string barkod; 
        public FrmStokSec()
        {
            InitializeComponent();
        }

        private void txtBarkod_Enter(object sender, EventArgs e)
        {
            txtArama.Text = "";
            txtArama.Font = new Font("Tahoma", 9.75F,
                FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
        }

        private void txtBarkod_TextChanged(object sender, EventArgs e)// comboAramaOlcut'da seçili olan ölçüte göre 
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
        private void FrmStokSec_Load(object sender, EventArgs e) // ürünlerin hepsini getiriyoruz.
        {
            if (db.baglanti.State == ConnectionState.Closed)
                db.baglanti.Open();
            dt = new DataTable();
            using (SqlDataAdapter da = new SqlDataAdapter("SELECT BARCODE, PRODUCT_NAME, CATEGORY, STOCK, UNIT, PURCHASE_PRICE, SALE_PRICE, DESCRIPTION FROM PRODUCT_TBL", db.baglanti))
            {
                da.Fill(dt);
            }
            db.baglanti.Close();
            for (int i = 0; i < dt.Columns.Count; i++)
                dt.Columns[i].ColumnName = listeDeneme.Columns[i].HeaderText;
            listeUrun.DataSource = dt;
        }
        private void btnSec_Click(object sender, EventArgs e)
        {
            if (listeUrun.RowCount > 0)
            {
                barkod = listeUrun.CurrentRow.Cells[0].Value.ToString();
                urunAdi = listeUrun.CurrentRow.Cells[1].Value.ToString();
                this.Close();
            }
            else
                MessageBox.Show("Listede Ürün Bulunmamaktadır!!!", "REMIT-PRO",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
