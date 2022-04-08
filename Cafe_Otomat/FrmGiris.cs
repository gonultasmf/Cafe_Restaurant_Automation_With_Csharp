using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
//using System.Drawing.Image;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cafe_Otomat
{
    public partial class FrmGiris : Form
    {
        DataBase db = new DataBase();
        public static bool control = false;
        public FrmGiris()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        

        private void btnShowPassword_Click(object sender, EventArgs e)
        {
            if(txtPassword.UseSystemPasswordChar == false)
            {
                txtPassword.UseSystemPasswordChar = true;
                this.btnShowPassword.Image = Properties.Resources.hide_1;
                if (txtPassword.Text == " Password")
                {
                    txtPassword.Clear();
                }
            }
            else 
            {
                txtPassword.UseSystemPasswordChar = false;
                this.btnShowPassword.Image = Cafe_Otomat.Properties.Resources.show_1;
            }
            
        }

        private void txtUserName_Enter(object sender, EventArgs e)
        {
            if (txtUserName.Text == "Kullanıcı Adı")
            {
                txtUserName.Clear();
            }

            txtUserName.Font = new Font(Font, FontStyle.Regular);
            txtUserName.Font = new Font("Calibri", 16.0F);
        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            if (txtPassword.Text == "Şifre")
            {
                txtPassword.Clear();
            }

            txtPassword.Font = new Font(Font, FontStyle.Regular);
            txtPassword.Font = new Font("Calibri", 16.0F);
        }

        private void txtUserName_Leave(object sender, EventArgs e)
        {
            if(txtUserName.TextLength == 0)
            {
                txtUserName.Text = "Kullanıcı Adı";
            }
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            if (txtPassword.TextLength == 0)
            {
                txtPassword.Text = "Şifre";
            }
        }

        private void btnSingin_Click(object sender, EventArgs e)
        {
            SqlDataReader dr = db.Kullanici_Bilgi_Database();
            while (dr.Read())
            {
                if(txtUserName.Text == dr[1].ToString() && txtPassword.Text == dr[2].ToString()) // veritabanında kullanıcı adı
                                                                                                 // ve şifre kontrolü yapılıyor
                {
                    DataBase.kullanici = dr[3].ToString();
                    control = true;
                    this.Close();
                }
                else
                {
                    control = false;
                    MessageBox.Show("Kullanıcı Girişi Yapılamadı...");
                }
            }
            dr.Close();
            db.baglanti.Close();
        }

        private void btnSingup_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
