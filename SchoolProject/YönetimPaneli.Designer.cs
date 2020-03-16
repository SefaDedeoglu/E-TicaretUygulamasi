namespace SchoolProject
{
    partial class YönetimPaneli
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(YönetimPaneli));
            this.hgLabel = new System.Windows.Forms.Label();
            this.geributtonyp = new System.Windows.Forms.Button();
            this.ButtonUrün = new System.Windows.Forms.Button();
            this.ButtonSiparis = new System.Windows.Forms.Button();
            this.ButtonListele = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // hgLabel
            // 
            this.hgLabel.AutoSize = true;
            this.hgLabel.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hgLabel.Location = new System.Drawing.Point(12, 9);
            this.hgLabel.Name = "hgLabel";
            this.hgLabel.Size = new System.Drawing.Size(183, 23);
            this.hgLabel.TabIndex = 0;
            this.hgLabel.Text = "Hoş Geldin Admin";
            // 
            // geributtonyp
            // 
            this.geributtonyp.BackColor = System.Drawing.SystemColors.Info;
            this.geributtonyp.Image = ((System.Drawing.Image)(resources.GetObject("geributtonyp.Image")));
            this.geributtonyp.Location = new System.Drawing.Point(16, 289);
            this.geributtonyp.Name = "geributtonyp";
            this.geributtonyp.Size = new System.Drawing.Size(86, 46);
            this.geributtonyp.TabIndex = 4;
            this.geributtonyp.UseVisualStyleBackColor = false;
            this.geributtonyp.Click += new System.EventHandler(this.geributtonyp_Click);
            // 
            // ButtonUrün
            // 
            this.ButtonUrün.BackColor = System.Drawing.SystemColors.Info;
            this.ButtonUrün.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonUrün.Location = new System.Drawing.Point(12, 50);
            this.ButtonUrün.Name = "ButtonUrün";
            this.ButtonUrün.Size = new System.Drawing.Size(196, 57);
            this.ButtonUrün.TabIndex = 1;
            this.ButtonUrün.Text = "Ürün Yönetimi";
            this.ButtonUrün.UseVisualStyleBackColor = false;
            this.ButtonUrün.Click += new System.EventHandler(this.ButtonUrün_Click);
            // 
            // ButtonSiparis
            // 
            this.ButtonSiparis.BackColor = System.Drawing.SystemColors.Info;
            this.ButtonSiparis.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonSiparis.Location = new System.Drawing.Point(12, 125);
            this.ButtonSiparis.Name = "ButtonSiparis";
            this.ButtonSiparis.Size = new System.Drawing.Size(196, 57);
            this.ButtonSiparis.TabIndex = 2;
            this.ButtonSiparis.Text = "Sipariş Bilgileri";
            this.ButtonSiparis.UseVisualStyleBackColor = false;
            this.ButtonSiparis.Click += new System.EventHandler(this.ButtonSiparis_Click);
            // 
            // ButtonListele
            // 
            this.ButtonListele.BackColor = System.Drawing.SystemColors.Info;
            this.ButtonListele.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonListele.Location = new System.Drawing.Point(12, 208);
            this.ButtonListele.Name = "ButtonListele";
            this.ButtonListele.Size = new System.Drawing.Size(196, 57);
            this.ButtonListele.TabIndex = 3;
            this.ButtonListele.Text = "Kullanıcı Listesi";
            this.ButtonListele.UseVisualStyleBackColor = false;
            this.ButtonListele.Click += new System.EventHandler(this.ButtonListele_Click);
            // 
            // YönetimPaneli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(220, 346);
            this.ControlBox = false;
            this.Controls.Add(this.ButtonListele);
            this.Controls.Add(this.ButtonSiparis);
            this.Controls.Add(this.ButtonUrün);
            this.Controls.Add(this.geributtonyp);
            this.Controls.Add(this.hgLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "YönetimPaneli";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Yönetim Paneli";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label hgLabel;
        private System.Windows.Forms.Button geributtonyp;
        private System.Windows.Forms.Button ButtonUrün;
        private System.Windows.Forms.Button ButtonSiparis;
        private System.Windows.Forms.Button ButtonListele;
    }
}