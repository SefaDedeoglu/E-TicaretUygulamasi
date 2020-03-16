namespace SchoolProject
{
    partial class KullaniciGİris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KullaniciGİris));
            this.KullaniciSifreLabel = new System.Windows.Forms.Label();
            this.KullaniciAdiLabel = new System.Windows.Forms.Label();
            this.KullaniciSifreTextBox = new System.Windows.Forms.TextBox();
            this.KullaniciAdiTextBox = new System.Windows.Forms.TextBox();
            this.KullaniciGirisButton = new System.Windows.Forms.Button();
            this.KullaniciGİrisPic = new System.Windows.Forms.PictureBox();
            this.BackKullaniciGiris = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.KullaniciGİrisPic)).BeginInit();
            this.SuspendLayout();
            // 
            // KullaniciSifreLabel
            // 
            this.KullaniciSifreLabel.AutoSize = true;
            this.KullaniciSifreLabel.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KullaniciSifreLabel.Location = new System.Drawing.Point(37, 274);
            this.KullaniciSifreLabel.Name = "KullaniciSifreLabel";
            this.KullaniciSifreLabel.Size = new System.Drawing.Size(54, 23);
            this.KullaniciSifreLabel.TabIndex = 10;
            this.KullaniciSifreLabel.Text = "Şifre";
            // 
            // KullaniciAdiLabel
            // 
            this.KullaniciAdiLabel.AutoSize = true;
            this.KullaniciAdiLabel.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KullaniciAdiLabel.Location = new System.Drawing.Point(37, 219);
            this.KullaniciAdiLabel.Name = "KullaniciAdiLabel";
            this.KullaniciAdiLabel.Size = new System.Drawing.Size(130, 23);
            this.KullaniciAdiLabel.TabIndex = 9;
            this.KullaniciAdiLabel.Text = "Kullanıcı Adı";
            // 
            // KullaniciSifreTextBox
            // 
            this.KullaniciSifreTextBox.BackColor = System.Drawing.SystemColors.Info;
            this.KullaniciSifreTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.KullaniciSifreTextBox.Location = new System.Drawing.Point(180, 274);
            this.KullaniciSifreTextBox.Name = "KullaniciSifreTextBox";
            this.KullaniciSifreTextBox.Size = new System.Drawing.Size(143, 31);
            this.KullaniciSifreTextBox.TabIndex = 2;
            // 
            // KullaniciAdiTextBox
            // 
            this.KullaniciAdiTextBox.BackColor = System.Drawing.SystemColors.Info;
            this.KullaniciAdiTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.KullaniciAdiTextBox.Location = new System.Drawing.Point(180, 219);
            this.KullaniciAdiTextBox.Name = "KullaniciAdiTextBox";
            this.KullaniciAdiTextBox.Size = new System.Drawing.Size(143, 31);
            this.KullaniciAdiTextBox.TabIndex = 1;
            // 
            // KullaniciGirisButton
            // 
            this.KullaniciGirisButton.BackColor = System.Drawing.SystemColors.Info;
            this.KullaniciGirisButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.KullaniciGirisButton.Location = new System.Drawing.Point(41, 330);
            this.KullaniciGirisButton.Name = "KullaniciGirisButton";
            this.KullaniciGirisButton.Size = new System.Drawing.Size(282, 83);
            this.KullaniciGirisButton.TabIndex = 3;
            this.KullaniciGirisButton.Text = "GİRİŞ";
            this.KullaniciGirisButton.UseVisualStyleBackColor = false;
            this.KullaniciGirisButton.Click += new System.EventHandler(this.AdminGirisButton_Click);
            // 
            // KullaniciGİrisPic
            // 
            this.KullaniciGİrisPic.Image = ((System.Drawing.Image)(resources.GetObject("KullaniciGİrisPic.Image")));
            this.KullaniciGİrisPic.Location = new System.Drawing.Point(100, 12);
            this.KullaniciGİrisPic.Name = "KullaniciGİrisPic";
            this.KullaniciGİrisPic.Size = new System.Drawing.Size(249, 198);
            this.KullaniciGİrisPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.KullaniciGİrisPic.TabIndex = 11;
            this.KullaniciGİrisPic.TabStop = false;
            this.KullaniciGİrisPic.Click += new System.EventHandler(this.KullaniciGİrisPic_Click);
            // 
            // BackKullaniciGiris
            // 
            this.BackKullaniciGiris.BackColor = System.Drawing.SystemColors.Info;
            this.BackKullaniciGiris.Image = ((System.Drawing.Image)(resources.GetObject("BackKullaniciGiris.Image")));
            this.BackKullaniciGiris.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.BackKullaniciGiris.Location = new System.Drawing.Point(3, 12);
            this.BackKullaniciGiris.Name = "BackKullaniciGiris";
            this.BackKullaniciGiris.Size = new System.Drawing.Size(88, 50);
            this.BackKullaniciGiris.TabIndex = 4;
            this.BackKullaniciGiris.UseVisualStyleBackColor = false;
            this.BackKullaniciGiris.Click += new System.EventHandler(this.BackKullaniciGiris_Click);
            // 
            // KullaniciGİris
            // 
            this.AcceptButton = this.KullaniciGirisButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(361, 429);
            this.ControlBox = false;
            this.Controls.Add(this.BackKullaniciGiris);
            this.Controls.Add(this.KullaniciGİrisPic);
            this.Controls.Add(this.KullaniciSifreLabel);
            this.Controls.Add(this.KullaniciAdiLabel);
            this.Controls.Add(this.KullaniciSifreTextBox);
            this.Controls.Add(this.KullaniciAdiTextBox);
            this.Controls.Add(this.KullaniciGirisButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "KullaniciGİris";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kullanıcı Girişi";
            this.Load += new System.EventHandler(this.KullaniciGİris_Load);
            ((System.ComponentModel.ISupportInitialize)(this.KullaniciGİrisPic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label KullaniciSifreLabel;
        private System.Windows.Forms.Label KullaniciAdiLabel;
        private System.Windows.Forms.TextBox KullaniciSifreTextBox;
        private System.Windows.Forms.TextBox KullaniciAdiTextBox;
        private System.Windows.Forms.Button KullaniciGirisButton;
        private System.Windows.Forms.PictureBox KullaniciGİrisPic;
        private System.Windows.Forms.Button BackKullaniciGiris;
    }
}