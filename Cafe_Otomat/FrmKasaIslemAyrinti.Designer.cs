
namespace Cafe_Otomat
{
    partial class FrmKasaIslemAyrinti
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmKasaIslemAyrinti));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.listeKasaIslemAyrinti = new System.Windows.Forms.DataGridView();
            this.btnKapat = new System.Windows.Forms.Button();
            this.listeDeneme = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ACIKLAMA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listeKasaIslemAyrinti)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listeDeneme)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.listeKasaIslemAyrinti);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // listeKasaIslemAyrinti
            // 
            this.listeKasaIslemAyrinti.AllowUserToAddRows = false;
            this.listeKasaIslemAyrinti.AllowUserToDeleteRows = false;
            this.listeKasaIslemAyrinti.AllowUserToOrderColumns = true;
            this.listeKasaIslemAyrinti.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightGray;
            this.listeKasaIslemAyrinti.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.listeKasaIslemAyrinti.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.listeKasaIslemAyrinti.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(239)))), ((int)(((byte)(244)))));
            this.listeKasaIslemAyrinti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resources.ApplyResources(this.listeKasaIslemAyrinti, "listeKasaIslemAyrinti");
            this.listeKasaIslemAyrinti.Name = "listeKasaIslemAyrinti";
            this.listeKasaIslemAyrinti.ReadOnly = true;
            this.listeKasaIslemAyrinti.RowHeadersVisible = false;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DodgerBlue;
            this.listeKasaIslemAyrinti.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.listeKasaIslemAyrinti.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            // 
            // btnKapat
            // 
            this.btnKapat.BackColor = System.Drawing.Color.Azure;
            resources.ApplyResources(this.btnKapat, "btnKapat");
            this.btnKapat.Image = global::Cafe_Otomat.Properties.Resources.arrow;
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.UseVisualStyleBackColor = false;
            this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);
            // 
            // listeDeneme
            // 
            this.listeDeneme.AllowUserToAddRows = false;
            this.listeDeneme.AllowUserToDeleteRows = false;
            this.listeDeneme.AllowUserToResizeRows = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.LightGray;
            this.listeDeneme.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
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
            this.dataGridViewTextBoxColumn8});
            resources.ApplyResources(this.listeDeneme, "listeDeneme");
            this.listeDeneme.Name = "listeDeneme";
            this.listeDeneme.ReadOnly = true;
            this.listeDeneme.RowHeadersVisible = false;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.DodgerBlue;
            this.listeDeneme.RowsDefaultCellStyle = dataGridViewCellStyle4;
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
            // dataGridViewTextBoxColumn8
            // 
            resources.ApplyResources(this.dataGridViewTextBoxColumn8, "dataGridViewTextBoxColumn8");
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // FrmKasaIslemAyrinti
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.Controls.Add(this.listeDeneme);
            this.Controls.Add(this.btnKapat);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "FrmKasaIslemAyrinti";
            this.Load += new System.EventHandler(this.FrmKasaIslemAyrinti_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.listeKasaIslemAyrinti)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listeDeneme)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnKapat;
        private System.Windows.Forms.DataGridView listeDeneme;
        private System.Windows.Forms.DataGridView listeKasaIslemAyrinti;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn ACIKLAMA;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
    }
}