
namespace Cafe_Otomat
{
    partial class FrmBirimIslemleri
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBirimIslemleri));
            this.listeBirim = new System.Windows.Forms.DataGridView();
            this.txtBirim = new System.Windows.Forms.TextBox();
            this.btnKapat = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnEkle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.listeBirim)).BeginInit();
            this.SuspendLayout();
            // 
            // listeBirim
            // 
            this.listeBirim.AllowUserToAddRows = false;
            this.listeBirim.AllowUserToDeleteRows = false;
            this.listeBirim.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightGray;
            this.listeBirim.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.listeBirim.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.listeBirim.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(239)))), ((int)(((byte)(244)))));
            this.listeBirim.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resources.ApplyResources(this.listeBirim, "listeBirim");
            this.listeBirim.MultiSelect = false;
            this.listeBirim.Name = "listeBirim";
            this.listeBirim.ReadOnly = true;
            this.listeBirim.RowHeadersVisible = false;
            this.listeBirim.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            // 
            // txtBirim
            // 
            resources.ApplyResources(this.txtBirim, "txtBirim");
            this.txtBirim.Name = "txtBirim";
            this.txtBirim.TextChanged += new System.EventHandler(this.txtBirim_TextChanged);
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
            // FrmBirimIslemleri
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(239)))), ((int)(((byte)(244)))));
            this.Controls.Add(this.listeBirim);
            this.Controls.Add(this.btnKapat);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.txtBirim);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "FrmBirimIslemleri";
            this.Load += new System.EventHandler(this.FrmBirimIslemleri_Load);
            ((System.ComponentModel.ISupportInitialize)(this.listeBirim)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView listeBirim;
        private System.Windows.Forms.Button btnKapat;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.TextBox txtBirim;
        private System.Windows.Forms.DataGridViewTextBoxColumn uNITIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn uNITNAMEDataGridViewTextBoxColumn;
    }
}