
namespace Cafe_Otomat
{
    partial class FrmTedarikciIslemleri
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTedarikciIslemleri));
            this.listeTedarikci = new System.Windows.Forms.DataGridView();
            this.sUPPLIERTBLBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtTedarikci = new System.Windows.Forms.TextBox();
            this.btnKapat = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnEkle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.listeTedarikci)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sUPPLIERTBLBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // listeTedarikci
            // 
            this.listeTedarikci.AllowUserToAddRows = false;
            this.listeTedarikci.AllowUserToDeleteRows = false;
            this.listeTedarikci.AllowUserToResizeRows = false;
            this.listeTedarikci.AutoGenerateColumns = false;
            this.listeTedarikci.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.listeTedarikci.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(239)))), ((int)(((byte)(244)))));
            this.listeTedarikci.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listeTedarikci.DataSource = this.sUPPLIERTBLBindingSource;
            resources.ApplyResources(this.listeTedarikci, "listeTedarikci");
            this.listeTedarikci.MultiSelect = false;
            this.listeTedarikci.Name = "listeTedarikci";
            this.listeTedarikci.ReadOnly = true;
            this.listeTedarikci.RowHeadersVisible = false;
            this.listeTedarikci.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            // 
            // txtTedarikci
            // 
            resources.ApplyResources(this.txtTedarikci, "txtTedarikci");
            this.txtTedarikci.Name = "txtTedarikci";
            this.txtTedarikci.TextChanged += new System.EventHandler(this.txtTedarikci_TextChanged);
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
            resources.ApplyResources(this.btnSil, "btnSil");
            this.btnSil.Image = global::Cafe_Otomat.Properties.Resources.delete__1_;
            this.btnSil.Name = "btnSil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnEkle
            // 
            resources.ApplyResources(this.btnEkle, "btnEkle");
            this.btnEkle.Image = global::Cafe_Otomat.Properties.Resources._checked;
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // FrmTedarikciIslemleri
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(239)))), ((int)(((byte)(244)))));
            this.Controls.Add(this.listeTedarikci);
            this.Controls.Add(this.btnKapat);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.txtTedarikci);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "FrmTedarikciIslemleri";
            this.Load += new System.EventHandler(this.FrmTedarikciIslemleri_Load);
            ((System.ComponentModel.ISupportInitialize)(this.listeTedarikci)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sUPPLIERTBLBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView listeTedarikci;
        private System.Windows.Forms.Button btnKapat;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.TextBox txtTedarikci;
        private System.Windows.Forms.BindingSource sUPPLIERTBLBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn sUPPLIERIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sUPPLIERNAMEDataGridViewTextBoxColumn;
    }
}