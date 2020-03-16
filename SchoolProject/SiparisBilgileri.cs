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
    public partial class SiparisBilgileri : Form
    {
        db connect = new db();
        MySqlCommand kmt = new MySqlCommand();
        DataTable datatb = new DataTable();
        MySqlDataAdapter adapter = new MySqlDataAdapter();
        string deger;
        public void dbveri()
        {
            txtID.Text = "";
            txtAdres.Text = "";
            txtKullaniciAdi.Text = "";
            txtUrünler.Text = "";
            datatb.Clear();
            LabelTarih.Text = "";
            kmt.Connection = connect.baglan();
            kmt.CommandText = "select * from siparisbilgi";
            adapter.SelectCommand = kmt;
            adapter.Fill(datatb);
            data.DataSource = datatb;
            data.RowHeadersVisible = false;
            LabelTarih.Text = DateTime.Now.ToShortDateString();
            data.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            data.AllowUserToAddRows = false;
            data.AllowUserToDeleteRows = false;
            data.ReadOnly = true;
            kmt.Connection = connect.kapat();
        }
        public SiparisBilgileri()
        {
            InitializeComponent();
            dbveri(); 
            SilSiparis.Enabled = false;
        }

        private void backButtonSiparisBilgi_Click(object sender, EventArgs e)
        {
            this.Hide();
            YönetimPaneli yönet = new YönetimPaneli();
            yönet.Show();
        }

        private void data_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = data.SelectedCells[0].RowIndex;
            txtKullaniciAdi.Text = data.Rows[secilen].Cells[1].Value.ToString();
            txtAdres.Text = data.Rows[secilen].Cells[3].Value.ToString();
            txtUrünler.Text = data.Rows[secilen].Cells[4].Value.ToString();
            deger = data.Rows[secilen].Cells[0].Value.ToString();
            txtID.Text = deger;
            txtSipTarih.Text = data.Rows[secilen].Cells[2].Value.ToString();
            SilSiparis.Enabled = true;
        }

        private void SilSiparis_Click(object sender, EventArgs e)
        {
            kmt.Connection = connect.baglan();
            kmt.CommandText = "DELETE FROM `siparisbilgi` WHERE `siparisbilgi`.`id` = '" + deger + "'";
            kmt.ExecuteNonQuery();
            kmt.Connection = connect.kapat();
            MessageBox.Show("Kayıt silinmiştir", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            dbveri();
            SilSiparis.Enabled = false;
        }
    }
}
