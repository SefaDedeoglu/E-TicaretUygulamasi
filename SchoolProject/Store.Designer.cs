namespace SchoolProject
{
    partial class Store
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Store));
            this.DATA = new System.Windows.Forms.DataGridView();
            this.DataPic = new System.Windows.Forms.PictureBox();
            this.urunAdıLabel = new System.Windows.Forms.Label();
            this.urundatalabel = new System.Windows.Forms.Label();
            this.urunfiyatdatalabel = new System.Windows.Forms.Label();
            this.urunFiyatiLabel = new System.Windows.Forms.Label();
            this.urunstokdatalabel = new System.Windows.Forms.Label();
            this.StokDurumuLabel = new System.Windows.Forms.Label();
            this.tarihlabel = new System.Windows.Forms.Label();
            this.SepeteEkleButton = new System.Windows.Forms.Button();
            this.sepetbilgilabel = new System.Windows.Forms.Label();
            this.sepetdtg = new System.Windows.Forms.DataGridView();
            this.SepetBosButton = new System.Windows.Forms.Button();
            this.ode = new System.Windows.Forms.Button();
            this.ToplamTutarLabel = new System.Windows.Forms.Label();
            this.AmountLabel = new System.Windows.Forms.Label();
            this.ForNameLabel = new System.Windows.Forms.Label();
            this.AdresLabel = new System.Windows.Forms.Label();
            this.BackStoreButton = new System.Windows.Forms.Button();
            this.datasorgu1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DATA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sepetdtg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datasorgu1)).BeginInit();
            this.SuspendLayout();
            // 
            // DATA
            // 
            this.DATA.BackgroundColor = System.Drawing.SystemColors.Info;
            this.DATA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DATA.GridColor = System.Drawing.SystemColors.Menu;
            this.DATA.Location = new System.Drawing.Point(769, 356);
            this.DATA.Name = "DATA";
            this.DATA.Size = new System.Drawing.Size(375, 276);
            this.DATA.TabIndex = 0;
            this.DATA.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DATA_CellClick);
            this.DATA.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DATA_CellContentClick);
            // 
            // DataPic
            // 
            this.DataPic.Location = new System.Drawing.Point(769, 6);
            this.DataPic.Name = "DataPic";
            this.DataPic.Size = new System.Drawing.Size(375, 331);
            this.DataPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.DataPic.TabIndex = 1;
            this.DataPic.TabStop = false;
            this.DataPic.Click += new System.EventHandler(this.DataPic_Click);
            // 
            // urunAdıLabel
            // 
            this.urunAdıLabel.AutoSize = true;
            this.urunAdıLabel.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.urunAdıLabel.Location = new System.Drawing.Point(319, 97);
            this.urunAdıLabel.Name = "urunAdıLabel";
            this.urunAdıLabel.Size = new System.Drawing.Size(108, 25);
            this.urunAdıLabel.TabIndex = 2;
            this.urunAdıLabel.Text = "Ürün Adı:";
            // 
            // urundatalabel
            // 
            this.urundatalabel.AutoSize = true;
            this.urundatalabel.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.urundatalabel.Location = new System.Drawing.Point(496, 97);
            this.urundatalabel.Name = "urundatalabel";
            this.urundatalabel.Size = new System.Drawing.Size(0, 25);
            this.urundatalabel.TabIndex = 3;
            // 
            // urunfiyatdatalabel
            // 
            this.urunfiyatdatalabel.AutoSize = true;
            this.urunfiyatdatalabel.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.urunfiyatdatalabel.Location = new System.Drawing.Point(496, 165);
            this.urunfiyatdatalabel.Name = "urunfiyatdatalabel";
            this.urunfiyatdatalabel.Size = new System.Drawing.Size(0, 25);
            this.urunfiyatdatalabel.TabIndex = 5;
            // 
            // urunFiyatiLabel
            // 
            this.urunFiyatiLabel.AutoSize = true;
            this.urunFiyatiLabel.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.urunFiyatiLabel.Location = new System.Drawing.Point(319, 165);
            this.urunFiyatiLabel.Name = "urunFiyatiLabel";
            this.urunFiyatiLabel.Size = new System.Drawing.Size(132, 25);
            this.urunFiyatiLabel.TabIndex = 4;
            this.urunFiyatiLabel.Text = "Ürün Fiyatı:";
            // 
            // urunstokdatalabel
            // 
            this.urunstokdatalabel.AutoSize = true;
            this.urunstokdatalabel.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.urunstokdatalabel.Location = new System.Drawing.Point(496, 223);
            this.urunstokdatalabel.Name = "urunstokdatalabel";
            this.urunstokdatalabel.Size = new System.Drawing.Size(0, 25);
            this.urunstokdatalabel.TabIndex = 7;
            // 
            // StokDurumuLabel
            // 
            this.StokDurumuLabel.AutoSize = true;
            this.StokDurumuLabel.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StokDurumuLabel.Location = new System.Drawing.Point(319, 223);
            this.StokDurumuLabel.Name = "StokDurumuLabel";
            this.StokDurumuLabel.Size = new System.Drawing.Size(154, 25);
            this.StokDurumuLabel.TabIndex = 6;
            this.StokDurumuLabel.Text = "Stok Durumu:";
            // 
            // tarihlabel
            // 
            this.tarihlabel.AutoSize = true;
            this.tarihlabel.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tarihlabel.Location = new System.Drawing.Point(1022, 652);
            this.tarihlabel.Name = "tarihlabel";
            this.tarihlabel.Size = new System.Drawing.Size(122, 25);
            this.tarihlabel.TabIndex = 8;
            this.tarihlabel.Text = "20.07.1999";
            // 
            // SepeteEkleButton
            // 
            this.SepeteEkleButton.BackColor = System.Drawing.SystemColors.Info;
            this.SepeteEkleButton.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SepeteEkleButton.Location = new System.Drawing.Point(402, 270);
            this.SepeteEkleButton.Name = "SepeteEkleButton";
            this.SepeteEkleButton.Size = new System.Drawing.Size(140, 33);
            this.SepeteEkleButton.TabIndex = 1;
            this.SepeteEkleButton.Text = "Sepete Ekle";
            this.SepeteEkleButton.UseVisualStyleBackColor = false;
            this.SepeteEkleButton.Click += new System.EventHandler(this.SepeteEkleButton_Click);
            // 
            // sepetbilgilabel
            // 
            this.sepetbilgilabel.AutoSize = true;
            this.sepetbilgilabel.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sepetbilgilabel.Location = new System.Drawing.Point(66, 9);
            this.sepetbilgilabel.Name = "sepetbilgilabel";
            this.sepetbilgilabel.Size = new System.Drawing.Size(105, 25);
            this.sepetbilgilabel.TabIndex = 11;
            this.sepetbilgilabel.Text = "Sepetiniz";
            // 
            // sepetdtg
            // 
            this.sepetdtg.BackgroundColor = System.Drawing.SystemColors.Info;
            this.sepetdtg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.sepetdtg.GridColor = System.Drawing.SystemColors.Menu;
            this.sepetdtg.Location = new System.Drawing.Point(12, 37);
            this.sepetdtg.Name = "sepetdtg";
            this.sepetdtg.Size = new System.Drawing.Size(202, 337);
            this.sepetdtg.TabIndex = 12;
            // 
            // SepetBosButton
            // 
            this.SepetBosButton.BackColor = System.Drawing.SystemColors.Info;
            this.SepetBosButton.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SepetBosButton.Location = new System.Drawing.Point(12, 380);
            this.SepetBosButton.Name = "SepetBosButton";
            this.SepetBosButton.Size = new System.Drawing.Size(119, 33);
            this.SepetBosButton.TabIndex = 2;
            this.SepetBosButton.Text = "Sepeti boşalt";
            this.SepetBosButton.UseVisualStyleBackColor = false;
            this.SepetBosButton.Click += new System.EventHandler(this.SepetBosButton_Click);
            // 
            // ode
            // 
            this.ode.BackColor = System.Drawing.SystemColors.Info;
            this.ode.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ode.Location = new System.Drawing.Point(137, 380);
            this.ode.Name = "ode";
            this.ode.Size = new System.Drawing.Size(77, 33);
            this.ode.TabIndex = 3;
            this.ode.Text = "Öde";
            this.ode.UseVisualStyleBackColor = false;
            this.ode.Click += new System.EventHandler(this.ode_Click);
            // 
            // ToplamTutarLabel
            // 
            this.ToplamTutarLabel.AutoSize = true;
            this.ToplamTutarLabel.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ToplamTutarLabel.Location = new System.Drawing.Point(12, 416);
            this.ToplamTutarLabel.Name = "ToplamTutarLabel";
            this.ToplamTutarLabel.Size = new System.Drawing.Size(122, 18);
            this.ToplamTutarLabel.TabIndex = 15;
            this.ToplamTutarLabel.Text = "Toplam Tutar : ";
            // 
            // AmountLabel
            // 
            this.AmountLabel.AutoSize = true;
            this.AmountLabel.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AmountLabel.Location = new System.Drawing.Point(140, 416);
            this.AmountLabel.Name = "AmountLabel";
            this.AmountLabel.Size = new System.Drawing.Size(0, 18);
            this.AmountLabel.TabIndex = 16;
            // 
            // ForNameLabel
            // 
            this.ForNameLabel.AutoSize = true;
            this.ForNameLabel.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForNameLabel.Location = new System.Drawing.Point(12, 485);
            this.ForNameLabel.Name = "ForNameLabel";
            this.ForNameLabel.Size = new System.Drawing.Size(0, 25);
            this.ForNameLabel.TabIndex = 17;
            // 
            // AdresLabel
            // 
            this.AdresLabel.AutoSize = true;
            this.AdresLabel.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdresLabel.Location = new System.Drawing.Point(12, 550);
            this.AdresLabel.Name = "AdresLabel";
            this.AdresLabel.Size = new System.Drawing.Size(0, 25);
            this.AdresLabel.TabIndex = 18;
            this.AdresLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // BackStoreButton
            // 
            this.BackStoreButton.BackColor = System.Drawing.SystemColors.Info;
            this.BackStoreButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BackStoreButton.Image = ((System.Drawing.Image)(resources.GetObject("BackStoreButton.Image")));
            this.BackStoreButton.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.BackStoreButton.Location = new System.Drawing.Point(12, 624);
            this.BackStoreButton.Name = "BackStoreButton";
            this.BackStoreButton.Size = new System.Drawing.Size(88, 50);
            this.BackStoreButton.TabIndex = 4;
            this.BackStoreButton.Text = "ÇIKIŞ";
            this.BackStoreButton.UseVisualStyleBackColor = false;
            this.BackStoreButton.Click += new System.EventHandler(this.BackStoreButton_Click);
            // 
            // datasorgu1
            // 
            this.datasorgu1.BackgroundColor = System.Drawing.SystemColors.Info;
            this.datasorgu1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datasorgu1.GridColor = System.Drawing.SystemColors.Menu;
            this.datasorgu1.Location = new System.Drawing.Point(1291, 575);
            this.datasorgu1.Name = "datasorgu1";
            this.datasorgu1.Size = new System.Drawing.Size(44, 102);
            this.datasorgu1.TabIndex = 20;
            // 
            // Store
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(1160, 685);
            this.ControlBox = false;
            this.Controls.Add(this.datasorgu1);
            this.Controls.Add(this.BackStoreButton);
            this.Controls.Add(this.AdresLabel);
            this.Controls.Add(this.ForNameLabel);
            this.Controls.Add(this.AmountLabel);
            this.Controls.Add(this.ToplamTutarLabel);
            this.Controls.Add(this.ode);
            this.Controls.Add(this.SepetBosButton);
            this.Controls.Add(this.sepetdtg);
            this.Controls.Add(this.sepetbilgilabel);
            this.Controls.Add(this.SepeteEkleButton);
            this.Controls.Add(this.tarihlabel);
            this.Controls.Add(this.urunstokdatalabel);
            this.Controls.Add(this.StokDurumuLabel);
            this.Controls.Add(this.urunfiyatdatalabel);
            this.Controls.Add(this.urunFiyatiLabel);
            this.Controls.Add(this.urundatalabel);
            this.Controls.Add(this.urunAdıLabel);
            this.Controls.Add(this.DataPic);
            this.Controls.Add(this.DATA);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Store";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MAĞAZA";
            this.Load += new System.EventHandler(this.Store_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DATA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sepetdtg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datasorgu1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DATA;
        private System.Windows.Forms.PictureBox DataPic;
        private System.Windows.Forms.Label urunAdıLabel;
        private System.Windows.Forms.Label urundatalabel;
        private System.Windows.Forms.Label urunfiyatdatalabel;
        private System.Windows.Forms.Label urunFiyatiLabel;
        private System.Windows.Forms.Label urunstokdatalabel;
        private System.Windows.Forms.Label StokDurumuLabel;
        private System.Windows.Forms.Label tarihlabel;
        private System.Windows.Forms.Button SepeteEkleButton;
        private System.Windows.Forms.Label sepetbilgilabel;
        private System.Windows.Forms.DataGridView sepetdtg;
        private System.Windows.Forms.Button SepetBosButton;
        private System.Windows.Forms.Button ode;
        private System.Windows.Forms.Label ToplamTutarLabel;
        private System.Windows.Forms.Label AmountLabel;
        private System.Windows.Forms.Label ForNameLabel;
        private System.Windows.Forms.Label AdresLabel;
        private System.Windows.Forms.Button BackStoreButton;
        private System.Windows.Forms.DataGridView datasorgu1;
    }
}