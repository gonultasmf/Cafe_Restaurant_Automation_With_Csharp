
namespace Cafe_Otomat
{
    partial class FrmParaGiris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmParaGiris));
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.txtGirenMiktar = new System.Windows.Forms.TextBox();
            this.comboAciklama = new System.Windows.Forms.ComboBox();
            this.txtIslemNo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnIptal = new System.Windows.Forms.Button();
            this.btnIslemNoVer = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label4);
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.Name = "panel2";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // txtGirenMiktar
            // 
            this.txtGirenMiktar.BackColor = System.Drawing.Color.Azure;
            resources.ApplyResources(this.txtGirenMiktar, "txtGirenMiktar");
            this.txtGirenMiktar.Name = "txtGirenMiktar";
            this.txtGirenMiktar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtGirenMiktar_KeyPress);
            // 
            // comboAciklama
            // 
            this.comboAciklama.BackColor = System.Drawing.Color.Azure;
            resources.ApplyResources(this.comboAciklama, "comboAciklama");
            this.comboAciklama.FormattingEnabled = true;
            this.comboAciklama.Items.AddRange(new object[] {
            resources.GetString("comboAciklama.Items"),
            resources.GetString("comboAciklama.Items1")});
            this.comboAciklama.Name = "comboAciklama";
            // 
            // txtIslemNo
            // 
            this.txtIslemNo.BackColor = System.Drawing.Color.Azure;
            resources.ApplyResources(this.txtIslemNo, "txtIslemNo");
            this.txtIslemNo.Name = "txtIslemNo";
            this.txtIslemNo.ReadOnly = true;
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
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
            // btnIptal
            // 
            this.btnIptal.BackColor = System.Drawing.Color.Azure;
            resources.ApplyResources(this.btnIptal, "btnIptal");
            this.btnIptal.Image = global::Cafe_Otomat.Properties.Resources.close1;
            this.btnIptal.Name = "btnIptal";
            this.btnIptal.UseVisualStyleBackColor = false;
            this.btnIptal.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnIslemNoVer
            // 
            this.btnIslemNoVer.BackColor = System.Drawing.Color.Azure;
            resources.ApplyResources(this.btnIslemNoVer, "btnIslemNoVer");
            this.btnIslemNoVer.Image = global::Cafe_Otomat.Properties.Resources.shuffle;
            this.btnIslemNoVer.Name = "btnIslemNoVer";
            this.btnIslemNoVer.UseVisualStyleBackColor = false;
            this.btnIslemNoVer.Click += new System.EventHandler(this.btnIslemNoVer_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::Cafe_Otomat.Properties.Resources.add;
            resources.ApplyResources(this.pictureBox2, "pictureBox2");
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::Cafe_Otomat.Properties.Resources.wallet;
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // FrmParaGiris
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.btnIptal);
            this.Controls.Add(this.txtGirenMiktar);
            this.Controls.Add(this.comboAciklama);
            this.Controls.Add(this.btnIslemNoVer);
            this.Controls.Add(this.txtIslemNo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "FrmParaGiris";
            this.Load += new System.EventHandler(this.FrmParaGiris_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnIptal;
        private System.Windows.Forms.TextBox txtGirenMiktar;
        private System.Windows.Forms.ComboBox comboAciklama;
        private System.Windows.Forms.Button btnIslemNoVer;
        private System.Windows.Forms.TextBox txtIslemNo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}