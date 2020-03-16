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
    public partial class CheckForm : Form
    {
        public CheckForm()
        {
            InitializeComponent();
            TotalLabelCheck.Text = Store.Amount.ToString();
            txtIsim.Text = "";
            txtBankID.Text = "";

        }

        private void BackButtonCheck_Click(object sender, EventArgs e)
        {
            this.Hide();
            Store store = new Store();
            store.Show();
        }

        private void PayButtonCheck_Click(object sender, EventArgs e)
        {
            if (txtIsim.Text.Equals("") || txtBankID.Text.Equals(""))
            {
                MessageBox.Show("Bu Alanlar Boş Bırakılamaz !", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show("ÖDEME BAŞARILI", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                Store store = new Store();
                store.Show();
            }
        }
    }
}
