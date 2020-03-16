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
    public partial class CreditCardForm : Form
    {
        public CreditCardForm()
        {
            InitializeComponent();
            CashForm.kontrol = true;
            TotalLabelCC.Text = Store.Amount.ToString();
            txtKartNo.Text = "";
            txtKartSKTT.Text = "";
            txtKartType.Text = "";
            txtKartNo.MaxLength = 16;
            txtKartType.MaxLength = 15;
            txtKartSKTT.MaxLength = 10;
        }

        private void BackButtonCC_Click(object sender, EventArgs e)
        {
            CashForm.kontrol = false;
            this.Hide();
            Store store = new Store();
            store.Show();
        }

        private void CreditCardForm_Load(object sender, EventArgs e)
        {

        }
        public void girissorgula()
        {
            db connect = new db();
            MySqlCommand kmt = new MySqlCommand();
            MySqlDataReader dr;
            kmt.Connection = connect.baglan();
            kmt.CommandText = "Select * FROM kredikart where KartNo = '" + txtKartNo.Text + "' AND KartTip = '" + txtKartType.Text + "' AND sktt = '"+txtKartSKTT.Text+"'";
            dr = kmt.ExecuteReader();
            if (dr.Read())
            {
                MessageBox.Show("ÖDEME BAŞARILI", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CashForm.kontrol = true;
                this.Hide();
                Store store = new Store();
                store.Show();
            }
            else
            {
                MessageBox.Show("Bilgiler yanlış !", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            kmt.Connection = connect.kapat();

        }
        private void PayButtonCC_Click(object sender, EventArgs e)
        {
            if (txtKartNo.Text.Equals("") || txtKartSKTT.Text.Equals("")||txtKartType.Text.Equals(""))
            {
                MessageBox.Show("Bu Alanlar Boş Bırakılamaz !", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                girissorgula();
            }
        }
    }
}
