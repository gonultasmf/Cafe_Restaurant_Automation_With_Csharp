
namespace Cafe_Otomat
{
    partial class FrmGiris
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnSingup = new System.Windows.Forms.Button();
            this.btnSingin = new System.Windows.Forms.Button();
            this.btnShowPassword = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.LightSlateGray;
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPassword.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtPassword.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.txtPassword.Location = new System.Drawing.Point(90, 309);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(250, 26);
            this.txtPassword.TabIndex = 1;
            this.txtPassword.Text = "Şifre";
            this.txtPassword.Enter += new System.EventHandler(this.txtPassword_Enter);
            this.txtPassword.Leave += new System.EventHandler(this.txtPassword_Leave);
            // 
            // txtUserName
            // 
            this.txtUserName.BackColor = System.Drawing.Color.LightSlateGray;
            this.txtUserName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUserName.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtUserName.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.txtUserName.Location = new System.Drawing.Point(90, 226);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(250, 26);
            this.txtUserName.TabIndex = 0;
            this.txtUserName.Text = "Kullanıcı Adı";
            this.txtUserName.Enter += new System.EventHandler(this.txtUserName_Enter);
            this.txtUserName.Leave += new System.EventHandler(this.txtUserName_Leave);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkCyan;
            this.panel1.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(89, 337);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(251, 2);
            this.panel1.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkCyan;
            this.panel2.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.panel2.Location = new System.Drawing.Point(89, 253);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(250, 2);
            this.panel2.TabIndex = 3;
            // 
            // btnSingup
            // 
            this.btnSingup.BackColor = System.Drawing.Color.White;
            this.btnSingup.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.btnSingup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSingup.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSingup.ForeColor = System.Drawing.Color.LightSlateGray;
            this.btnSingup.Location = new System.Drawing.Point(46, 378);
            this.btnSingup.Name = "btnSingup";
            this.btnSingup.Size = new System.Drawing.Size(136, 46);
            this.btnSingup.TabIndex = 6;
            this.btnSingup.Text = "ÇIKIŞ";
            this.btnSingup.UseVisualStyleBackColor = false;
            this.btnSingup.Click += new System.EventHandler(this.btnSingup_Click);
            // 
            // btnSingin
            // 
            this.btnSingin.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnSingin.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.btnSingin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSingin.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSingin.ForeColor = System.Drawing.Color.White;
            this.btnSingin.Location = new System.Drawing.Point(204, 378);
            this.btnSingin.Name = "btnSingin";
            this.btnSingin.Size = new System.Drawing.Size(136, 46);
            this.btnSingin.TabIndex = 3;
            this.btnSingin.Text = "GİRİŞ";
            this.btnSingin.UseVisualStyleBackColor = false;
            this.btnSingin.Click += new System.EventHandler(this.btnSingin_Click);
            // 
            // btnShowPassword
            // 
            this.btnShowPassword.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnShowPassword.FlatAppearance.BorderSize = 0;
            this.btnShowPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowPassword.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnShowPassword.Image = global::Cafe_Otomat.Properties.Resources.show_1;
            this.btnShowPassword.Location = new System.Drawing.Point(310, 309);
            this.btnShowPassword.Name = "btnShowPassword";
            this.btnShowPassword.Size = new System.Drawing.Size(27, 26);
            this.btnShowPassword.TabIndex = 7;
            this.btnShowPassword.UseVisualStyleBackColor = false;
            this.btnShowPassword.Click += new System.EventHandler(this.btnShowPassword_Click);
            // 
            // btnExit
            // 
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnExit.Image = global::Cafe_Otomat.Properties.Resources.close;
            this.btnExit.Location = new System.Drawing.Point(352, 0);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(29, 30);
            this.btnExit.TabIndex = 5;
            this.btnExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Cafe_Otomat.Properties.Resources.profil;
            this.pictureBox3.Location = new System.Drawing.Point(48, 226);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(41, 30);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 4;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Cafe_Otomat.Properties.Resources.sifre;
            this.pictureBox2.Location = new System.Drawing.Point(44, 305);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(45, 32);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Cafe_Otomat.Properties.Resources.profile;
            this.pictureBox1.Location = new System.Drawing.Point(128, 64);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(138, 136);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // FrmGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(384, 486);
            this.Controls.Add(this.btnShowPassword);
            this.Controls.Add(this.btnSingin);
            this.Controls.Add(this.btnSingup);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.pictureBox1);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.ImeMode = System.Windows.Forms.ImeMode.Hiragana;
            this.Name = "FrmGiris";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnSingup;
        private System.Windows.Forms.Button btnSingin;
        private System.Windows.Forms.Button btnShowPassword;
    }
}

