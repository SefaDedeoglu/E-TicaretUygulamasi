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
    public partial class KullaniciListele : Form
    {
        db connect = new db();
        MySqlCommand kmt = new MySqlCommand();
        DataTable datatb = new DataTable();
        MySqlDataAdapter adapter = new MySqlDataAdapter();
        public void dbveri()
        {
            txtID.Text = "";
            txtKullaniciAdi.Text = "";
            txtSifre.Text = "";
            datatb.Clear();
            LabelTarih.Text = "";
            kmt.Connection = connect.baglan();
            kmt.CommandText = "select * from girisbilgikullanici";
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
        public KullaniciListele()
        {
            InitializeComponent();
            dbveri();
        }

        private void geriButtonKullaniciListe_Click(object sender, EventArgs e)
        {
            this.Hide();
            YönetimPaneli yönetim = new YönetimPaneli();
            yönetim.Show();
        }

        private void data_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = data.SelectedCells[0].RowIndex;
            txtID.Text = data.Rows[secilen].Cells[0].Value.ToString();
            txtKullaniciAdi.Text = data.Rows[secilen].Cells[1].Value.ToString();
            txtSifre.Text = data.Rows[secilen].Cells[2].Value.ToString();
        }

        private void KullaniciSilButton_Click(object sender, EventArgs e)
        {
            kmt.Connection = connect.baglan();
            kmt.CommandText = "DELETE FROM `girisbilgikullanici` WHERE `girisbilgikullanici`.`id` = '" + txtID.Text + "'";
            kmt.ExecuteNonQuery();
            kmt.Connection = connect.kapat();
            MessageBox.Show("Kayıt silinmiştir", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            dbveri();
        }
    }
}
