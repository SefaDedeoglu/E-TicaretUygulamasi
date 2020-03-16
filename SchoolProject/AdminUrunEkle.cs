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
    public partial class AdminUrunEkle : Form
    {
        db connect = new db();
        MySqlCommand kmt = new MySqlCommand();
        DataTable datatb = new DataTable();
        MySqlDataAdapter adapter = new MySqlDataAdapter();
        public AdminUrunEkle()
        {
            InitializeComponent();
            dbveri();
        }
        public void dbveri()
        {
            Pic.ImageLocation = "";
            txtId.Text = "";
            txtUrunAdi.Text = "";
            txtUrunFiyati.Text = "";
            txtStok.Text = "";
            txtPic.Text = "";
            txtAgirlik.Text = "";
            datatb.Clear();
            LabelTarih.Text = "";
            kmt.Connection = connect.baglan();
            kmt.CommandText = "select * from ürünler";
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

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void PicKonum_Click(object sender, EventArgs e)
        {
            OpenFile.ShowDialog();
            Pic.ImageLocation = OpenFile.FileName.ToString();
            txtPic.Text = OpenFile.FileName.ToString();
            txtPic.Text=txtPic.Text.Replace("\\","/");
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void AdminUrunEkle_Load(object sender, EventArgs e)
        {

        }

        private void data_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = data.SelectedCells[0].RowIndex;
            txtUrunAdi.Text = data.Rows[secilen].Cells[1].Value.ToString();
            txtUrunFiyati.Text = data.Rows[secilen].Cells[2].Value.ToString();
            if (data.Rows[secilen].Cells[3].Value.ToString().Equals("True"))
            {
                txtStok.Text = "1";
            }
            else
            {
                txtStok.Text = "0";
            }
            Pic.ImageLocation = data.Rows[secilen].Cells[4].Value.ToString();
            txtPic.Text = data.Rows[secilen].Cells[4].Value.ToString();
            txtAgirlik.Text = data.Rows[secilen].Cells[5].Value.ToString();
            txtId.Text = data.Rows[secilen].Cells[0].Value.ToString();
            txtPic.Text = txtPic.Text.Replace("\\", "/");
        }

        private void EkleButton_Click(object sender, EventArgs e)
        {
            
            kmt.Connection = connect.baglan();
            txtPic.Text = txtPic.Text.Replace("\\", "/");
            kmt.CommandText = "INSERT INTO `ürünler` (`id`, `Ürün Adı`, `Ürün Fiyatı`, `Stok Durumu`, `UrunPic`, `UrunAgirlik`) VALUES ('"+txtId.Text+"', '"+txtUrunAdi.Text+"', '"+txtUrunFiyati.Text+"', '"+txtStok.Text+"', '"+txtPic.Text+"', '"+txtAgirlik.Text+"')";
             object sonuc = null;
             sonuc = kmt.ExecuteNonQuery();
             if (sonuc != null)
            {
                MessageBox.Show("Sisteme başarıyla eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Sisteme eklenemedi.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            kmt.Connection = connect.kapat();
         
            dbveri();
        }

        private void GuncelleButton_Click(object sender, EventArgs e)
        {
            kmt.Connection = connect.baglan();
            kmt.CommandText = "UPDATE `ürünler` SET `Ürün Adı` = '"+txtUrunAdi.Text+"', `Ürün Fiyatı` = '"+txtUrunFiyati.Text+"', `Stok Durumu` = '"+txtStok.Text+"', `UrunPic` = '"+txtPic.Text+"', `UrunAgirlik` = '"+txtAgirlik.Text+"' WHERE `ürünler`.`id` = '"+txtId.Text+"'";
            kmt.ExecuteNonQuery();
            kmt.Dispose();
            MessageBox.Show("Güncelleme İşlemi Başarılı");
            kmt.Connection = connect.kapat();
            dbveri();
        }

        private void SilButton_Click(object sender, EventArgs e)
        {
            kmt.Connection = connect.baglan();
            kmt.CommandText = "DELETE FROM `ürünler` WHERE `ürünler`.`id` = '"+txtId.Text+"'";
            kmt.ExecuteNonQuery();
            kmt.Connection = connect.kapat();
            MessageBox.Show("Kayıt silinmiştir", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            dbveri();
        }

        private void BackUrunEkle_Click(object sender, EventArgs e)
        {
            this.Hide();
            YönetimPaneli panel = new YönetimPaneli();
            panel.Show();
        }

        private void txtTemiz_Click(object sender, EventArgs e)
        {
            dbveri();
        }
    }
}
