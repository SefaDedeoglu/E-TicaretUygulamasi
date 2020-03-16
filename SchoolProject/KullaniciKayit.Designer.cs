namespace SchoolProject
{
    partial class KullaniciKayit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KullaniciKayit));
            this.KullaniciKayitButton = new System.Windows.Forms.Button();
            this.KullaniciKayitIDTextBox = new System.Windows.Forms.TextBox();
            this.KullaniciKayitSifreTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SifreTekrarTextBox = new System.Windows.Forms.TextBox();
            this.KayitPic = new System.Windows.Forms.PictureBox();
            this.BackKullaniciKayit = new System.Windows.Forms.Button();
            this.AdresLabel = new System.Windows.Forms.Label();
            this.txtAdres = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.KayitPic)).BeginInit();
            this.SuspendLayout();
            // 
            // KullaniciKayitButton
            // 
            this.KullaniciKayitButton.BackColor = System.Drawing.SystemColors.Info;
            this.KullaniciKayitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.KullaniciKayitButton.Location = new System.Drawing.Point(9, 466);
            this.KullaniciKayitButton.Name = "KullaniciKayitButton";
            this.KullaniciKayitButton.Size = new System.Drawing.Size(337, 61);
            this.KullaniciKayitButton.TabIndex = 5;
            this.KullaniciKayitButton.Text = "Kayıt Ol";
            this.KullaniciKayitButton.UseVisualStyleBackColor = false;
            this.KullaniciKayitButton.Click += new System.EventHandler(this.KullaniciKayitButton_Click);
            // 
            // KullaniciKayitIDTextBox
            // 
            this.KullaniciKayitIDTextBox.BackColor = System.Drawing.SystemColors.Info;
            this.KullaniciKayitIDTextBox.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KullaniciKayitIDTextBox.Location = new System.Drawing.Point(202, 239);
            this.KullaniciKayitIDTextBox.Name = "KullaniciKayitIDTextBox";
            this.KullaniciKayitIDTextBox.Size = new System.Drawing.Size(147, 32);
            this.KullaniciKayitIDTextBox.TabIndex = 1;
            // 
            // KullaniciKayitSifreTextBox
            // 
            this.KullaniciKayitSifreTextBox.BackColor = System.Drawing.SystemColors.Info;
            this.KullaniciKayitSifreTextBox.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KullaniciKayitSifreTextBox.Location = new System.Drawing.Point(202, 277);
            this.KullaniciKayitSifreTextBox.Name = "KullaniciKayitSifreTextBox";
            this.KullaniciKayitSifreTextBox.Size = new System.Drawing.Size(147, 32);
            this.KullaniciKayitSifreTextBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 239);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 23);
            this.label1.TabIndex = 4;
            this.label1.Text = "Kullanıcı Adı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 277);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 23);
            this.label2.TabIndex = 5;
            this.label2.Text = "Şifre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(23, 315);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 23);
            this.label3.TabIndex = 7;
            this.label3.Text = "Şifre Tekrar";
            // 
            // SifreTekrarTextBox
            // 
            this.SifreTekrarTextBox.BackColor = System.Drawing.SystemColors.Info;
            this.SifreTekrarTextBox.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SifreTekrarTextBox.Location = new System.Drawing.Point(202, 315);
            this.SifreTekrarTextBox.Name = "SifreTekrarTextBox";
            this.SifreTekrarTextBox.Size = new System.Drawing.Size(147, 32);
            this.SifreTekrarTextBox.TabIndex = 3;
            // 
            // KayitPic
            // 
            this.KayitPic.Image = ((System.Drawing.Image)(resources.GetObject("KayitPic.Image")));
            this.KayitPic.Location = new System.Drawing.Point(103, 12);
            this.KayitPic.Name = "KayitPic";
            this.KayitPic.Size = new System.Drawing.Size(246, 221);
            this.KayitPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.KayitPic.TabIndex = 8;
            this.KayitPic.TabStop = false;
            this.KayitPic.Click += new System.EventHandler(this.KayitPic_Click);
            // 
            // BackKullaniciKayit
            // 
            this.BackKullaniciKayit.BackColor = System.Drawing.SystemColors.Info;
            this.BackKullaniciKayit.Image = ((System.Drawing.Image)(resources.GetObject("BackKullaniciKayit.Image")));
            this.BackKullaniciKayit.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.BackKullaniciKayit.Location = new System.Drawing.Point(9, 12);
            this.BackKullaniciKayit.Name = "BackKullaniciKayit";
            this.BackKullaniciKayit.Size = new System.Drawing.Size(88, 50);
            this.BackKullaniciKayit.TabIndex = 6;
            this.BackKullaniciKayit.UseVisualStyleBackColor = false;
            this.BackKullaniciKayit.Click += new System.EventHandler(this.BackKullaniciKayit_Click);
            // 
            // AdresLabel
            // 
            this.AdresLabel.AutoSize = true;
            this.AdresLabel.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdresLabel.Location = new System.Drawing.Point(99, 350);
            this.AdresLabel.Name = "AdresLabel";
            this.AdresLabel.Size = new System.Drawing.Size(66, 23);
            this.AdresLabel.TabIndex = 13;
            this.AdresLabel.Text = "Adres";
            // 
            // txtAdres
            // 
            this.txtAdres.BackColor = System.Drawing.SystemColors.Info;
            this.txtAdres.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAdres.Location = new System.Drawing.Point(12, 376);
            this.txtAdres.Multiline = true;
            this.txtAdres.Name = "txtAdres";
            this.txtAdres.Size = new System.Drawing.Size(334, 84);
            this.txtAdres.TabIndex = 4;
            // 
            // KullaniciKayit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(361, 539);
            this.ControlBox = false;
            this.Controls.Add(this.AdresLabel);
            this.Controls.Add(this.txtAdres);
            this.Controls.Add(this.BackKullaniciKayit);
            this.Controls.Add(this.KayitPic);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.SifreTekrarTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.KullaniciKayitSifreTextBox);
            this.Controls.Add(this.KullaniciKayitIDTextBox);
            this.Controls.Add(this.KullaniciKayitButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "KullaniciKayit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kullanıcı Kayıt";
            this.Load += new System.EventHandler(this.KullaniciKayit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.KayitPic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button KullaniciKayitButton;
        private System.Windows.Forms.TextBox KullaniciKayitIDTextBox;
        private System.Windows.Forms.TextBox KullaniciKayitSifreTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox SifreTekrarTextBox;
        private System.Windows.Forms.PictureBox KayitPic;
        private System.Windows.Forms.Button BackKullaniciKayit;
        private System.Windows.Forms.Label AdresLabel;
        private System.Windows.Forms.TextBox txtAdres;
    }
}