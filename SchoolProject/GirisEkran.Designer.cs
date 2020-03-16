namespace SchoolProject
{
    partial class GirisEkran
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GirisEkran));
            this.AdminGirisButton = new System.Windows.Forms.Button();
            this.girisLabel = new System.Windows.Forms.Label();
            this.KullaniciGirisButton = new System.Windows.Forms.Button();
            this.KayitButton = new System.Windows.Forms.Button();
            this.CikisButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AdminGirisButton
            // 
            this.AdminGirisButton.BackColor = System.Drawing.SystemColors.Info;
            this.AdminGirisButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.AdminGirisButton.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.AdminGirisButton.Image = ((System.Drawing.Image)(resources.GetObject("AdminGirisButton.Image")));
            this.AdminGirisButton.Location = new System.Drawing.Point(2, 74);
            this.AdminGirisButton.Name = "AdminGirisButton";
            this.AdminGirisButton.Size = new System.Drawing.Size(297, 359);
            this.AdminGirisButton.TabIndex = 1;
            this.AdminGirisButton.Text = "ADMİN";
            this.AdminGirisButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.AdminGirisButton.UseVisualStyleBackColor = false;
            this.AdminGirisButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // girisLabel
            // 
            this.girisLabel.AutoSize = true;
            this.girisLabel.Font = new System.Drawing.Font("Georgia", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.girisLabel.Location = new System.Drawing.Point(128, 9);
            this.girisLabel.Name = "girisLabel";
            this.girisLabel.Size = new System.Drawing.Size(361, 62);
            this.girisLabel.TabIndex = 1;
            this.girisLabel.Text = "Mağazamıza Hoşgeldiniz\r\nLütfen giriş yapınız \r\n";
            this.girisLabel.Click += new System.EventHandler(this.girisLabel_Click);
            // 
            // KullaniciGirisButton
            // 
            this.KullaniciGirisButton.BackColor = System.Drawing.SystemColors.Info;
            this.KullaniciGirisButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.KullaniciGirisButton.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.KullaniciGirisButton.Image = ((System.Drawing.Image)(resources.GetObject("KullaniciGirisButton.Image")));
            this.KullaniciGirisButton.Location = new System.Drawing.Point(305, 74);
            this.KullaniciGirisButton.Name = "KullaniciGirisButton";
            this.KullaniciGirisButton.Size = new System.Drawing.Size(297, 359);
            this.KullaniciGirisButton.TabIndex = 2;
            this.KullaniciGirisButton.Text = "MÜŞTERİ";
            this.KullaniciGirisButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.KullaniciGirisButton.UseVisualStyleBackColor = false;
            this.KullaniciGirisButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // KayitButton
            // 
            this.KayitButton.BackColor = System.Drawing.SystemColors.Info;
            this.KayitButton.Location = new System.Drawing.Point(13, 13);
            this.KayitButton.Name = "KayitButton";
            this.KayitButton.Size = new System.Drawing.Size(77, 55);
            this.KayitButton.TabIndex = 3;
            this.KayitButton.Text = "KAYDOL";
            this.KayitButton.UseVisualStyleBackColor = false;
            this.KayitButton.Click += new System.EventHandler(this.KayitButton_Click);
            // 
            // CikisButton
            // 
            this.CikisButton.BackColor = System.Drawing.SystemColors.Info;
            this.CikisButton.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CikisButton.Location = new System.Drawing.Point(515, 9);
            this.CikisButton.Name = "CikisButton";
            this.CikisButton.Size = new System.Drawing.Size(75, 23);
            this.CikisButton.TabIndex = 4;
            this.CikisButton.Text = "ÇIKIŞ";
            this.CikisButton.UseVisualStyleBackColor = false;
            this.CikisButton.Click += new System.EventHandler(this.CikisButton_Click);
            // 
            // GirisEkran
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(602, 433);
            this.ControlBox = false;
            this.Controls.Add(this.CikisButton);
            this.Controls.Add(this.KayitButton);
            this.Controls.Add(this.KullaniciGirisButton);
            this.Controls.Add(this.girisLabel);
            this.Controls.Add(this.AdminGirisButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GirisEkran";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mağaza Giriş Ekranı";
            this.Load += new System.EventHandler(this.GirisEkran_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AdminGirisButton;
        private System.Windows.Forms.Label girisLabel;
        private System.Windows.Forms.Button KullaniciGirisButton;
        private System.Windows.Forms.Button KayitButton;
        private System.Windows.Forms.Button CikisButton;
    }
}