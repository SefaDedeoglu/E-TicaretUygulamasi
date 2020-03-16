namespace SchoolProject
{
    partial class KullaniciListele
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KullaniciListele));
            this.geriButtonKullaniciListe = new System.Windows.Forms.Button();
            this.LabelTarih = new System.Windows.Forms.Label();
            this.LblID = new System.Windows.Forms.Label();
            this.LblKullaniciAdi = new System.Windows.Forms.Label();
            this.LblSifre = new System.Windows.Forms.Label();
            this.txtSifre = new System.Windows.Forms.Label();
            this.txtKullaniciAdi = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.Label();
            this.data = new System.Windows.Forms.DataGridView();
            this.KullaniciSilButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.data)).BeginInit();
            this.SuspendLayout();
            // 
            // geriButtonKullaniciListe
            // 
            this.geriButtonKullaniciListe.BackColor = System.Drawing.SystemColors.Info;
            this.geriButtonKullaniciListe.Image = ((System.Drawing.Image)(resources.GetObject("geriButtonKullaniciListe.Image")));
            this.geriButtonKullaniciListe.Location = new System.Drawing.Point(12, 12);
            this.geriButtonKullaniciListe.Name = "geriButtonKullaniciListe";
            this.geriButtonKullaniciListe.Size = new System.Drawing.Size(89, 47);
            this.geriButtonKullaniciListe.TabIndex = 2;
            this.geriButtonKullaniciListe.UseVisualStyleBackColor = false;
            this.geriButtonKullaniciListe.Click += new System.EventHandler(this.geriButtonKullaniciListe_Click);
            // 
            // LabelTarih
            // 
            this.LabelTarih.AutoSize = true;
            this.LabelTarih.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelTarih.Location = new System.Drawing.Point(684, 9);
            this.LabelTarih.Name = "LabelTarih";
            this.LabelTarih.Size = new System.Drawing.Size(104, 23);
            this.LabelTarih.TabIndex = 1;
            this.LabelTarih.Text = "20.07.1999";
            // 
            // LblID
            // 
            this.LblID.AutoSize = true;
            this.LblID.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblID.Location = new System.Drawing.Point(218, 82);
            this.LblID.Name = "LblID";
            this.LblID.Size = new System.Drawing.Size(32, 23);
            this.LblID.TabIndex = 2;
            this.LblID.Text = "ID";
            // 
            // LblKullaniciAdi
            // 
            this.LblKullaniciAdi.AutoSize = true;
            this.LblKullaniciAdi.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblKullaniciAdi.Location = new System.Drawing.Point(218, 118);
            this.LblKullaniciAdi.Name = "LblKullaniciAdi";
            this.LblKullaniciAdi.Size = new System.Drawing.Size(136, 23);
            this.LblKullaniciAdi.TabIndex = 3;
            this.LblKullaniciAdi.Text = "Kullanıcı Adı";
            // 
            // LblSifre
            // 
            this.LblSifre.AutoSize = true;
            this.LblSifre.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblSifre.Location = new System.Drawing.Point(218, 153);
            this.LblSifre.Name = "LblSifre";
            this.LblSifre.Size = new System.Drawing.Size(55, 23);
            this.LblSifre.TabIndex = 4;
            this.LblSifre.Text = "Şifre";
            // 
            // txtSifre
            // 
            this.txtSifre.AutoSize = true;
            this.txtSifre.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSifre.Location = new System.Drawing.Point(370, 153);
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.Size = new System.Drawing.Size(0, 23);
            this.txtSifre.TabIndex = 7;
            // 
            // txtKullaniciAdi
            // 
            this.txtKullaniciAdi.AutoSize = true;
            this.txtKullaniciAdi.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKullaniciAdi.Location = new System.Drawing.Point(370, 118);
            this.txtKullaniciAdi.Name = "txtKullaniciAdi";
            this.txtKullaniciAdi.Size = new System.Drawing.Size(0, 23);
            this.txtKullaniciAdi.TabIndex = 6;
            // 
            // txtID
            // 
            this.txtID.AutoSize = true;
            this.txtID.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.Location = new System.Drawing.Point(370, 82);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(0, 23);
            this.txtID.TabIndex = 5;
            // 
            // data
            // 
            this.data.BackgroundColor = System.Drawing.SystemColors.Info;
            this.data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data.GridColor = System.Drawing.SystemColors.Info;
            this.data.Location = new System.Drawing.Point(12, 201);
            this.data.Name = "data";
            this.data.Size = new System.Drawing.Size(776, 237);
            this.data.TabIndex = 8;
            this.data.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.data_CellClick);
            // 
            // KullaniciSilButton
            // 
            this.KullaniciSilButton.BackColor = System.Drawing.SystemColors.Info;
            this.KullaniciSilButton.Location = new System.Drawing.Point(685, 152);
            this.KullaniciSilButton.Name = "KullaniciSilButton";
            this.KullaniciSilButton.Size = new System.Drawing.Size(103, 43);
            this.KullaniciSilButton.TabIndex = 1;
            this.KullaniciSilButton.Text = "SİL";
            this.KullaniciSilButton.UseVisualStyleBackColor = false;
            this.KullaniciSilButton.Click += new System.EventHandler(this.KullaniciSilButton_Click);
            // 
            // KullaniciListele
            // 
            this.AcceptButton = this.KullaniciSilButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.KullaniciSilButton);
            this.Controls.Add(this.data);
            this.Controls.Add(this.txtSifre);
            this.Controls.Add(this.txtKullaniciAdi);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.LblSifre);
            this.Controls.Add(this.LblKullaniciAdi);
            this.Controls.Add(this.LblID);
            this.Controls.Add(this.LabelTarih);
            this.Controls.Add(this.geriButtonKullaniciListe);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "KullaniciListele";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kullanıcı Listele";
            ((System.ComponentModel.ISupportInitialize)(this.data)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button geriButtonKullaniciListe;
        private System.Windows.Forms.Label LabelTarih;
        private System.Windows.Forms.Label LblID;
        private System.Windows.Forms.Label LblKullaniciAdi;
        private System.Windows.Forms.Label LblSifre;
        private System.Windows.Forms.Label txtSifre;
        private System.Windows.Forms.Label txtKullaniciAdi;
        private System.Windows.Forms.Label txtID;
        private System.Windows.Forms.DataGridView data;
        private System.Windows.Forms.Button KullaniciSilButton;
    }
}