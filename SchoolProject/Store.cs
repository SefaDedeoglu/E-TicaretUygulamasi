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
    public partial class Store : Form
    {
        DataGridViewCellStyle stil = new DataGridViewCellStyle();
        db connect = new db();
        MySqlCommand kmt = new MySqlCommand();
        DataTable datatable = new DataTable();
        MySqlDataAdapter adapter = new MySqlDataAdapter();
        public static int Amount;
        string Sbilgi = "" , agirlik;
        int TotalTutarGecici, TotalAgirlikGecici,TotalTutar,TotalAgirlik;
        string sonkayitID;
        public void dbveri()
        {

            urundatalabel.Text = "";
            urunfiyatdatalabel.Text = "";
            urunstokdatalabel.Text = "";
            datatable.Clear();
            tarihlabel.Text = "";
            kmt.Connection = connect.baglan();
            kmt.CommandText = "select * from ürünler";
            adapter.SelectCommand = kmt;
            adapter.Fill(datatable);
            DATA.DataSource = datatable;
            DATA.RowHeadersVisible = false;
            tarihlabel.Text = DateTime.Now.ToShortDateString();
            DATA.Columns[0].Visible = false;
            DATA.Columns[4].Visible = false;
            DATA.Columns[5].Visible = false;
            DATA.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DATA.AllowUserToAddRows = false;
            DATA.AllowUserToDeleteRows = false;
            DATA.ReadOnly = true;
            kmt.Connection = connect.kapat();
        }
        public void dbveriforsepet()
        {
            DataTable dtb = new DataTable();
            dtb.Clear();
            kmt.Connection = connect.baglan();
            kmt.CommandText = "select * from sepet";
            adapter.SelectCommand = kmt;
            adapter.Fill(dtb);
            sepetdtg.DataSource = dtb;
            sepetdtg.RowHeadersVisible = false;
            sepetdtg.Columns[0].Visible = false;
            sepetdtg.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            sepetdtg.AllowUserToAddRows = false;
            sepetdtg.AllowUserToDeleteRows = false;
            sepetdtg.ReadOnly = true;
            kmt.Connection = connect.kapat();
        }
        public void dbverisiparisbilgi()
        {
            DataTable datasorgu = new DataTable();
            kmt.Connection = connect.baglan();
            kmt.CommandText = "SELECT  * FROM siparisbilgi order by id desc";
            adapter.SelectCommand = kmt;
            adapter.Fill(datasorgu);
            datasorgu1.DataSource = datasorgu;
            sonkayitID= datasorgu1.Rows[0].Cells[0].Value.ToString();
            kmt.Connection = connect.kapat();
        }


        public Store()
        {
            InitializeComponent();
            dbverisiparisbilgi();
            if (CashForm.kontrol == false)
            {
                kmt.Connection = connect.baglan();
                kmt.CommandText = "DELETE FROM `siparisbilgi` WHERE `siparisbilgi`.`id` = '" + sonkayitID + "'";
                kmt.ExecuteNonQuery();
                kmt.Connection = connect.kapat();
                MessageBox.Show("Ödeme Yapılmadı !", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            dbveri();
            dbveriforsepet();
            bosaltmafonk();
            ForNameLabel.Text = "Hoşgeldiniz " + KullaniciGİris.ad;
            AdresLabel.Text = "Adres : " +KullaniciGİris.adres;
        }
        private void Store_Load(object sender, EventArgs e)
        {
            int deger = DATA.RowCount, i;
            stil.BackColor = Color.Bisque;
            for (i = 0; i < deger; i++)
            {
                DATA.Rows[i].DefaultCellStyle = stil;
            }
            SepeteEkleButton.Enabled = false;

        }

        private void DATA_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            int secilen = DATA.SelectedCells[0].RowIndex;
            urundatalabel.Text = DATA.Rows[secilen].Cells[1].Value.ToString();
            urunfiyatdatalabel.Text = DATA.Rows[secilen].Cells[2].Value.ToString();
            
            if ((DATA.Rows[secilen].Cells[3].Value.ToString()).Equals("True"))
            {
                SepeteEkleButton.Enabled = true;
                urunstokdatalabel.Text = "Stokta var ";
            }
            else
            {
                SepeteEkleButton.Enabled = false;
                urunstokdatalabel.Text = "Stokta yok ";
            }
            DataPic.ImageLocation = DATA.Rows[secilen].Cells[4].Value.ToString();
            agirlik =   DATA.Rows[secilen].Cells[5].Value.ToString();
            int deger = DATA.RowCount, i;
            stil.BackColor = Color.Bisque;
            for (i = 0; i < deger; i++)
            {
                DATA.Rows[i].DefaultCellStyle = stil;
            }
            TotalAgirlikGecici = Convert.ToInt32(DATA.Rows[secilen].Cells[5].Value);
            TotalTutarGecici = Convert.ToInt32(DATA.Rows[secilen].Cells[2].Value);
            

        }
        private void DataPic_Click(object sender, EventArgs e)
        {

        }

        private void DATA_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void SepeteEkleButton_Click(object sender, EventArgs e)
        {

                kmt.Connection = connect.baglan();
                kmt.CommandText = "INSERT INTO `sepet` ( `Ürün Adı`, `Ürün Fiyatı`) VALUES( '" + urundatalabel.Text + "', '" + urunfiyatdatalabel.Text + "')";
                object sonuc = null;
                sonuc = kmt.ExecuteNonQuery();
                if (sonuc != null)
                {
                    MessageBox.Show("Sepete Başarıyla Eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Bir hata oluştu", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                Sbilgi += "Ürün Adı : " + urundatalabel.Text+ 
                    " ÜrünFiyatı : " + urunfiyatdatalabel.Text+
                    " Ürün Ağırlığı : "+agirlik+Environment.NewLine+" ";
                TotalAgirlik += TotalAgirlikGecici;
                TotalTutar += TotalTutarGecici;
                kmt.Connection = connect.kapat();
                dbveriforsepet();
                Amount += Convert.ToInt32(urunfiyatdatalabel.Text);
                AmountLabel.Text = Amount.ToString();
        }
        public void bosaltmafonk()
        {
            kmt.Connection = connect.baglan();
            kmt.CommandText = "	TRUNCATE TABLE sepet";
            kmt.ExecuteNonQuery();
            kmt.Connection = connect.kapat();
            Amount = 0;
            AmountLabel.Text = Amount.ToString();
            dbveriforsepet();
        }
        private void SepetBosButton_Click(object sender, EventArgs e)
        {
            Sbilgi = "";
            TotalAgirlik = 0;
            TotalTutar = 0;
            bosaltmafonk();
        }

        private void ode_Click(object sender, EventArgs e)
        {
            if (Amount == 0)
            {
                MessageBox.Show("Sepetiniz Boş", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (!Sbilgi.Equals(""))
                {
                    Sbilgi += Environment.NewLine+Environment.NewLine + "Toplam Fiyat :  " + TotalTutar + " Toplam Ağırlık : " + TotalAgirlik;
                    kmt.Connection = connect.baglan();
                    kmt.CommandText = "INSERT INTO `siparisbilgi` ( `KullaniciAdi`,`tarih`, `Adres`,`SiparisBilgi`) VALUES( '" + KullaniciGİris.ad + "', '" + tarihlabel.Text  + "', '" + KullaniciGİris.adres + "','" + Sbilgi + "')";
                    object sonuc = null;
                    sonuc = kmt.ExecuteNonQuery();
                    kmt.Connection = connect.kapat();
                }
                this.Hide();
                payment py = new payment();
                py.Show();
            }
        }

        private void BackStoreButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            GirisEkran giris = new GirisEkran();
            giris.Show();
        }
    }
}
