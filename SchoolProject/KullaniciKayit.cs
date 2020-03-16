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
    public partial class KullaniciKayit : Form
    {
        public KullaniciKayit()
        {
            InitializeComponent();
            KullaniciKayitSifreTextBox.Text = "";
            KullaniciKayitSifreTextBox.PasswordChar = '*';
            KullaniciKayitSifreTextBox.MaxLength = 20;
            KullaniciKayitIDTextBox.MaxLength = 20;
            SifreTekrarTextBox.Text = "";
            SifreTekrarTextBox.PasswordChar = '*';
            SifreTekrarTextBox.MaxLength = 20;
            txtAdres.MaxLength = 300;
        }

        private void KullaniciKayitButton_Click(object sender, EventArgs e)
        {
            db connect = new db();
            MySqlCommand kmt = new MySqlCommand();
            if (KullaniciKayitSifreTextBox.Text.Equals(SifreTekrarTextBox.Text))
            {
                kmt.Connection = connect.baglan();
                kmt.CommandText = "insert into girisbilgikullanici (KullaniciAdi,Sifre,Adres) values ('" + KullaniciKayitIDTextBox.Text + "','" + KullaniciKayitSifreTextBox.Text + "','" + txtAdres.Text + "')";
                object sonuc = null;
                sonuc = kmt.ExecuteNonQuery();
                if (sonuc != null)
                {
                    MessageBox.Show("Sisteme başarıyla eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    GirisEkran giris = new GirisEkran();
                    this.Hide();
                    giris.Show();
                }
                else
                {
                    MessageBox.Show("Sisteme eklenemedi.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                kmt.Connection = connect.kapat();
            }
            else
            {
                MessageBox.Show("Girilen Şifreler Birbiri İle Uyuşmuyor !");
            }
        }

        private void KullaniciKayit_Load(object sender, EventArgs e)
        {

        }

        private void BackKullaniciKayit_Click(object sender, EventArgs e)
        {
            this.Hide();
            GirisEkran giris = new GirisEkran();
            giris.Show();
        }

        private void KayitPic_Click(object sender, EventArgs e)
        {

        }
    }
}
