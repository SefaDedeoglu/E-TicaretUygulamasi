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
    public partial class YönetimPaneli : Form
    {
        public YönetimPaneli()
        {
            InitializeComponent();
        }

        private void geributtonyp_Click(object sender, EventArgs e)
        {
            this.Hide();
            GirisEkran giris = new GirisEkran();
            giris.Show();
        }

        private void ButtonUrün_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminUrunEkle ekle = new AdminUrunEkle();
            ekle.Show();
        }

        private void ButtonSiparis_Click(object sender, EventArgs e)
        {
            this.Hide();
            SiparisBilgileri siparis = new SiparisBilgileri();
            siparis.Show();
        }

        private void ButtonListele_Click(object sender, EventArgs e)
        {
            this.Hide();
            KullaniciListele liste = new KullaniciListele();
            liste.Show();
        }
    }
}
