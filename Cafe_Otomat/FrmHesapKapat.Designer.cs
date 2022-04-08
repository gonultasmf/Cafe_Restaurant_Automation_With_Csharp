
namespace Cafe_Otomat
{
    partial class FrmHesapKapat
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtMasaAdi = new System.Windows.Forms.TextBox();
            this.lblTTutar = new System.Windows.Forms.Label();
            this.txtTTutar = new System.Windows.Forms.TextBox();
            this.comboOdeme = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.listeSiparisler = new System.Windows.Forms.DataGridView();
            this.listeHesap = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnCikar = new System.Windows.Forms.Button();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnHesapKapat = new System.Windows.Forms.Button();
            this.btnOdeme = new System.Windows.Forms.Button();
            this.btnIptal = new System.Windows.Forms.Button();
            this.txtTutar = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtUrunAdi = new System.Windows.Forms.TextBox();
            this.nmrcMiktar = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.listeSiparisler)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listeHesap)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrcMiktar)).BeginInit();
            this.SuspendLayout();
            // 
            // txtMasaAdi
            // 
            this.txtMasaAdi.Enabled = false;
            this.txtMasaAdi.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtMasaAdi.Location = new System.Drawing.Point(12, 12);
            this.txtMasaAdi.Name = "txtMasaAdi";
            this.txtMasaAdi.Size = new System.Drawing.Size(663, 33);
            this.txtMasaAdi.TabIndex = 0;
            this.txtMasaAdi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblTTutar
            // 
            this.lblTTutar.AutoSize = true;
            this.lblTTutar.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTTutar.Location = new System.Drawing.Point(360, 373);
            this.lblTTutar.Name = "lblTTutar";
            this.lblTTutar.Size = new System.Drawing.Size(131, 19);
            this.lblTTutar.TabIndex = 1;
            this.lblTTutar.Text = "Toplam Tutar :";
            // 
            // txtTTutar
            // 
            this.txtTTutar.Enabled = false;
            this.txtTTutar.Font = new System.Drawing.Font("Tahoma", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtTTutar.Location = new System.Drawing.Point(490, 357);
            this.txtTTutar.Name = "txtTTutar";
            this.txtTTutar.Size = new System.Drawing.Size(185, 43);
            this.txtTTutar.TabIndex = 2;
            this.txtTTutar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // comboOdeme
            // 
            this.comboOdeme.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboOdeme.FormattingEnabled = true;
            this.comboOdeme.Items.AddRange(new object[] {
            "NAKİT",
            "POS"});
            this.comboOdeme.Location = new System.Drawing.Point(490, 406);
            this.comboOdeme.Name = "comboOdeme";
            this.comboOdeme.Size = new System.Drawing.Size(185, 27);
            this.comboOdeme.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(371, 409);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ödeme Türü :";
            // 
            // listeSiparisler
            // 
            this.listeSiparisler.AllowUserToAddRows = false;
            this.listeSiparisler.AllowUserToDeleteRows = false;
            this.listeSiparisler.AllowUserToOrderColumns = true;
            this.listeSiparisler.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightGray;
            this.listeSiparisler.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.listeSiparisler.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.listeSiparisler.BackgroundColor = System.Drawing.Color.CadetBlue;
            this.listeSiparisler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listeSiparisler.Location = new System.Drawing.Point(12, 51);
            this.listeSiparisler.MultiSelect = false;
            this.listeSiparisler.Name = "listeSiparisler";
            this.listeSiparisler.ReadOnly = true;
            this.listeSiparisler.RowHeadersVisible = false;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DodgerBlue;
            this.listeSiparisler.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.listeSiparisler.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.listeSiparisler.Size = new System.Drawing.Size(300, 300);
            this.listeSiparisler.TabIndex = 5;
            this.listeSiparisler.SelectionChanged += new System.EventHandler(this.listeSiparisler_SelectionChanged);
            // 
            // listeHesap
            // 
            this.listeHesap.AllowUserToAddRows = false;
            this.listeHesap.AllowUserToDeleteRows = false;
            this.listeHesap.AllowUserToOrderColumns = true;
            this.listeHesap.AllowUserToResizeRows = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.LightGray;
            this.listeHesap.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.listeHesap.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.listeHesap.BackgroundColor = System.Drawing.Color.CadetBlue;
            this.listeHesap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listeHesap.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.listeHesap.Location = new System.Drawing.Point(375, 51);
            this.listeHesap.Name = "listeHesap";
            this.listeHesap.ReadOnly = true;
            this.listeHesap.RowHeadersVisible = false;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.DodgerBlue;
            this.listeHesap.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.listeHesap.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.listeHesap.Size = new System.Drawing.Size(300, 300);
            this.listeHesap.TabIndex = 6;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "ÜRÜN";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "MİKTAR";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "TUTAR";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "PERSONEL";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // btnCikar
            // 
            this.btnCikar.BackColor = System.Drawing.Color.Azure;
            this.btnCikar.FlatAppearance.BorderColor = System.Drawing.Color.PaleTurquoise;
            this.btnCikar.FlatAppearance.BorderSize = 3;
            this.btnCikar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCikar.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCikar.Image = global::Cafe_Otomat.Properties.Resources.left_arrow;
            this.btnCikar.Location = new System.Drawing.Point(318, 201);
            this.btnCikar.Name = "btnCikar";
            this.btnCikar.Size = new System.Drawing.Size(51, 39);
            this.btnCikar.TabIndex = 10;
            this.btnCikar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCikar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCikar.UseVisualStyleBackColor = false;
            this.btnCikar.Click += new System.EventHandler(this.btnCikar_Click);
            // 
            // btnEkle
            // 
            this.btnEkle.BackColor = System.Drawing.Color.Azure;
            this.btnEkle.FlatAppearance.BorderColor = System.Drawing.Color.PaleTurquoise;
            this.btnEkle.FlatAppearance.BorderSize = 3;
            this.btnEkle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEkle.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEkle.Image = global::Cafe_Otomat.Properties.Resources.right_arrow;
            this.btnEkle.Location = new System.Drawing.Point(318, 156);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(51, 39);
            this.btnEkle.TabIndex = 9;
            this.btnEkle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEkle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEkle.UseVisualStyleBackColor = false;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnHesapKapat
            // 
            this.btnHesapKapat.BackColor = System.Drawing.Color.Azure;
            this.btnHesapKapat.FlatAppearance.BorderColor = System.Drawing.Color.MediumTurquoise;
            this.btnHesapKapat.FlatAppearance.BorderSize = 3;
            this.btnHesapKapat.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnHesapKapat.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnHesapKapat.Image = global::Cafe_Otomat.Properties.Resources.close1;
            this.btnHesapKapat.Location = new System.Drawing.Point(360, 495);
            this.btnHesapKapat.Name = "btnHesapKapat";
            this.btnHesapKapat.Size = new System.Drawing.Size(315, 50);
            this.btnHesapKapat.TabIndex = 7;
            this.btnHesapKapat.Text = "HESABI KAPAT";
            this.btnHesapKapat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnHesapKapat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHesapKapat.UseVisualStyleBackColor = false;
            this.btnHesapKapat.Click += new System.EventHandler(this.btnHesapKapat_Click);
            // 
            // btnOdeme
            // 
            this.btnOdeme.BackColor = System.Drawing.Color.Azure;
            this.btnOdeme.FlatAppearance.BorderColor = System.Drawing.Color.PaleTurquoise;
            this.btnOdeme.FlatAppearance.BorderSize = 3;
            this.btnOdeme.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnOdeme.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOdeme.Image = global::Cafe_Otomat.Properties.Resources._checked;
            this.btnOdeme.Location = new System.Drawing.Point(521, 439);
            this.btnOdeme.Name = "btnOdeme";
            this.btnOdeme.Size = new System.Drawing.Size(154, 50);
            this.btnOdeme.TabIndex = 0;
            this.btnOdeme.Text = "ÖDEME";
            this.btnOdeme.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnOdeme.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnOdeme.UseVisualStyleBackColor = false;
            this.btnOdeme.Click += new System.EventHandler(this.btnOdeme_Click);
            // 
            // btnIptal
            // 
            this.btnIptal.BackColor = System.Drawing.Color.Azure;
            this.btnIptal.FlatAppearance.BorderColor = System.Drawing.Color.MediumTurquoise;
            this.btnIptal.FlatAppearance.BorderSize = 3;
            this.btnIptal.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnIptal.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnIptal.Image = global::Cafe_Otomat.Properties.Resources.close1;
            this.btnIptal.Location = new System.Drawing.Point(360, 439);
            this.btnIptal.Name = "btnIptal";
            this.btnIptal.Size = new System.Drawing.Size(155, 50);
            this.btnIptal.TabIndex = 3;
            this.btnIptal.Text = "İPTAL";
            this.btnIptal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnIptal.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnIptal.UseVisualStyleBackColor = false;
            this.btnIptal.Click += new System.EventHandler(this.btnIptal_Click);
            // 
            // txtTutar
            // 
            this.txtTutar.Enabled = false;
            this.txtTutar.Font = new System.Drawing.Font("Tahoma", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtTutar.Location = new System.Drawing.Point(88, 357);
            this.txtTutar.Name = "txtTutar";
            this.txtTutar.Size = new System.Drawing.Size(224, 43);
            this.txtTutar.TabIndex = 12;
            this.txtTutar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(24, 373);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 19);
            this.label2.TabIndex = 11;
            this.label2.Text = "Tutar :";
            // 
            // toolTip1
            // 
            this.toolTip1.IsBalloon = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtUrunAdi);
            this.groupBox1.Controls.Add(this.nmrcMiktar);
            this.groupBox1.Location = new System.Drawing.Point(12, 409);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(300, 136);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Miktar Ayarlama Formu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(3, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ürün Miktarı :";
            // 
            // txtUrunAdi
            // 
            this.txtUrunAdi.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtUrunAdi.Location = new System.Drawing.Point(6, 37);
            this.txtUrunAdi.Name = "txtUrunAdi";
            this.txtUrunAdi.Size = new System.Drawing.Size(288, 27);
            this.txtUrunAdi.TabIndex = 1;
            // 
            // nmrcMiktar
            // 
            this.nmrcMiktar.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.nmrcMiktar.Location = new System.Drawing.Point(124, 82);
            this.nmrcMiktar.Name = "nmrcMiktar";
            this.nmrcMiktar.Size = new System.Drawing.Size(170, 30);
            this.nmrcMiktar.TabIndex = 0;
            // 
            // FrmHesapKapat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(687, 554);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtTutar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnCikar);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.btnHesapKapat);
            this.Controls.Add(this.listeHesap);
            this.Controls.Add(this.listeSiparisler);
            this.Controls.Add(this.comboOdeme);
            this.Controls.Add(this.btnOdeme);
            this.Controls.Add(this.btnIptal);
            this.Controls.Add(this.txtTTutar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTTutar);
            this.Controls.Add(this.txtMasaAdi);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmHesapKapat";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hesap Kapat";
            this.Load += new System.EventHandler(this.FrmHesapKapat_Load);
            ((System.ComponentModel.ISupportInitialize)(this.listeSiparisler)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listeHesap)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrcMiktar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMasaAdi;
        private System.Windows.Forms.Label lblTTutar;
        private System.Windows.Forms.TextBox txtTTutar;
        private System.Windows.Forms.Button btnIptal;
        private System.Windows.Forms.Button btnOdeme;
        private System.Windows.Forms.ComboBox comboOdeme;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView listeSiparisler;
        private System.Windows.Forms.DataGridView listeHesap;
        private System.Windows.Forms.Button btnHesapKapat;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnCikar;
        private System.Windows.Forms.TextBox txtTutar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtUrunAdi;
        private System.Windows.Forms.NumericUpDown nmrcMiktar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
    }
}