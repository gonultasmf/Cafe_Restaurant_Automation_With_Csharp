
namespace Cafe_Otomat
{
    partial class FrmYukleniyor
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
            this.prgrsYukleniyor = new System.Windows.Forms.ProgressBar();
            this.btnBaslat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // prgrsYukleniyor
            // 
            this.prgrsYukleniyor.ForeColor = System.Drawing.Color.Chartreuse;
            this.prgrsYukleniyor.Location = new System.Drawing.Point(12, 12);
            this.prgrsYukleniyor.Name = "prgrsYukleniyor";
            this.prgrsYukleniyor.Size = new System.Drawing.Size(383, 47);
            this.prgrsYukleniyor.TabIndex = 0;
            // 
            // btnBaslat
            // 
            this.btnBaslat.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBaslat.Image = global::Cafe_Otomat.Properties.Resources._checked;
            this.btnBaslat.Location = new System.Drawing.Point(134, 70);
            this.btnBaslat.Name = "btnBaslat";
            this.btnBaslat.Size = new System.Drawing.Size(137, 45);
            this.btnBaslat.TabIndex = 2;
            this.btnBaslat.Text = "BAŞLAT";
            this.btnBaslat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBaslat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBaslat.UseVisualStyleBackColor = true;
            this.btnBaslat.Click += new System.EventHandler(this.btnBaslat_Click);
            // 
            // FrmYukleniyor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(407, 127);
            this.Controls.Add(this.btnBaslat);
            this.Controls.Add(this.prgrsYukleniyor);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmYukleniyor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmYukleniyor";
            this.Load += new System.EventHandler(this.FrmYukleniyor_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ProgressBar prgrsYukleniyor;
        private System.Windows.Forms.Button btnBaslat;
    }
}