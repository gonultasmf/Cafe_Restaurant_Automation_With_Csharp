
namespace Cafe_Otomat
{
    partial class FrmKasaIslemleri
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmKasaIslemleri));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnTarihAra = new System.Windows.Forms.Button();
            this.comboKasa = new System.Windows.Forms.ComboBox();
            this.txtKasaDevirTutar = new System.Windows.Forms.TextBox();
            this.txtArama = new System.Windows.Forms.TextBox();
            this.comboAramaOlcut = new System.Windows.Forms.ComboBox();
            this.comboListeTur = new System.Windows.Forms.ComboBox();
            this.dateSon = new System.Windows.Forms.DateTimePicker();
            this.dateBaslangic = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.listeDeneme = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ACIKLAMA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.listeKasaIslem = new System.Windows.Forms.DataGridView();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.btnParaGiris = new System.Windows.Forms.Button();
            this.btnListeYazdir = new System.Windows.Forms.Button();
            this.btnAyrintiGör = new System.Windows.Forms.Button();
            this.btnKaydiSil = new System.Windows.Forms.Button();
            this.btnParaCikis = new System.Windows.Forms.Button();
            this.btnCikis = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listeDeneme)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listeKasaIslem)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // panel1
            // 
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Controls.Add(this.btnTarihAra);
            this.panel1.Controls.Add(this.comboKasa);
            this.panel1.Controls.Add(this.txtKasaDevirTutar);
            this.panel1.Controls.Add(this.txtArama);
            this.panel1.Controls.Add(this.comboAramaOlcut);
            this.panel1.Controls.Add(this.comboListeTur);
            this.panel1.Controls.Add(this.dateSon);
            this.panel1.Controls.Add(this.dateBaslangic);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.listeDeneme);
            this.panel1.Name = "panel1";
            // 
            // btnTarihAra
            // 
            this.btnTarihAra.Image = global::Cafe_Otomat.Properties.Resources.magnifying_glass__1_;
            resources.ApplyResources(this.btnTarihAra, "btnTarihAra");
            this.btnTarihAra.Name = "btnTarihAra";
            this.btnTarihAra.UseVisualStyleBackColor = true;
            this.btnTarihAra.Click += new System.EventHandler(this.btnTarihAra_Click);
            // 
            // comboKasa
            // 
            this.comboKasa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboKasa.FormattingEnabled = true;
            this.comboKasa.Items.AddRange(new object[] {
            resources.GetString("comboKasa.Items"),
            resources.GetString("comboKasa.Items1")});
            resources.ApplyResources(this.comboKasa, "comboKasa");
            this.comboKasa.Name = "comboKasa";
            this.comboKasa.SelectedIndexChanged += new System.EventHandler(this.comboKasa_SelectedIndexChanged);
            // 
            // txtKasaDevirTutar
            // 
            resources.ApplyResources(this.txtKasaDevirTutar, "txtKasaDevirTutar");
            this.txtKasaDevirTutar.Name = "txtKasaDevirTutar";
            this.txtKasaDevirTutar.ReadOnly = true;
            // 
            // txtArama
            // 
            resources.ApplyResources(this.txtArama, "txtArama");
            this.txtArama.Name = "txtArama";
            this.txtArama.TextChanged += new System.EventHandler(this.txtArama_TextChanged);
            this.txtArama.Enter += new System.EventHandler(this.txtArama_Enter);
            // 
            // comboAramaOlcut
            // 
            this.comboAramaOlcut.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboAramaOlcut.FormattingEnabled = true;
            this.comboAramaOlcut.Items.AddRange(new object[] {
            resources.GetString("comboAramaOlcut.Items"),
            resources.GetString("comboAramaOlcut.Items1")});
            resources.ApplyResources(this.comboAramaOlcut, "comboAramaOlcut");
            this.comboAramaOlcut.Name = "comboAramaOlcut";
            // 
            // comboListeTur
            // 
            this.comboListeTur.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(239)))), ((int)(((byte)(244)))));
            this.comboListeTur.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboListeTur.FormattingEnabled = true;
            this.comboListeTur.Items.AddRange(new object[] {
            resources.GetString("comboListeTur.Items"),
            resources.GetString("comboListeTur.Items1"),
            resources.GetString("comboListeTur.Items2"),
            resources.GetString("comboListeTur.Items3"),
            resources.GetString("comboListeTur.Items4")});
            resources.ApplyResources(this.comboListeTur, "comboListeTur");
            this.comboListeTur.Name = "comboListeTur";
            this.comboListeTur.SelectedIndexChanged += new System.EventHandler(this.comboListeTur_SelectedIndexChanged);
            // 
            // dateSon
            // 
            this.dateSon.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            resources.ApplyResources(this.dateSon, "dateSon");
            this.dateSon.Name = "dateSon";
            // 
            // dateBaslangic
            // 
            this.dateBaslangic.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            resources.ApplyResources(this.dateBaslangic, "dateBaslangic");
            this.dateBaslangic.Name = "dateBaslangic";
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // listeDeneme
            // 
            this.listeDeneme.AllowUserToAddRows = false;
            this.listeDeneme.AllowUserToDeleteRows = false;
            this.listeDeneme.AllowUserToResizeRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.LightGray;
            this.listeDeneme.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.listeDeneme.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.listeDeneme.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(239)))), ((int)(((byte)(244)))));
            this.listeDeneme.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listeDeneme.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.ACIKLAMA,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
            resources.ApplyResources(this.listeDeneme, "listeDeneme");
            this.listeDeneme.Name = "listeDeneme";
            this.listeDeneme.ReadOnly = true;
            this.listeDeneme.RowHeadersVisible = false;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.DodgerBlue;
            this.listeDeneme.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.listeDeneme.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            // 
            // dataGridViewTextBoxColumn1
            // 
            resources.ApplyResources(this.dataGridViewTextBoxColumn1, "dataGridViewTextBoxColumn1");
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            resources.ApplyResources(this.dataGridViewTextBoxColumn2, "dataGridViewTextBoxColumn2");
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            resources.ApplyResources(this.dataGridViewTextBoxColumn3, "dataGridViewTextBoxColumn3");
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            resources.ApplyResources(this.dataGridViewTextBoxColumn4, "dataGridViewTextBoxColumn4");
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            resources.ApplyResources(this.dataGridViewTextBoxColumn5, "dataGridViewTextBoxColumn5");
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // ACIKLAMA
            // 
            resources.ApplyResources(this.ACIKLAMA, "ACIKLAMA");
            this.ACIKLAMA.Name = "ACIKLAMA";
            this.ACIKLAMA.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            resources.ApplyResources(this.dataGridViewTextBoxColumn6, "dataGridViewTextBoxColumn6");
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            resources.ApplyResources(this.dataGridViewTextBoxColumn7, "dataGridViewTextBoxColumn7");
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            resources.ApplyResources(this.dataGridViewTextBoxColumn8, "dataGridViewTextBoxColumn8");
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // panel2
            // 
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.Controls.Add(this.listeKasaIslem);
            this.panel2.Name = "panel2";
            // 
            // listeKasaIslem
            // 
            this.listeKasaIslem.AllowUserToAddRows = false;
            this.listeKasaIslem.AllowUserToDeleteRows = false;
            this.listeKasaIslem.AllowUserToOrderColumns = true;
            this.listeKasaIslem.AllowUserToResizeRows = false;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.LightGray;
            this.listeKasaIslem.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            resources.ApplyResources(this.listeKasaIslem, "listeKasaIslem");
            this.listeKasaIslem.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.listeKasaIslem.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(239)))), ((int)(((byte)(244)))));
            this.listeKasaIslem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listeKasaIslem.Name = "listeKasaIslem";
            this.listeKasaIslem.ReadOnly = true;
            this.listeKasaIslem.RowHeadersVisible = false;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.DodgerBlue;
            this.listeKasaIslem.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.listeKasaIslem.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.listeKasaIslem.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listeKasaIslem_MouseDoubleClick);
            // 
            // printDocument1
            // 
            this.printDocument1.BeginPrint += new System.Drawing.Printing.PrintEventHandler(this.printDocument1_BeginPrint);
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // btnParaGiris
            // 
            resources.ApplyResources(this.btnParaGiris, "btnParaGiris");
            this.btnParaGiris.Image = global::Cafe_Otomat.Properties.Resources.income;
            this.btnParaGiris.Name = "btnParaGiris";
            this.btnParaGiris.UseVisualStyleBackColor = true;
            this.btnParaGiris.Click += new System.EventHandler(this.btnParaGiris_Click);
            // 
            // btnListeYazdir
            // 
            resources.ApplyResources(this.btnListeYazdir, "btnListeYazdir");
            this.btnListeYazdir.Image = global::Cafe_Otomat.Properties.Resources.printer;
            this.btnListeYazdir.Name = "btnListeYazdir";
            this.btnListeYazdir.UseVisualStyleBackColor = true;
            this.btnListeYazdir.Click += new System.EventHandler(this.btnYazdir_Click);
            // 
            // btnAyrintiGör
            // 
            resources.ApplyResources(this.btnAyrintiGör, "btnAyrintiGör");
            this.btnAyrintiGör.Image = global::Cafe_Otomat.Properties.Resources.refinement;
            this.btnAyrintiGör.Name = "btnAyrintiGör";
            this.btnAyrintiGör.UseVisualStyleBackColor = true;
            this.btnAyrintiGör.Click += new System.EventHandler(this.btnAyrintiGör_Click);
            // 
            // btnKaydiSil
            // 
            resources.ApplyResources(this.btnKaydiSil, "btnKaydiSil");
            this.btnKaydiSil.Image = global::Cafe_Otomat.Properties.Resources.delete__1_;
            this.btnKaydiSil.Name = "btnKaydiSil";
            this.btnKaydiSil.UseVisualStyleBackColor = true;
            this.btnKaydiSil.Click += new System.EventHandler(this.btnKaydiSil_Click);
            // 
            // btnParaCikis
            // 
            resources.ApplyResources(this.btnParaCikis, "btnParaCikis");
            this.btnParaCikis.Image = global::Cafe_Otomat.Properties.Resources.outcome;
            this.btnParaCikis.Name = "btnParaCikis";
            this.btnParaCikis.UseVisualStyleBackColor = true;
            this.btnParaCikis.Click += new System.EventHandler(this.btnParaCikis_Click);
            // 
            // btnCikis
            // 
            resources.ApplyResources(this.btnCikis, "btnCikis");
            this.btnCikis.Image = global::Cafe_Otomat.Properties.Resources.arrow;
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.UseVisualStyleBackColor = true;
            this.btnCikis.Click += new System.EventHandler(this.button1_Click);
            // 
            // FrmKasaIslemleri
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(239)))), ((int)(((byte)(244)))));
            this.CancelButton = this.btnCikis;
            this.Controls.Add(this.btnCikis);
            this.Controls.Add(this.btnListeYazdir);
            this.Controls.Add(this.btnAyrintiGör);
            this.Controls.Add(this.btnKaydiSil);
            this.Controls.Add(this.btnParaCikis);
            this.Controls.Add(this.btnParaGiris);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "FrmKasaIslemleri";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmKasaIslemleri_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listeDeneme)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.listeKasaIslem)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox comboKasa;
        private System.Windows.Forms.TextBox txtKasaDevirTutar;
        private System.Windows.Forms.TextBox txtArama;
        private System.Windows.Forms.ComboBox comboAramaOlcut;
        private System.Windows.Forms.ComboBox comboListeTur;
        private System.Windows.Forms.DateTimePicker dateSon;
        private System.Windows.Forms.DateTimePicker dateBaslangic;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnParaGiris;
        private System.Windows.Forms.Button btnParaCikis;
        private System.Windows.Forms.Button btnKaydiSil;
        private System.Windows.Forms.Button btnAyrintiGör;
        private System.Windows.Forms.Button btnListeYazdir;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Windows.Forms.Button btnTarihAra;
        private System.Windows.Forms.DataGridView listeKasaIslem;
        private System.Windows.Forms.DataGridView listeDeneme;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn ACIKLAMA;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.Button btnCikis;
    }
}