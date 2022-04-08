
namespace Cafe_Otomat
{
    partial class FrmStokEkle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmStokEkle));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnIptal = new System.Windows.Forms.Button();
            this.nmrcMiktar = new System.Windows.Forms.NumericUpDown();
            this.txtMevcutMiktar = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtUrunAdi = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrcMiktar)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnEkle);
            this.panel1.Controls.Add(this.btnIptal);
            this.panel1.Controls.Add(this.nmrcMiktar);
            this.panel1.Controls.Add(this.txtMevcutMiktar);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtUrunAdi);
            this.panel1.Location = new System.Drawing.Point(13, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(314, 212);
            this.panel1.TabIndex = 0;
            // 
            // btnEkle
            // 
            this.btnEkle.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.btnEkle.Image = global::Cafe_Otomat.Properties.Resources.add_file;
            this.btnEkle.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnEkle.Location = new System.Drawing.Point(138, 152);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(167, 48);
            this.btnEkle.TabIndex = 1;
            this.btnEkle.Text = "STOK EKLE";
            this.btnEkle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEkle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnIptal
            // 
            this.btnIptal.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.btnIptal.Image = global::Cafe_Otomat.Properties.Resources.close1;
            this.btnIptal.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnIptal.Location = new System.Drawing.Point(9, 152);
            this.btnIptal.Name = "btnIptal";
            this.btnIptal.Size = new System.Drawing.Size(123, 48);
            this.btnIptal.TabIndex = 4;
            this.btnIptal.Text = "VAZGEÇ";
            this.btnIptal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnIptal.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnIptal.UseVisualStyleBackColor = true;
            this.btnIptal.Click += new System.EventHandler(this.btnIptal_Click);
            // 
            // nmrcMiktar
            // 
            this.nmrcMiktar.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold);
            this.nmrcMiktar.Location = new System.Drawing.Point(142, 102);
            this.nmrcMiktar.Name = "nmrcMiktar";
            this.nmrcMiktar.Size = new System.Drawing.Size(163, 26);
            this.nmrcMiktar.TabIndex = 0;
            // 
            // txtMevcutMiktar
            // 
            this.txtMevcutMiktar.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.txtMevcutMiktar.Location = new System.Drawing.Point(142, 55);
            this.txtMevcutMiktar.Name = "txtMevcutMiktar";
            this.txtMevcutMiktar.ReadOnly = true;
            this.txtMevcutMiktar.Size = new System.Drawing.Size(163, 27);
            this.txtMevcutMiktar.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(89, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 14);
            this.label2.TabIndex = 1;
            this.label2.Text = "Miktar :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(4, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 14);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mevcut Stok Miktarı :";
            // 
            // txtUrunAdi
            // 
            this.txtUrunAdi.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold);
            this.txtUrunAdi.Location = new System.Drawing.Point(9, 9);
            this.txtUrunAdi.Name = "txtUrunAdi";
            this.txtUrunAdi.ReadOnly = true;
            this.txtUrunAdi.Size = new System.Drawing.Size(296, 26);
            this.txtUrunAdi.TabIndex = 2;
            // 
            // FrmStokEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(239)))), ((int)(((byte)(244)))));
            this.ClientSize = new System.Drawing.Size(339, 237);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmStokEkle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stok Ekle";
            this.Load += new System.EventHandler(this.FrmStokEkle_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrcMiktar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnIptal;
        private System.Windows.Forms.NumericUpDown nmrcMiktar;
        private System.Windows.Forms.TextBox txtMevcutMiktar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtUrunAdi;
    }
}