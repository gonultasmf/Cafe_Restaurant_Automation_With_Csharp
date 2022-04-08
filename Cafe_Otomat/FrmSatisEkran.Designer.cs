
namespace Cafe_Otomat
{
    partial class FrmSatisEkran
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSatisEkran));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.listeSepet = new System.Windows.Forms.DataGridView();
            this.URUN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmAzalt = new System.Windows.Forms.DataGridViewButtonColumn();
            this.MIKTAR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmArtir = new System.Windows.Forms.DataGridViewButtonColumn();
            this.TUTAR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuSepet = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ürünüSilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabMasa = new System.Windows.Forms.TabControl();
            this.tabUrun = new System.Windows.Forms.TabControl();
            this.menuMasa = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.masaHesapKapatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.masaAdıDeğiştirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtSepetAdi = new System.Windows.Forms.TextBox();
            this.txtTTutar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnCikis = new System.Windows.Forms.Button();
            this.btnAyar = new System.Windows.Forms.Button();
            this.btnRapor = new System.Windows.Forms.Button();
            this.btnIslemler = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listeSepet)).BeginInit();
            this.menuSepet.SuspendLayout();
            this.menuMasa.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.btnCikis);
            this.panel1.Controls.Add(this.btnAyar);
            this.panel1.Controls.Add(this.btnRapor);
            this.panel1.Controls.Add(this.btnIslemler);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(95, 526);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.listeSepet);
            this.panel2.Location = new System.Drawing.Point(552, 43);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(291, 430);
            this.panel2.TabIndex = 1;
            // 
            // listeSepet
            // 
            this.listeSepet.AllowUserToAddRows = false;
            this.listeSepet.AllowUserToOrderColumns = true;
            this.listeSepet.AllowUserToResizeRows = false;
            this.listeSepet.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.listeSepet.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(239)))), ((int)(((byte)(244)))));
            this.listeSepet.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.listeSepet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listeSepet.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.URUN,
            this.clmAzalt,
            this.MIKTAR,
            this.clmArtir,
            this.TUTAR});
            this.listeSepet.ContextMenuStrip = this.menuSepet;
            this.listeSepet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listeSepet.Location = new System.Drawing.Point(0, 0);
            this.listeSepet.MultiSelect = false;
            this.listeSepet.Name = "listeSepet";
            this.listeSepet.RowHeadersVisible = false;
            this.listeSepet.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.listeSepet.Size = new System.Drawing.Size(291, 430);
            this.listeSepet.TabIndex = 2;
            this.listeSepet.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.listeSepet_CellContentClick);
            this.listeSepet.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.listeSepet_CellValueChanged);
            // 
            // URUN
            // 
            this.URUN.HeaderText = "ÜRÜN";
            this.URUN.Name = "URUN";
            // 
            // clmAzalt
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.clmAzalt.DefaultCellStyle = dataGridViewCellStyle1;
            this.clmAzalt.HeaderText = "";
            this.clmAzalt.Name = "clmAzalt";
            this.clmAzalt.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.clmAzalt.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.clmAzalt.Text = "-";
            this.clmAzalt.UseColumnTextForButtonValue = true;
            // 
            // MIKTAR
            // 
            this.MIKTAR.HeaderText = "MİKTAR";
            this.MIKTAR.Name = "MIKTAR";
            // 
            // clmArtir
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.clmArtir.DefaultCellStyle = dataGridViewCellStyle2;
            this.clmArtir.HeaderText = "";
            this.clmArtir.Name = "clmArtir";
            this.clmArtir.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.clmArtir.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.clmArtir.Text = "+";
            this.clmArtir.UseColumnTextForButtonValue = true;
            // 
            // TUTAR
            // 
            this.TUTAR.HeaderText = "TUTAR";
            this.TUTAR.Name = "TUTAR";
            // 
            // menuSepet
            // 
            this.menuSepet.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ürünüSilToolStripMenuItem});
            this.menuSepet.Name = "menuSepet";
            this.menuSepet.Size = new System.Drawing.Size(153, 26);
            // 
            // ürünüSilToolStripMenuItem
            // 
            this.ürünüSilToolStripMenuItem.Name = "ürünüSilToolStripMenuItem";
            this.ürünüSilToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.ürünüSilToolStripMenuItem.Text = "Seçili Ürünü Sil";
            this.ürünüSilToolStripMenuItem.Click += new System.EventHandler(this.ürünüSilToolStripMenuItem_Click);
            // 
            // tabMasa
            // 
            this.tabMasa.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabMasa.Location = new System.Drawing.Point(95, 0);
            this.tabMasa.Name = "tabMasa";
            this.tabMasa.SelectedIndex = 0;
            this.tabMasa.Size = new System.Drawing.Size(451, 253);
            this.tabMasa.TabIndex = 3;
            // 
            // tabUrun
            // 
            this.tabUrun.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabUrun.Location = new System.Drawing.Point(95, 259);
            this.tabUrun.Name = "tabUrun";
            this.tabUrun.SelectedIndex = 0;
            this.tabUrun.Size = new System.Drawing.Size(451, 264);
            this.tabUrun.TabIndex = 4;
            // 
            // menuMasa
            // 
            this.menuMasa.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.masaHesapKapatToolStripMenuItem,
            this.masaAdıDeğiştirToolStripMenuItem});
            this.menuMasa.Name = "menuMasa";
            this.menuMasa.Size = new System.Drawing.Size(172, 48);
            // 
            // masaHesapKapatToolStripMenuItem
            // 
            this.masaHesapKapatToolStripMenuItem.Name = "masaHesapKapatToolStripMenuItem";
            this.masaHesapKapatToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.masaHesapKapatToolStripMenuItem.Text = "Masa Hesap Kapat";
            this.masaHesapKapatToolStripMenuItem.Click += new System.EventHandler(this.masaHesapKapatToolStripMenuItem_Click);
            // 
            // masaAdıDeğiştirToolStripMenuItem
            // 
            this.masaAdıDeğiştirToolStripMenuItem.Name = "masaAdıDeğiştirToolStripMenuItem";
            this.masaAdıDeğiştirToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.masaAdıDeğiştirToolStripMenuItem.Text = "Masa Adı Değiştir";
            this.masaAdıDeğiştirToolStripMenuItem.Click += new System.EventHandler(this.masaAdıDeğiştirToolStripMenuItem_Click);
            // 
            // txtSepetAdi
            // 
            this.txtSepetAdi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSepetAdi.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSepetAdi.Location = new System.Drawing.Point(552, 4);
            this.txtSepetAdi.Name = "txtSepetAdi";
            this.txtSepetAdi.Size = new System.Drawing.Size(291, 33);
            this.txtSepetAdi.TabIndex = 7;
            this.txtSepetAdi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtTTutar
            // 
            this.txtTTutar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTTutar.Enabled = false;
            this.txtTTutar.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtTTutar.Location = new System.Drawing.Point(632, 482);
            this.txtTTutar.Name = "txtTTutar";
            this.txtTTutar.Size = new System.Drawing.Size(211, 36);
            this.txtTTutar.TabIndex = 8;
            this.txtTTutar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(552, 490);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 23);
            this.label1.TabIndex = 9;
            this.label1.Text = "TUTAR";
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnCikis
            // 
            this.btnCikis.BackColor = System.Drawing.Color.Transparent;
            this.btnCikis.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCikis.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnCikis.Image = ((System.Drawing.Image)(resources.GetObject("btnCikis.Image")));
            this.btnCikis.Location = new System.Drawing.Point(0, 476);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(95, 50);
            this.btnCikis.TabIndex = 1;
            this.btnCikis.UseVisualStyleBackColor = false;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // btnAyar
            // 
            this.btnAyar.BackColor = System.Drawing.Color.Transparent;
            this.btnAyar.ForeColor = System.Drawing.Color.Black;
            this.btnAyar.Image = global::Cafe_Otomat.Properties.Resources.settings;
            this.btnAyar.Location = new System.Drawing.Point(0, 142);
            this.btnAyar.Name = "btnAyar";
            this.btnAyar.Size = new System.Drawing.Size(95, 70);
            this.btnAyar.TabIndex = 1;
            this.btnAyar.Text = "AYARLAR";
            this.btnAyar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnAyar.UseVisualStyleBackColor = false;
            this.btnAyar.Click += new System.EventHandler(this.btnAyar_Click);
            // 
            // btnRapor
            // 
            this.btnRapor.BackColor = System.Drawing.Color.Transparent;
            this.btnRapor.Image = global::Cafe_Otomat.Properties.Resources.diagram;
            this.btnRapor.Location = new System.Drawing.Point(0, 71);
            this.btnRapor.Name = "btnRapor";
            this.btnRapor.Size = new System.Drawing.Size(95, 70);
            this.btnRapor.TabIndex = 1;
            this.btnRapor.Text = "RAPORLAR";
            this.btnRapor.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnRapor.UseVisualStyleBackColor = false;
            this.btnRapor.Click += new System.EventHandler(this.btnRapor_Click);
            // 
            // btnIslemler
            // 
            this.btnIslemler.BackColor = System.Drawing.Color.Transparent;
            this.btnIslemler.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnIslemler.Image = global::Cafe_Otomat.Properties.Resources.calculations;
            this.btnIslemler.Location = new System.Drawing.Point(0, 0);
            this.btnIslemler.Name = "btnIslemler";
            this.btnIslemler.Size = new System.Drawing.Size(95, 70);
            this.btnIslemler.TabIndex = 1;
            this.btnIslemler.Text = "İŞLEMLER";
            this.btnIslemler.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnIslemler.UseVisualStyleBackColor = false;
            this.btnIslemler.Click += new System.EventHandler(this.btnIslemler_Click);
            // 
            // FrmSatisEkran
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(239)))), ((int)(((byte)(244)))));
            this.CancelButton = this.btnCikis;
            this.ClientSize = new System.Drawing.Size(843, 526);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTTutar);
            this.Controls.Add(this.txtSepetAdi);
            this.Controls.Add(this.tabUrun);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tabMasa);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "FrmSatisEkran";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmAnasayfa";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmAnasayfa_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.listeSepet)).EndInit();
            this.menuSepet.ResumeLayout(false);
            this.menuMasa.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCikis;
        private System.Windows.Forms.Button btnAyar;
        private System.Windows.Forms.Button btnRapor;
        private System.Windows.Forms.Button btnIslemler;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView listeSepet;
        private System.Windows.Forms.TabControl tabMasa;
        private System.Windows.Forms.TabControl tabUrun;
        private System.Windows.Forms.ContextMenuStrip menuSepet;
        private System.Windows.Forms.ToolStripMenuItem ürünüSilToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn URUN;
        private System.Windows.Forms.DataGridViewButtonColumn clmAzalt;
        private System.Windows.Forms.DataGridViewTextBoxColumn MIKTAR;
        private System.Windows.Forms.DataGridViewButtonColumn clmArtir;
        private System.Windows.Forms.DataGridViewTextBoxColumn TUTAR;
        private System.Windows.Forms.ContextMenuStrip menuMasa;
        private System.Windows.Forms.ToolStripMenuItem masaHesapKapatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem masaAdıDeğiştirToolStripMenuItem;
        private System.Windows.Forms.TextBox txtSepetAdi;
        private System.Windows.Forms.TextBox txtTTutar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
    }
}