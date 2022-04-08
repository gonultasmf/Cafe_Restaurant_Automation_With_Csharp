
namespace Cafe_Otomat
{
    partial class FrmKategoriIslemleri
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmKategoriIslemleri));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtKategori = new System.Windows.Forms.TextBox();
            this.listeKategori = new System.Windows.Forms.DataGridView();
            this.btnKapat = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnEkle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.listeKategori)).BeginInit();
            this.SuspendLayout();
            // 
            // txtKategori
            // 
            this.txtKategori.BackColor = System.Drawing.Color.Azure;
            resources.ApplyResources(this.txtKategori, "txtKategori");
            this.txtKategori.Name = "txtKategori";
            this.txtKategori.TextChanged += new System.EventHandler(this.txtKategori_TextChanged);
            // 
            // listeKategori
            // 
            this.listeKategori.AllowUserToAddRows = false;
            this.listeKategori.AllowUserToDeleteRows = false;
            this.listeKategori.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightGray;
            this.listeKategori.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.listeKategori.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.listeKategori.BackgroundColor = System.Drawing.Color.Azure;
            this.listeKategori.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resources.ApplyResources(this.listeKategori, "listeKategori");
            this.listeKategori.MultiSelect = false;
            this.listeKategori.Name = "listeKategori";
            this.listeKategori.ReadOnly = true;
            this.listeKategori.RowHeadersVisible = false;
            this.listeKategori.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            // 
            // btnKapat
            // 
            resources.ApplyResources(this.btnKapat, "btnKapat");
            this.btnKapat.Image = global::Cafe_Otomat.Properties.Resources.arrow;
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.UseVisualStyleBackColor = true;
            this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);
            // 
            // btnSil
            // 
            this.btnSil.BackColor = System.Drawing.Color.Azure;
            resources.ApplyResources(this.btnSil, "btnSil");
            this.btnSil.Image = global::Cafe_Otomat.Properties.Resources.delete__1_;
            this.btnSil.Name = "btnSil";
            this.btnSil.UseVisualStyleBackColor = false;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnEkle
            // 
            this.btnEkle.BackColor = System.Drawing.Color.Azure;
            resources.ApplyResources(this.btnEkle, "btnEkle");
            this.btnEkle.Image = global::Cafe_Otomat.Properties.Resources._checked;
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.UseVisualStyleBackColor = false;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // FrmKategoriIslemleri
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.Controls.Add(this.listeKategori);
            this.Controls.Add(this.btnKapat);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.txtKategori);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "FrmKategoriIslemleri";
            this.Load += new System.EventHandler(this.FrmKategoriIslemleri_Load);
            ((System.ComponentModel.ISupportInitialize)(this.listeKategori)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtKategori;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.DataGridView listeKategori;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnKapat;
        private System.Windows.Forms.DataGridViewTextBoxColumn cATEGORYIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cATEGORYNAMEDataGridViewTextBoxColumn;
    }
}