using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cafe_Otomat
{
    public partial class FrmYukleniyor : Form
    {
        DataGridView liste;
        public FrmYukleniyor(DataGridView gridView)
        {
            liste = gridView;
            InitializeComponent();
        }

        private void FrmYukleniyor_Load(object sender, EventArgs e)
        {
            
        }
        void Yukle()
        {
            try
            {
                if (MessageBox.Show("Listeyi Excel'Aktarmak İstediğinizden Emin misiniz?", "REMIT-PRO",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();
                    excel.Visible = false;
                    object Missing = Type.Missing;
                    Workbook workbook = excel.Workbooks.Add(Missing);
                    Worksheet sheet1 = (Worksheet)workbook.Sheets[1];
                    SaveFileDialog saveFile = new SaveFileDialog(); // excel dosyasını kaydedicek yeri açıyoruz
                    saveFile.DefaultExt = "xls";
                    saveFile.Filter = "xls files (*.xls)|*.xls|All files (*.*)|*.*"; // açılan sayfada görünecek dosya türlerini belirledik.
                    saveFile.FileName = "backup_SatışRapor_excel.xls";
                    if (saveFile.ShowDialog() == DialogResult.OK) // kaydedilecek yeri seçtiğimizde
                    {
                        workbook.SaveAs(saveFile.FileName, XlFileFormat.xlWorkbookNormal); // kaydediyor.
                    }
                    int StartCol = 1;
                    int StartRow = 1;
                    for (int i = 0; i < liste.Columns.Count; i++)
                    {
                        Range myRange = (Range)sheet1.Cells[StartRow, StartCol + i];
                        myRange.Value2 = liste.Columns[i].HeaderText; // listenin sütün adlarını excel sütünlarına atadık.
                    }
                    StartRow++;
                    prgrsYukleniyor.Maximum = liste.RowCount;
                    for (int i = 0; i < liste.Rows.Count; i++) // değerleri teker teker atadık excele
                    {
                        for (int j = 0; j < liste.Columns.Count; j++)
                        {
                            Range myRange = (Range)sheet1.Cells[StartRow + i, StartCol + j];
                            myRange.Value2 = liste[j, i].Value == null ? "" : liste[j, i].Value;
                            myRange.Select();
                            prgrsYukleniyor.Value = i;
                        }
                    }
                    workbook.Close(true);
                    excel.Quit();
                    MessageBox.Show("Başarılı Olmuştur...", "REMIT-PRO",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                this.Close();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "REMIT-PRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void btnBaslat_Click(object sender, EventArgs e)
        {
            btnBaslat.Enabled = false;
            Yukle();
        }
    }
}
