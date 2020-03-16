namespace SchoolProject
{
    partial class SiparisBilgileri
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SiparisBilgileri));
            this.data = new System.Windows.Forms.DataGridView();
            this.backButtonSiparisBilgi = new System.Windows.Forms.Button();
            this.LabelTarih = new System.Windows.Forms.Label();
            this.SilSiparis = new System.Windows.Forms.Button();
            this.txtKullaniciAdi = new System.Windows.Forms.TextBox();
            this.txtAdres = new System.Windows.Forms.TextBox();
            this.txtUrünler = new System.Windows.Forms.TextBox();
            this.SBLabelKullaniciAdi = new System.Windows.Forms.Label();
            this.SBLabelUrünler = new System.Windows.Forms.Label();
            this.SBLabelAdres = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.Label();
            this.IdGosterLBL = new System.Windows.Forms.Label();
            this.sipTarih = new System.Windows.Forms.Label();
            this.txtSipTarih = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.data)).BeginInit();
            this.SuspendLayout();
            // 
            // data
            // 
            this.data.BackgroundColor = System.Drawing.SystemColors.Info;
            this.data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data.GridColor = System.Drawing.SystemColors.Info;
            this.data.Location = new System.Drawing.Point(12, 373);
            this.data.Name = "data";
            this.data.Size = new System.Drawing.Size(869, 298);
            this.data.TabIndex = 0;
            this.data.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.data_CellClick);
            // 
            // backButtonSiparisBilgi
            // 
            this.backButtonSiparisBilgi.BackColor = System.Drawing.SystemColors.Info;
            this.backButtonSiparisBilgi.Image = ((System.Drawing.Image)(resources.GetObject("backButtonSiparisBilgi.Image")));
            this.backButtonSiparisBilgi.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.backButtonSiparisBilgi.Location = new System.Drawing.Point(12, 13);
            this.backButtonSiparisBilgi.Name = "backButtonSiparisBilgi";
            this.backButtonSiparisBilgi.Size = new System.Drawing.Size(91, 51);
            this.backButtonSiparisBilgi.TabIndex = 2;
            this.backButtonSiparisBilgi.UseVisualStyleBackColor = false;
            this.backButtonSiparisBilgi.Click += new System.EventHandler(this.backButtonSiparisBilgi_Click);
            // 
            // LabelTarih
            // 
            this.LabelTarih.AutoSize = true;
            this.LabelTarih.Font = new System.Drawing.Font("Rockwell", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelTarih.Location = new System.Drawing.Point(728, 9);
            this.LabelTarih.Name = "LabelTarih";
            this.LabelTarih.Size = new System.Drawing.Size(153, 34);
            this.LabelTarih.TabIndex = 2;
            this.LabelTarih.Text = "20.07.1999";
            // 
            // SilSiparis
            // 
            this.SilSiparis.BackColor = System.Drawing.SystemColors.Info;
            this.SilSiparis.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SilSiparis.Location = new System.Drawing.Point(745, 329);
            this.SilSiparis.Name = "SilSiparis";
            this.SilSiparis.Size = new System.Drawing.Size(136, 38);
            this.SilSiparis.TabIndex = 1;
            this.SilSiparis.Text = "GÖNDERİLDİ +";
            this.SilSiparis.UseVisualStyleBackColor = false;
            this.SilSiparis.Click += new System.EventHandler(this.SilSiparis_Click);
            // 
            // txtKullaniciAdi
            // 
            this.txtKullaniciAdi.BackColor = System.Drawing.SystemColors.Info;
            this.txtKullaniciAdi.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKullaniciAdi.Location = new System.Drawing.Point(364, 56);
            this.txtKullaniciAdi.Name = "txtKullaniciAdi";
            this.txtKullaniciAdi.Size = new System.Drawing.Size(352, 23);
            this.txtKullaniciAdi.TabIndex = 4;
            // 
            // txtAdres
            // 
            this.txtAdres.BackColor = System.Drawing.SystemColors.Info;
            this.txtAdres.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAdres.Location = new System.Drawing.Point(364, 98);
            this.txtAdres.Multiline = true;
            this.txtAdres.Name = "txtAdres";
            this.txtAdres.Size = new System.Drawing.Size(352, 45);
            this.txtAdres.TabIndex = 5;
            // 
            // txtUrünler
            // 
            this.txtUrünler.BackColor = System.Drawing.SystemColors.Info;
            this.txtUrünler.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUrünler.Location = new System.Drawing.Point(364, 158);
            this.txtUrünler.Multiline = true;
            this.txtUrünler.Name = "txtUrünler";
            this.txtUrünler.Size = new System.Drawing.Size(352, 209);
            this.txtUrünler.TabIndex = 6;
            // 
            // SBLabelKullaniciAdi
            // 
            this.SBLabelKullaniciAdi.AutoSize = true;
            this.SBLabelKullaniciAdi.Font = new System.Drawing.Font("Rockwell", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SBLabelKullaniciAdi.Location = new System.Drawing.Point(130, 56);
            this.SBLabelKullaniciAdi.Name = "SBLabelKullaniciAdi";
            this.SBLabelKullaniciAdi.Size = new System.Drawing.Size(124, 24);
            this.SBLabelKullaniciAdi.TabIndex = 7;
            this.SBLabelKullaniciAdi.Text = "Kullanıcı Adı";
            // 
            // SBLabelUrünler
            // 
            this.SBLabelUrünler.AutoSize = true;
            this.SBLabelUrünler.Font = new System.Drawing.Font("Rockwell", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SBLabelUrünler.Location = new System.Drawing.Point(130, 158);
            this.SBLabelUrünler.Name = "SBLabelUrünler";
            this.SBLabelUrünler.Size = new System.Drawing.Size(228, 24);
            this.SBLabelUrünler.TabIndex = 8;
            this.SBLabelUrünler.Text = "Ürünler | Fiyat | Ağırlık";
            // 
            // SBLabelAdres
            // 
            this.SBLabelAdres.AutoSize = true;
            this.SBLabelAdres.Font = new System.Drawing.Font("Rockwell", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SBLabelAdres.Location = new System.Drawing.Point(130, 98);
            this.SBLabelAdres.Name = "SBLabelAdres";
            this.SBLabelAdres.Size = new System.Drawing.Size(60, 24);
            this.SBLabelAdres.TabIndex = 9;
            this.SBLabelAdres.Text = "Adres";
            // 
            // txtID
            // 
            this.txtID.AutoSize = true;
            this.txtID.Font = new System.Drawing.Font("Rockwell", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.Location = new System.Drawing.Point(196, 13);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(0, 24);
            this.txtID.TabIndex = 10;
            // 
            // IdGosterLBL
            // 
            this.IdGosterLBL.AutoSize = true;
            this.IdGosterLBL.Font = new System.Drawing.Font("Rockwell", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IdGosterLBL.Location = new System.Drawing.Point(130, 13);
            this.IdGosterLBL.Name = "IdGosterLBL";
            this.IdGosterLBL.Size = new System.Drawing.Size(60, 24);
            this.IdGosterLBL.TabIndex = 11;
            this.IdGosterLBL.Text = "ID =  ";
            // 
            // sipTarih
            // 
            this.sipTarih.AutoSize = true;
            this.sipTarih.Font = new System.Drawing.Font("Rockwell", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sipTarih.Location = new System.Drawing.Point(12, 343);
            this.sipTarih.Name = "sipTarih";
            this.sipTarih.Size = new System.Drawing.Size(141, 24);
            this.sipTarih.TabIndex = 12;
            this.sipTarih.Text = "Sipariş Tarihi  ";
            // 
            // txtSipTarih
            // 
            this.txtSipTarih.AutoSize = true;
            this.txtSipTarih.Font = new System.Drawing.Font("Rockwell", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSipTarih.Location = new System.Drawing.Point(159, 343);
            this.txtSipTarih.Name = "txtSipTarih";
            this.txtSipTarih.Size = new System.Drawing.Size(0, 24);
            this.txtSipTarih.TabIndex = 13;
            // 
            // SiparisBilgileri
            // 
            this.AcceptButton = this.SilSiparis;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(893, 683);
            this.ControlBox = false;
            this.Controls.Add(this.txtSipTarih);
            this.Controls.Add(this.sipTarih);
            this.Controls.Add(this.IdGosterLBL);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.SBLabelAdres);
            this.Controls.Add(this.SBLabelUrünler);
            this.Controls.Add(this.SBLabelKullaniciAdi);
            this.Controls.Add(this.txtUrünler);
            this.Controls.Add(this.txtAdres);
            this.Controls.Add(this.txtKullaniciAdi);
            this.Controls.Add(this.SilSiparis);
            this.Controls.Add(this.LabelTarih);
            this.Controls.Add(this.backButtonSiparisBilgi);
            this.Controls.Add(this.data);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SiparisBilgileri";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sipariş Bilgileri";
            ((System.ComponentModel.ISupportInitialize)(this.data)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView data;
        private System.Windows.Forms.Button backButtonSiparisBilgi;
        private System.Windows.Forms.Label LabelTarih;
        private System.Windows.Forms.Button SilSiparis;
        private System.Windows.Forms.TextBox txtKullaniciAdi;
        private System.Windows.Forms.TextBox txtAdres;
        private System.Windows.Forms.TextBox txtUrünler;
        private System.Windows.Forms.Label SBLabelKullaniciAdi;
        private System.Windows.Forms.Label SBLabelUrünler;
        private System.Windows.Forms.Label SBLabelAdres;
        private System.Windows.Forms.Label txtID;
        private System.Windows.Forms.Label IdGosterLBL;
        private System.Windows.Forms.Label sipTarih;
        private System.Windows.Forms.Label txtSipTarih;
    }
}