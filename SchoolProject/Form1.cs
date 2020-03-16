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
    public partial class payment : Form
    {
        public payment()
        {
            InitializeComponent();
        }

        private void CreditCard_Click(object sender, EventArgs e)
        {
            CreditCardForm CCfrm = new CreditCardForm();
            this.Hide();
            CCfrm.Show();
        }

        private void Cash_Click(object sender, EventArgs e)
        {
            CashForm cashfrm = new CashForm();
            this.Hide();
            cashfrm.Show();
        }

        private void Check_Click(object sender, EventArgs e)
        {
            this.Hide();
            CheckForm chform = new CheckForm();
            chform.Show();
        }
    }
}
