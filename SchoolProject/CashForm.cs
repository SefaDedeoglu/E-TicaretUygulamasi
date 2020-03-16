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
    public partial class CashForm : Form
    {
        public static Boolean kontrol = true;
        public CashForm()
        {
            InitializeComponent();
            SumLabel.Text = Store.Amount.ToString();
        }

        private void GoBackButton_Click(object sender, EventArgs e)
        {
            CashForm.kontrol = false;
            this.Hide();
            Store store = new Store();
            store.Show();
        }

        private void TextLabelSum_Click(object sender, EventArgs e)
        {

        }

        private void PayButton_Click(object sender, EventArgs e)
        {
            int verilen = Convert.ToInt32(ReceivedTextBox.Text);
            if (verilen >= Store.Amount)
            {
                MessageBox.Show("Ödeme gerçekleşti\nPara üstü = " + Convert.ToString(verilen - Store.Amount), "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                kontrol = true;
                this.Hide();
                Store store = new Store();
                store.Show();

            }
            else
            {
                MessageBox.Show("Eksik Ücret Verdiniz ", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                kontrol = false;
            }
        }

        private void CashForm_Load(object sender, EventArgs e)
        {
            kontrol = false; 
        }
    }
}
