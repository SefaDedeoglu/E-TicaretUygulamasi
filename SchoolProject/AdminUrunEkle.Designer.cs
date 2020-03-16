namespace SchoolProject
{
    partial class AdminUrunEkle
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminUrunEkle));
            this.BackUrunEkle = new System.Windows.Forms.Button();
            this.txtUrunAdi = new System.Windows.Forms.TextBox();
            this.txtUrunFiyati = new System.Windows.Forms.TextBox();
            this.txtStok = new System.Windows.Forms.TextBox();
            this.UrunAdiLabel = new System.Windows.Forms.Label();
            this.UrunFiyatLabel = new System.Windows.Forms.Label();
            this.StokDurumuLabel = new System.Windows.Forms.Label();
            this.PicLabel = new System.Windows.Forms.Label();
            this.AgirlikLabel = new System.Windows.Forms.Label();
            this.txtAgirlik = new System.Windows.Forms.TextBox();
            this.txtPic = new System.Windows.Forms.TextBox();
            this.PicKonum = new System.Windows.Forms.Button();
            this.Pic = new System.Windows.Forms.PictureBox();
            this.data = new System.Windows.Forms.DataGridView();
            this.EkleButton = new System.Windows.Forms.Button();
            this.GuncelleButton = new System.Windows.Forms.Button();
            this.SilButton = new System.Windows.Forms.Button();
            this.OpenFile = new System.Windows.Forms.OpenFileDialog();
            this.LabelTarih = new System.Windows.Forms.Label();
            this.UrunIDLabel = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtTemiz = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Pic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.data)).BeginInit();
            this.SuspendLayout();
            // 
            // BackUrunEkle
            // 
            this.BackUrunEkle.BackColor = System.Drawing.SystemColors.Info;
            this.BackUrunEkle.Image = ((System.Drawing.Image)(resources.GetObject("BackUrunEkle.Image")));
            this.BackUrunEkle.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.BackUrunEkle.Location = new System.Drawing.Point(12, 12);
            this.BackUrunEkle.Name = "BackUrunEkle";
            this.BackUrunEkle.Size = new System.Drawing.Size(88, 50);
            this.BackUrunEkle.TabIndex = 12;
            this.BackUrunEkle.UseVisualStyleBackColor = false;
            this.BackUrunEkle.Click += new System.EventHandler(this.BackUrunEkle_Click);
            // 
            // txtUrunAdi
            // 
            this.txtUrunAdi.BackColor = System.Drawing.SystemColors.Info;
            this.txtUrunAdi.Location = new System.Drawing.Point(202, 150);
            this.txtUrunAdi.Name = "txtUrunAdi";
            this.txtUrunAdi.Size = new System.Drawing.Size(138, 20);
            this.txtUrunAdi.TabIndex = 2;
            // 
            // txtUrunFiyati
            // 
            this.txtUrunFiyati.BackColor = System.Drawing.SystemColors.Info;
            this.txtUrunFiyati.Location = new System.Drawing.Point(202, 189);
            this.txtUrunFiyati.Name = "txtUrunFiyati";
            this.txtUrunFiyati.Size = new System.Drawing.Size(138, 20);
            this.txtUrunFiyati.TabIndex = 3;
            // 
            // txtStok
            // 
            this.txtStok.BackColor = System.Drawing.SystemColors.Info;
            this.txtStok.Location = new System.Drawing.Point(202, 227);
            this.txtStok.Name = "txtStok";
            this.txtStok.Size = new System.Drawing.Size(138, 20);
            this.txtStok.TabIndex = 4;
            // 
            // UrunAdiLabel
            // 
            this.UrunAdiLabel.AutoSize = true;
            this.UrunAdiLabel.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UrunAdiLabel.Location = new System.Drawing.Point(12, 151);
            this.UrunAdiLabel.Name = "UrunAdiLabel";
            this.UrunAdiLabel.Size = new System.Drawing.Size(78, 19);
            this.UrunAdiLabel.TabIndex = 17;
            this.UrunAdiLabel.Text = "Ürün Adı";
            // 
            // UrunFiyatLabel
            // 
            this.UrunFiyatLabel.AutoSize = true;
            this.UrunFiyatLabel.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UrunFiyatLabel.Location = new System.Drawing.Point(12, 190);
            this.UrunFiyatLabel.Name = "UrunFiyatLabel";
            this.UrunFiyatLabel.Size = new System.Drawing.Size(98, 19);
            this.UrunFiyatLabel.TabIndex = 18;
            this.UrunFiyatLabel.Text = "Ürün Fiyatı";
            // 
            // StokDurumuLabel
            // 
            this.StokDurumuLabel.AutoSize = true;
            this.StokDurumuLabel.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StokDurumuLabel.Location = new System.Drawing.Point(12, 228);
            this.StokDurumuLabel.Name = "StokDurumuLabel";
            this.StokDurumuLabel.Size = new System.Drawing.Size(113, 19);
            this.StokDurumuLabel.TabIndex = 19;
            this.StokDurumuLabel.Text = "Stok Durumu";
            // 
            // PicLabel
            // 
            this.PicLabel.AutoSize = true;
            this.PicLabel.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PicLabel.Location = new System.Drawing.Point(12, 267);
            this.PicLabel.Name = "PicLabel";
            this.PicLabel.Size = new System.Drawing.Size(73, 19);
            this.PicLabel.TabIndex = 20;
            this.PicLabel.Text = "Fotoğraf";
            // 
            // AgirlikLabel
            // 
            this.AgirlikLabel.AutoSize = true;
            this.AgirlikLabel.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AgirlikLabel.Location = new System.Drawing.Point(12, 306);
            this.AgirlikLabel.Name = "AgirlikLabel";
            this.AgirlikLabel.Size = new System.Drawing.Size(109, 19);
            this.AgirlikLabel.TabIndex = 21;
            this.AgirlikLabel.Text = "Ürün Ağırlığı";
            // 
            // txtAgirlik
            // 
            this.txtAgirlik.BackColor = System.Drawing.SystemColors.Info;
            this.txtAgirlik.Location = new System.Drawing.Point(202, 305);
            this.txtAgirlik.Name = "txtAgirlik";
            this.txtAgirlik.Size = new System.Drawing.Size(138, 20);
            this.txtAgirlik.TabIndex = 7;
            // 
            // txtPic
            // 
            this.txtPic.BackColor = System.Drawing.SystemColors.Info;
            this.txtPic.Location = new System.Drawing.Point(202, 266);
            this.txtPic.Name = "txtPic";
            this.txtPic.Size = new System.Drawing.Size(138, 20);
            this.txtPic.TabIndex = 5;
            // 
            // PicKonum
            // 
            this.PicKonum.Font = new System.Drawing.Font("Rockwell Condensed", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PicKonum.Location = new System.Drawing.Point(346, 268);
            this.PicKonum.Name = "PicKonum";
            this.PicKonum.Size = new System.Drawing.Size(30, 19);
            this.PicKonum.TabIndex = 6;
            this.PicKonum.Text = "...";
            this.PicKonum.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.PicKonum.UseVisualStyleBackColor = true;
            this.PicKonum.Click += new System.EventHandler(this.PicKonum_Click);
            // 
            // Pic
            // 
            this.Pic.Location = new System.Drawing.Point(415, 12);
            this.Pic.Name = "Pic";
            this.Pic.Size = new System.Drawing.Size(442, 335);
            this.Pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Pic.TabIndex = 25;
            this.Pic.TabStop = false;
            // 
            // data
            // 
            this.data.BackgroundColor = System.Drawing.SystemColors.Info;
            this.data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data.GridColor = System.Drawing.SystemColors.Info;
            this.data.Location = new System.Drawing.Point(16, 426);
            this.data.Name = "data";
            this.data.Size = new System.Drawing.Size(841, 266);
            this.data.TabIndex = 26;
            this.data.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.data_CellClick);
            // 
            // EkleButton
            // 
            this.EkleButton.BackColor = System.Drawing.SystemColors.Info;
            this.EkleButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.EkleButton.Location = new System.Drawing.Point(16, 379);
            this.EkleButton.Name = "EkleButton";
            this.EkleButton.Size = new System.Drawing.Size(122, 41);
            this.EkleButton.TabIndex = 8;
            this.EkleButton.Text = "EKLE";
            this.EkleButton.UseVisualStyleBackColor = false;
            this.EkleButton.Click += new System.EventHandler(this.EkleButton_Click);
            // 
            // GuncelleButton
            // 
            this.GuncelleButton.BackColor = System.Drawing.SystemColors.Info;
            this.GuncelleButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.GuncelleButton.Location = new System.Drawing.Point(155, 379);
            this.GuncelleButton.Name = "GuncelleButton";
            this.GuncelleButton.Size = new System.Drawing.Size(122, 41);
            this.GuncelleButton.TabIndex = 9;
            this.GuncelleButton.Text = "GÜNCELLE";
            this.GuncelleButton.UseVisualStyleBackColor = false;
            this.GuncelleButton.Click += new System.EventHandler(this.GuncelleButton_Click);
            // 
            // SilButton
            // 
            this.SilButton.BackColor = System.Drawing.SystemColors.Info;
            this.SilButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.SilButton.Location = new System.Drawing.Point(294, 379);
            this.SilButton.Name = "SilButton";
            this.SilButton.Size = new System.Drawing.Size(122, 41);
            this.SilButton.TabIndex = 10;
            this.SilButton.Text = "SİL";
            this.SilButton.UseVisualStyleBackColor = false;
            this.SilButton.Click += new System.EventHandler(this.SilButton_Click);
            // 
            // OpenFile
            // 
            this.OpenFile.FileName = "openFileDialog1";
            this.OpenFile.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // LabelTarih
            // 
            this.LabelTarih.AutoSize = true;
            this.LabelTarih.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelTarih.Location = new System.Drawing.Point(199, 12);
            this.LabelTarih.Name = "LabelTarih";
            this.LabelTarih.Size = new System.Drawing.Size(93, 19);
            this.LabelTarih.TabIndex = 30;
            this.LabelTarih.Text = "20.07.1999";
            // 
            // UrunIDLabel
            // 
            this.UrunIDLabel.AutoSize = true;
            this.UrunIDLabel.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UrunIDLabel.Location = new System.Drawing.Point(12, 119);
            this.UrunIDLabel.Name = "UrunIDLabel";
            this.UrunIDLabel.Size = new System.Drawing.Size(70, 19);
            this.UrunIDLabel.TabIndex = 32;
            this.UrunIDLabel.Text = "Ürün ID";
            // 
            // txtId
            // 
            this.txtId.BackColor = System.Drawing.SystemColors.Info;
            this.txtId.Location = new System.Drawing.Point(202, 118);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(138, 20);
            this.txtId.TabIndex = 1;
            // 
            // txtTemiz
            // 
            this.txtTemiz.BackColor = System.Drawing.SystemColors.Info;
            this.txtTemiz.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtTemiz.Location = new System.Drawing.Point(440, 379);
            this.txtTemiz.Name = "txtTemiz";
            this.txtTemiz.Size = new System.Drawing.Size(122, 41);
            this.txtTemiz.TabIndex = 11;
            this.txtTemiz.Text = "Kutuları Temizle";
            this.txtTemiz.UseVisualStyleBackColor = false;
            this.txtTemiz.Click += new System.EventHandler(this.txtTemiz_Click);
            // 
            // AdminUrunEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(869, 704);
            this.ControlBox = false;
            this.Controls.Add(this.txtTemiz);
            this.Controls.Add(this.UrunIDLabel);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.LabelTarih);
            this.Controls.Add(this.SilButton);
            this.Controls.Add(this.GuncelleButton);
            this.Controls.Add(this.EkleButton);
            this.Controls.Add(this.data);
            this.Controls.Add(this.Pic);
            this.Controls.Add(this.PicKonum);
            this.Controls.Add(this.txtAgirlik);
            this.Controls.Add(this.txtPic);
            this.Controls.Add(this.AgirlikLabel);
            this.Controls.Add(this.PicLabel);
            this.Controls.Add(this.StokDurumuLabel);
            this.Controls.Add(this.UrunFiyatLabel);
            this.Controls.Add(this.UrunAdiLabel);
            this.Controls.Add(this.txtStok);
            this.Controls.Add(this.txtUrunFiyati);
            this.Controls.Add(this.txtUrunAdi);
            this.Controls.Add(this.BackUrunEkle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AdminUrunEkle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin Ürün Ekleme";
            this.Load += new System.EventHandler(this.AdminUrunEkle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Pic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.data)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BackUrunEkle;
        private System.Windows.Forms.TextBox txtUrunAdi;
        private System.Windows.Forms.TextBox txtUrunFiyati;
        private System.Windows.Forms.TextBox txtStok;
        private System.Windows.Forms.Label UrunAdiLabel;
        private System.Windows.Forms.Label UrunFiyatLabel;
        private System.Windows.Forms.Label StokDurumuLabel;
        private System.Windows.Forms.Label PicLabel;
        private System.Windows.Forms.Label AgirlikLabel;
        private System.Windows.Forms.TextBox txtAgirlik;
        private System.Windows.Forms.TextBox txtPic;
        private System.Windows.Forms.Button PicKonum;
        private System.Windows.Forms.PictureBox Pic;
        private System.Windows.Forms.DataGridView data;
        private System.Windows.Forms.Button EkleButton;
        private System.Windows.Forms.Button GuncelleButton;
        private System.Windows.Forms.Button SilButton;
        private System.Windows.Forms.OpenFileDialog OpenFile;
        private System.Windows.Forms.Label LabelTarih;
        private System.Windows.Forms.Label UrunIDLabel;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Button txtTemiz;
    }
}