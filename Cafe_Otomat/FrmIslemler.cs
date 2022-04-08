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
    public partial class FrmIslemler : Form
    {
        public FrmIslemler()
        {
            InitializeComponent();
        }

        private void btnKasaIslem_Click(object sender, EventArgs e)
        {
            FrmKasaIslemleri kasaIslemleri = new FrmKasaIslemleri();
            this.Hide();
            kasaIslemleri.ShowDialog();
            this.Close();
        }
        private void btnStokIslem_Click(object sender, EventArgs e)
        {
            FrmStokIslemleri stokIslemleri = new FrmStokIslemleri();
            this.Hide();
            stokIslemleri.ShowDialog();
            this.Close();
        }
    }
}
