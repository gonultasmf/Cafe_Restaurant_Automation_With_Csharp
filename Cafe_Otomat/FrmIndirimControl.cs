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
    public partial class FrmIndirimControl : Form
    {
        public FrmIndirimControl()
        {
            InitializeComponent();
        }

        private void btnKaydet_Click(object sender, EventArgs e) //FrmStokIslemleri'nde global olarak
                                                                 //tanımladığımız değişkenlere bu değerleri atadık
        {
            FrmStokIslemleri.iControl = chckIndirim.Checked;
            FrmStokIslemleri.iBaslangic = dateBaslangic.Value.Date;
            FrmStokIslemleri.iBitis = dateBitis.Value.Date;
        }

        private void FrmIndirimControl_Load(object sender, EventArgs e)
        {
            chckIndirim.Checked = FrmStokIslemleri.iControl;
            dateBaslangic.Value = FrmStokIslemleri.iBaslangic;
            dateBitis.Value = FrmStokIslemleri.iBitis;
        }
    }
}
