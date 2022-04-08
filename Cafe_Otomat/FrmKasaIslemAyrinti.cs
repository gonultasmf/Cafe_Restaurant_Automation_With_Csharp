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
    public partial class FrmKasaIslemAyrinti : Form
    {
        private string FisIslemNo;
        DataBase db = new DataBase();
        DataTable dt = new DataTable();
        public FrmKasaIslemAyrinti(string islemNo)
        {
            FisIslemNo = islemNo;
            InitializeComponent();
        }
        private void FrmKasaIslemAyrinti_Load(object sender, EventArgs e) // veritabanından belirlenen işlem
                                                                          // noya göre SELL_TBL tablosundan verileri çektik
        {
            if (db.baglanti.State == ConnectionState.Closed)
                db.baglanti.Open();
            dt = new DataTable();
            using (SqlDataAdapter da = new SqlDataAdapter("SELECT SELL_DATE, OPERATION_NO," +
                " PRODUCT_NAME, BARCODE, CATEGORY, AMOUNT, TOTAL_PRICE, EMPLOYEE FROM SELL_TBL" +
                " WHERE CONVERT(VARCHAR, OPERATION_NO) = "+ FisIslemNo, db.baglanti))
            {
                da.Fill(dt);
            }
            db.baglanti.Close();
            for (int i = 0; i < dt.Columns.Count; i++)
                dt.Columns[i].ColumnName = listeDeneme.Columns[i].HeaderText;
            listeKasaIslemAyrinti.DataSource = dt;
        }
        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
