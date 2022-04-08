
namespace Cafe_Otomat
{
    partial class FrmIslemler
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
            this.btnStokIslem = new System.Windows.Forms.Button();
            this.btnKasaIslem = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnStokIslem
            // 
            this.btnStokIslem.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnStokIslem.Image = global::Cafe_Otomat.Properties.Resources.stock;
            this.btnStokIslem.Location = new System.Drawing.Point(184, 12);
            this.btnStokIslem.Name = "btnStokIslem";
            this.btnStokIslem.Size = new System.Drawing.Size(160, 185);
            this.btnStokIslem.TabIndex = 1;
            this.btnStokIslem.Text = "STOK İŞLEMLERİ";
            this.btnStokIslem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnStokIslem.UseVisualStyleBackColor = true;
            this.btnStokIslem.Click += new System.EventHandler(this.btnStokIslem_Click);
            // 
            // btnKasaIslem
            // 
            this.btnKasaIslem.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKasaIslem.Image = global::Cafe_Otomat.Properties.Resources.cash_register;
            this.btnKasaIslem.Location = new System.Drawing.Point(12, 12);
            this.btnKasaIslem.Name = "btnKasaIslem";
            this.btnKasaIslem.Size = new System.Drawing.Size(160, 185);
            this.btnKasaIslem.TabIndex = 0;
            this.btnKasaIslem.Text = "KASA İŞLEMLERİ";
            this.btnKasaIslem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnKasaIslem.UseVisualStyleBackColor = true;
            this.btnKasaIslem.Click += new System.EventHandler(this.btnKasaIslem_Click);
            // 
            // FrmIslemler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(356, 209);
            this.Controls.Add(this.btnStokIslem);
            this.Controls.Add(this.btnKasaIslem);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmIslemler";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "İşlemler";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnKasaIslem;
        private System.Windows.Forms.Button btnStokIslem;
    }
}