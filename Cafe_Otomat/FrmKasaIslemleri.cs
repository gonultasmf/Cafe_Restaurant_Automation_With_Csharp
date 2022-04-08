using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cafe_Otomat
{
    public partial class FrmKasaIslemleri : Form
    {
        public static string kasa;
        public static string fis_islemNo;
        DataBase db = new DataBase();
        DataTable dt = new DataTable();
        StringFormat strFormat;
        ArrayList arrColumnLefts = new ArrayList();
        ArrayList arrColumnWidths = new ArrayList();
        int iCellHeight = 0;
        int iTotalWidth = 0;
        int iRow = 0;
        bool bFirstPage = false;
        bool bNewPage = false;
        int iHeaderHeight = 0;
        public FrmKasaIslemleri()
        {
            InitializeComponent();
        }
        //public string ParaBirim()
        //{
        //    List<SystemDB> system = db.Info_System_Database();
        //    if (system[0].ParaBirim.Equals(0))
        //        return " $";
        //    else if (system[0].ParaBirim.Equals(1))
        //        return " €";
        //    else if (system[0].ParaBirim.Equals(2))
        //        return " ₺";
        //    else
        //        return " £";
        //}
        private void FrmKasaIslemleri_Load(object sender, EventArgs e)
        {

            ListeDoldur();
            comboAramaOlcut.SelectedIndex = 0;
            comboKasa.SelectedIndex = 0;
            comboListeTur.SelectedIndex = 0;

        }
        void ListeDoldur() // SqlDataAdapter ile SAFE_TBL tablosundan verileri çektik.
        {
            if (db.baglanti.State == ConnectionState.Closed)
                db.baglanti.Open();
            dt = new DataTable();
            using (SqlDataAdapter da = new SqlDataAdapter("SELECT OPERATION_DATE," +
                " OPERATION_NO, SAFE_NAME, OPERATION_TYPE, PAY_TYPE, DESCRIPTION," +
                " ENTER_PRICE, EXIT_PRICE, EMPLOYEE FROM SAFE_TBL", db.baglanti))
            {
                da.Fill(dt);
            }
            db.baglanti.Close();
            for (int i = 0; i < dt.Columns.Count; i++) // önceden yapmış olduğumuz listeDeneme datagridviewinin
                                                       // HeaderText'lerini datatableda column namelere atadık.
                dt.Columns[i].ColumnName = listeDeneme.Columns[i].HeaderText;
            listeKasaIslem.DataSource = dt;
            double tutar = 0;
            foreach (DataGridViewRow item in listeKasaIslem.Rows)
            {
                tutar += (Convert.ToDouble(item.Cells[6].Value) - Convert.ToDouble(item.Cells[7].Value));
            }
            txtKasaDevirTutar.Text = tutar.ToString("0.00") + " ₺";
        }
        private void btnParaGiris_Click(object sender, EventArgs e)
        {
            kasa = comboKasa.Text;
            FrmParaGiris paraGiris = new FrmParaGiris();
            paraGiris.ShowDialog();
            ListeDoldur();
        }
        private void btnParaCikis_Click(object sender, EventArgs e)
        {
            kasa = comboKasa.Text;
            FrmParaCikis paraCikis = new FrmParaCikis();
            paraCikis.ShowDialog();
            ListeDoldur();
        }
        private void btnKaydiSil_Click(object sender, EventArgs e)
        {
            if(listeKasaIslem.RowCount > 0)
            {
                fis_islemNo = listeKasaIslem.CurrentRow.Cells[2].Value.ToString();
                FrmKayitSil kayitSil = new FrmKayitSil();
                kayitSil.ShowDialog();
                ListeDoldur();
            }
        }
        private void btnAyrintiGör_Click(object sender, EventArgs e)
        {
            //List<SystemDB> lit = db.Info_System_Database();
            //if (db.SerialUret() != lit[0].SerialKey)
            //{
            //    MessageBox.Show(Properties.Languages.S0178, "REMIT-PRO",
            //        MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //}
            //else
            {
                foreach (DataGridViewRow row in listeKasaIslem.SelectedRows)
                {
                    if (row.Cells[0].Value != null)
                    {

                        FrmKasaIslemAyrinti ms = new FrmKasaIslemAyrinti(row.Cells[1].Value.ToString());
                        ms.ShowDialog();
                    }
                }
            }
        }
        private void listeKasaIslem_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            var currentMouseOverRow = listeKasaIslem.HitTest(e.X, e.Y).RowIndex;
            if (currentMouseOverRow >= 0)
            {
                foreach (DataGridViewRow row in listeKasaIslem.SelectedRows)
                {
                    if (row.Cells[0].Value != null)
                    {
                        FrmKasaIslemAyrinti ms = new FrmKasaIslemAyrinti(row.Cells[1].Value.ToString());
                        ms.ShowDialog();
                    }
                }
            }
            else
                MessageBox.Show("Listede Ürün Bulunmamaktadır!!!", "REMIT-PRO",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void comboKasa_SelectedIndexChanged(object sender, EventArgs e) // comboKas'da seçili olan kasaya göre
                                                                                // listede kasaya göre arama yapıp listeyi getiriyor.
        {
            if (comboKasa.SelectedIndex.Equals(0))
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT OPERATION_DATE, OPERATION_NO, SAFE_NAME, OPERATION_TYPE, PAY_TYPE, " +
                    "DESCRIPTION, ENTER_PRICE, EXIT_PRICE,EMPLOYEE FROM SAFE_TBL WHERE CONVERT(VARCHAR, SAFE_NAME) = 'KASA-1' ", db.baglanti);
                dt = new DataTable();
                da.Fill(dt);
            }
            else if (comboKasa.SelectedIndex.Equals(1))
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT OPERATION_DATE, OPERATION_NO, SAFE_NAME, OPERATION_TYPE, PAY_TYPE, " +
                    "DESCRIPTION, ENTER_PRICE, EXIT_PRICE,EMPLOYEE FROM SAFE_TBL WHERE CONVERT(VARCHAR, SAFE_NAME) = 'KASA-2' ", db.baglanti);
                dt = new DataTable();
                da.Fill(dt);
            }
            for (int i = 0; i < dt.Columns.Count; i++)
                dt.Columns[i].ColumnName = listeDeneme.Columns[i].HeaderText;
            listeKasaIslem.DataSource = dt;
            db.baglanti.Close();
        }
        private void txtArama_TextChanged(object sender, EventArgs e)// comboAramaOlcut'da seçili olan ölçüte göre 
                                                                     // listede txtArama.Text'e göre arama yapıp listeyi getiriyor.
        {
            if (comboAramaOlcut.SelectedIndex == 0)
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT OPERATION_DATE, OPERATION_NO, SAFE_NAME, OPERATION_TYPE, PAY_TYPE, DESCRIPTION, ENTER_PRICE, EXIT_PRICE,EMPLOYEE FROM SAFE_TBL WHERE OPERATION_NO LIKE '%" + txtArama.Text + "%'", db.baglanti);
                dt = new DataTable();
                da.Fill(dt);
            }
            else 
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT OPERATION_DATE, OPERATION_NO, SAFE_NAME, OPERATION_TYPE, PAY_TYPE, DESCRIPTION, ENTER_PRICE, EXIT_PRICE,EMPLOYEE FROM SAFE_TBL WHERE DESCRIPTION LIKE '%" + txtArama.Text + "%'", db.baglanti);
                dt = new DataTable();
                da.Fill(dt);
            }
            for (int i = 0; i < dt.Columns.Count; i++)
                dt.Columns[i].ColumnName = listeDeneme.Columns[i].HeaderText;
            listeKasaIslem.DataSource = dt;
            db.baglanti.Close();
        }
        //private void comboListeTur_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    if (comboListeTur.SelectedIndex.Equals(0))
        //        function.Search_Safe(4, listeKasaIslem, "");
        //    else if (comboListeTur.SelectedIndex.Equals(1))
        //        function.Search_Safe(4, listeKasaIslem, Properties.Languages.S0050);
        //    else if (comboListeTur.SelectedIndex.Equals(2))
        //        function.Search_Safe(4, listeKasaIslem, Properties.Languages.S0051);
        //    else if (comboListeTur.SelectedIndex.Equals(3))
        //        function.Search_Safe(2, listeKasaIslem, Properties.Languages.S0079);
        //    else if (comboListeTur.SelectedIndex.Equals(4))
        //        function.Search_Safe(2, listeKasaIslem, "POS");
        //}
        private void txtArama_Enter(object sender, EventArgs e) // txtArama içine girince içini sıfırlıyor
        {
            txtArama.Text = "";
            txtArama.Font = new Font("Tahoma", 9.75F,
                FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
        }
        /*private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            try
            {
                int iLeftMargin = e.MarginBounds.Left;
                int iTopMargin = e.MarginBounds.Top;
                bool bMorePagesToPrint = false;
                int iTmpWidth = 0;
                bFirstPage = true;

                if (bFirstPage)
                {
                    foreach (DataGridViewColumn GridCol in listeKasaIslem.Columns)
                    {
                        iTmpWidth = (int)(Math.Floor((double)((double)GridCol.Width /
                                       (double)iTotalWidth * (double)iTotalWidth *
                                       ((double)e.MarginBounds.Width / (double)iTotalWidth))));

                        iHeaderHeight = (int)(e.Graphics.MeasureString(GridCol.HeaderText,
                                    GridCol.InheritedStyle.Font, iTmpWidth).Height) + 11;


                        arrColumnLefts.Add(iLeftMargin);
                        arrColumnWidths.Add(iTmpWidth);
                        iLeftMargin += iTmpWidth;
                    }
                }

                while (iRow <= listeKasaIslem.Rows.Count - 1)
                {
                    DataGridViewRow GridRow = listeKasaIslem.Rows[iRow];

                    iCellHeight = GridRow.Height + 5;
                    int iCount = 0;

                    if (iTopMargin + iCellHeight >= e.MarginBounds.Height + e.MarginBounds.Top)
                    {
                        bNewPage = true;
                        bFirstPage = false;
                        bMorePagesToPrint = true;
                        break;
                    }
                    else
                    {
                        if (bNewPage)
                        {

                            e.Graphics.DrawString(Properties.Languages.S0058, new Font(listeKasaIslem.Font, FontStyle.Bold),
                                    Brushes.Black, e.MarginBounds.Left, e.MarginBounds.Top -
                                    e.Graphics.MeasureString(Properties.Languages.S0058, new Font(listeKasaIslem.Font,
                                    FontStyle.Bold), e.MarginBounds.Width).Height - 10);

                            String strDate = DateTime.Now.ToLongDateString() + " " + DateTime.Now.ToShortTimeString();

                            e.Graphics.DrawString(strDate, new Font(listeKasaIslem.Font, FontStyle.Bold),
                                    Brushes.Black, e.MarginBounds.Left + (e.MarginBounds.Width -
                                    e.Graphics.MeasureString(strDate, new Font(listeKasaIslem.Font,
                                    FontStyle.Bold), e.MarginBounds.Width).Width), e.MarginBounds.Top -
                                    e.Graphics.MeasureString(Properties.Languages.S0058, new Font(new Font(listeKasaIslem.Font,
                                    FontStyle.Bold), FontStyle.Bold), e.MarginBounds.Width).Height - 10);


                            iTopMargin = e.MarginBounds.Top;
                            foreach (DataGridViewColumn GridCol in listeKasaIslem.Columns)
                            {
                                e.Graphics.FillRectangle(new SolidBrush(Color.LightGray),
                                    new Rectangle((int)arrColumnLefts[iCount], iTopMargin,
                                    (int)arrColumnWidths[iCount], iHeaderHeight));

                                e.Graphics.DrawRectangle(Pens.Black,
                                    new Rectangle((int)arrColumnLefts[iCount], iTopMargin,
                                    (int)arrColumnWidths[iCount], iHeaderHeight));

                                e.Graphics.DrawString(GridCol.HeaderText, GridCol.InheritedStyle.Font,
                                    new SolidBrush(GridCol.InheritedStyle.ForeColor),
                                    new RectangleF((int)arrColumnLefts[iCount], iTopMargin,
                                    (int)arrColumnWidths[iCount], iHeaderHeight), strFormat);
                                iCount++;
                            }
                            bNewPage = false;
                            iTopMargin += iHeaderHeight;
                        }
                        iCount = 0;

                        foreach (DataGridViewCell Cel in GridRow.Cells)
                        {
                            if (Cel.Value != null)
                            {
                                e.Graphics.DrawString(Cel.Value.ToString(), Cel.InheritedStyle.Font,
                                            new SolidBrush(Cel.InheritedStyle.ForeColor),
                                            new RectangleF((int)arrColumnLefts[iCount], (float)iTopMargin,
                                            (int)arrColumnWidths[iCount], (float)iCellHeight), strFormat);
                            }

                            e.Graphics.DrawRectangle(Pens.Black, new Rectangle((int)arrColumnLefts[iCount],
                                    iTopMargin, (int)arrColumnWidths[iCount], iCellHeight));

                            iCount++;
                        }
                    }
                    iRow++;
                    iTopMargin += iCellHeight;
                }


                if (bMorePagesToPrint)
                    e.HasMorePages = true;
                else
                    e.HasMorePages = false;
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "REMIT-PRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }*/
        private void printDocument1_BeginPrint(object sender, PrintEventArgs e)
        {
            //try
            //{
            //    strFormat = new StringFormat();
            //    strFormat.Alignment = StringAlignment.Near;
            //    strFormat.LineAlignment = StringAlignment.Center;
            //    strFormat.Trimming = StringTrimming.EllipsisCharacter;

            //    arrColumnLefts.Clear();
            //    arrColumnWidths.Clear();
            //    iCellHeight = 0;
            //    iRow = 0;
            //    bFirstPage = true;
            //    bNewPage = true;

            //    iTotalWidth = 0;
            //    foreach (DataGridViewColumn dgvGridCol in listeKasaIslem.Columns)
            //    {
            //        iTotalWidth += dgvGridCol.Width;
            //    }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message, "REMIT-PRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }
        private void btnYazdir_Click(object sender, EventArgs e)
        {
            try
            {
                //List<SystemDB> lit = db.Info_System_Database();
                //if (db.SerialUret() != lit[0].SerialKey)
                //{
                //    MessageBox.Show(Properties.Languages.S0178, "REMIT-PRO",
                //        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //}
                //else
                //{
                //    List<SystemDB> list = db.Info_System_Database();
                //    PrintPreviewDialog onizleme = new PrintPreviewDialog();
                //    onizleme.Document = printDocument1;
                //    printDialog1.PrinterSettings.PrinterName = FrmYaziciAyarlari.yazici;
                //    onizleme.ShowDialog();
                //}
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "REMIT-PRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnTarihAra_Click(object sender, EventArgs e) // belirlediğimiz tarihe göre listeden verileri getiriyor.
        {
            try
            {
                DateTime tarihB = new DateTime(dateBaslangic.Value.Year, dateBaslangic.Value.Month, dateBaslangic.Value.Day, 0, 0, 0);
                DateTime tarihS = new DateTime(dateSon.Value.Year, dateSon.Value.Month, dateSon.Value.Day, 23, 59, 59);
                SqlDataAdapter da = new SqlDataAdapter("SELECT OPERATION_DATE, OPERATION_NO, SAFE_NAME, OPERATION_TYPE, PAY_TYPE, " +
                    "DESCRIPTION, ENTER_PRICE, EXIT_PRICE,EMPLOYEE FROM SAFE_TBL WHERE OPERATION_DATE BETWEEN @bTarihi AND @sTarihi", db.baglanti);
                da.SelectCommand.Parameters.Add("@bTarihi", tarihB);
                da.SelectCommand.Parameters.Add("@sTarihi", tarihS);
                dt = new DataTable();
                da.Fill(dt);
                for (int i = 0; i < dt.Columns.Count; i++)
                    dt.Columns[i].ColumnName = listeDeneme.Columns[i].HeaderText;
                listeKasaIslem.DataSource = dt;
                db.baglanti.Close();
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message, "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void comboListeTur_SelectedIndexChanged(object sender, EventArgs e)// comboListeTur'da seçili olan ölçüte göre 
                                                                                   // listede arama yapıp listeyi getiriyor.
        {
            if (comboListeTur.SelectedIndex.Equals(0))
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT OPERATION_DATE, OPERATION_NO, SAFE_NAME, OPERATION_TYPE, PAY_TYPE, DESCRIPTION, ENTER_PRICE, EXIT_PRICE,EMPLOYEE FROM SAFE_TBL", db.baglanti);
                dt = new DataTable();
                da.Fill(dt);
            }
            else if (comboListeTur.SelectedIndex.Equals(1))
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT OPERATION_DATE, OPERATION_NO, SAFE_NAME, OPERATION_TYPE, PAY_TYPE, DESCRIPTION, ENTER_PRICE, EXIT_PRICE,EMPLOYEE FROM SAFE_TBL WHERE CONVERT(VARCHAR, OPERATION_TYPE) = 'GİREN' ", db.baglanti);
                dt = new DataTable();
                da.Fill(dt);
            }
            else if (comboListeTur.SelectedIndex.Equals(2))
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT OPERATION_DATE, OPERATION_NO, SAFE_NAME, OPERATION_TYPE, PAY_TYPE, DESCRIPTION, ENTER_PRICE, EXIT_PRICE,EMPLOYEE FROM SAFE_TBL WHERE CONVERT(VARCHAR, OPERATION_TYPE) = 'ÇIKAN' ", db.baglanti);
                dt = new DataTable();
                da.Fill(dt);
            }
            else if (comboListeTur.SelectedIndex.Equals(3))
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT OPERATION_DATE, OPERATION_NO, SAFE_NAME, OPERATION_TYPE, PAY_TYPE, DESCRIPTION, ENTER_PRICE, EXIT_PRICE,EMPLOYEE FROM SAFE_TBL WHERE CONVERT(VARCHAR, PAY_TYPE) = 'NAKİT' ", db.baglanti);
                dt = new DataTable();
                da.Fill(dt);
            }
            else if (comboListeTur.SelectedIndex.Equals(4))
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT OPERATION_DATE, OPERATION_NO, SAFE_NAME, OPERATION_TYPE, PAY_TYPE, DESCRIPTION, ENTER_PRICE, EXIT_PRICE,EMPLOYEE FROM SAFE_TBL WHERE CONVERT(VARCHAR, PAY_TYPE) = 'POS' ", db.baglanti);
                dt = new DataTable();
                da.Fill(dt);
            }
            for (int i = 0; i < dt.Columns.Count; i++)
                dt.Columns[i].ColumnName = listeDeneme.Columns[i].HeaderText;
            listeKasaIslem.DataSource = dt;
            db.baglanti.Close();
        }
    }
}
