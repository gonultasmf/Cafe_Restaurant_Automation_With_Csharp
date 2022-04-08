using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cafe_Otomat
{
    public partial class FrmKayitSil : Form
    {
        DataBase db = new DataBase();
        public FrmKayitSil()
        {
            InitializeComponent();
        }
        private void FrmKayitSil_Load(object sender, EventArgs e)
        {
        }
        private void btnIptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnKaydıSil_Click(object sender, EventArgs e)
        {
            //if (MessageBox.Show(Properties.Languages.S0073, "REMIT-PRO",
            //    MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            //{
            //    db.Delete_Safe_Database(FrmKasaIslemleri.fis_islemNo);
            //    List<SellDB> list = db.Info_Sells_IslemNo_Database(FrmKasaIslemleri.fis_islemNo);
            //    if(list.Count > 0)
            //        db.Delete_Sell_Database(FrmKasaIslemleri.fis_islemNo);
            //    this.Close();
            //}  
        }
    }
}
