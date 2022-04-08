
namespace Cafe_Otomat
{
    partial class FrmMasaAdi
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
            this.txtMasaAd = new System.Windows.Forms.TextBox();
            this.btnEkle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtMasaAd
            // 
            this.txtMasaAd.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtMasaAd.Location = new System.Drawing.Point(12, 12);
            this.txtMasaAd.Name = "txtMasaAd";
            this.txtMasaAd.Size = new System.Drawing.Size(323, 26);
            this.txtMasaAd.TabIndex = 0;
            this.txtMasaAd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMasaAd_KeyPress);
            this.txtMasaAd.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtMasaAd_KeyUp);
            // 
            // btnEkle
            // 
            this.btnEkle.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEkle.Image = global::Cafe_Otomat.Properties.Resources._checked;
            this.btnEkle.Location = new System.Drawing.Point(43, 47);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(250, 47);
            this.btnEkle.TabIndex = 0;
            this.btnEkle.Text = "KAYDET/ÇIK";
            this.btnEkle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEkle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // FrmMasaAdi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 106);
            this.Controls.Add(this.txtMasaAd);
            this.Controls.Add(this.btnEkle);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmMasaAdi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Masa Ad İşlem";
            this.Load += new System.EventHandler(this.YeniMasa_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.TextBox txtMasaAd;
    }
}