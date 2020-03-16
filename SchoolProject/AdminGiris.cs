using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using MySql.Data;

namespace SchoolProject
{
    public partial class AdminGiris : Form
    {
        public AdminGiris()
        {
            InitializeComponent();
            AdminSifreTextBox.Text = "";
            AdminSifreTextBox.PasswordChar = '*';
            AdminSifreTextBox.MaxLength = 20;
            AdminIsimTextBox.MaxLength = 20;
        }

        private void AdminGirisButton_Click(object sender, EventArgs e)
        {
            db connect = new db();
            MySqlCommand kmt = new MySqlCommand();
            MySqlDataReader dr;
            kmt.Connection = connect.baglan();
            kmt.CommandText = "Select * FROM girisbilgi where KullaniciAdi = '" + AdminIsimTextBox.Text + "' AND Sifre = '" + AdminSifreTextBox.Text + "'";
            dr = kmt.ExecuteReader();
            if (dr.Read())
            {
                MessageBox.Show("Giriş Başarılı \nAktarılıyorsunuz ...");
                this.Hide();
                YönetimPaneli panel = new YönetimPaneli();
                panel.Show();

            }
            else
            {
                MessageBox.Show("Hatalı Kullanıcı Adı veya Şifre Girdiniz !");
            }
            kmt.Connection = connect.kapat();
        }

        private void AdminIsimTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void AdminSifreTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void AdminGiris_Load(object sender, EventArgs e)
        {

        }

        private void BackAdmin_Click(object sender, EventArgs e)
        {
            this.Hide();
            GirisEkran giris = new GirisEkran();
            giris.Show();
        }

        private void AdminGirisPic_Click(object sender, EventArgs e)
        {

        }
    }
}
