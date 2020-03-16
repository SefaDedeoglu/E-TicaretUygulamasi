using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolProject
{
    public partial class GirisEkran : Form
    {
        public GirisEkran()
        {
            InitializeComponent();

        }

        private void girisLabel_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AdminGiris adminn = new AdminGiris();
            this.Hide();
            adminn.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            KullaniciGİris kullanici = new KullaniciGİris();
            this.Hide();
            kullanici.Show();
        }

        private void KayitButton_Click(object sender, EventArgs e)
        {
            KullaniciKayit kayit = new KullaniciKayit();
            this.Hide();
            kayit.Show();
        }

        private void CikisButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Çıkmak istediğinize emin misiniz ? ", "Emin misiniz ?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
                Application.Exit();
            }
            else
            {
                this.Show();
            }
        }

        private void GirisEkran_Load(object sender, EventArgs e)
        {

        }
    }
}
