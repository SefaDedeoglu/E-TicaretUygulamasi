namespace SchoolProject
{
    partial class payment
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(payment));
            this.Cash = new System.Windows.Forms.Button();
            this.CreditCard = new System.Windows.Forms.Button();
            this.Check = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Cash
            // 
            this.Cash.BackColor = System.Drawing.SystemColors.Info;
            this.Cash.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Cash.Image = ((System.Drawing.Image)(resources.GetObject("Cash.Image")));
            this.Cash.Location = new System.Drawing.Point(1, -1);
            this.Cash.Name = "Cash";
            this.Cash.Size = new System.Drawing.Size(272, 451);
            this.Cash.TabIndex = 1;
            this.Cash.Text = "Nakit";
            this.Cash.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Cash.UseVisualStyleBackColor = false;
            this.Cash.Click += new System.EventHandler(this.Cash_Click);
            // 
            // CreditCard
            // 
            this.CreditCard.BackColor = System.Drawing.SystemColors.Info;
            this.CreditCard.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.CreditCard.ForeColor = System.Drawing.SystemColors.ControlText;
            this.CreditCard.Image = ((System.Drawing.Image)(resources.GetObject("CreditCard.Image")));
            this.CreditCard.Location = new System.Drawing.Point(279, -1);
            this.CreditCard.Name = "CreditCard";
            this.CreditCard.Size = new System.Drawing.Size(272, 451);
            this.CreditCard.TabIndex = 2;
            this.CreditCard.Text = "Kredi kartı";
            this.CreditCard.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.CreditCard.UseVisualStyleBackColor = false;
            this.CreditCard.Click += new System.EventHandler(this.CreditCard_Click);
            // 
            // Check
            // 
            this.Check.BackColor = System.Drawing.SystemColors.Info;
            this.Check.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Check.Image = ((System.Drawing.Image)(resources.GetObject("Check.Image")));
            this.Check.Location = new System.Drawing.Point(557, -1);
            this.Check.Name = "Check";
            this.Check.Size = new System.Drawing.Size(272, 451);
            this.Check.TabIndex = 3;
            this.Check.Text = "Çek";
            this.Check.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Check.UseVisualStyleBackColor = false;
            this.Check.Click += new System.EventHandler(this.Check_Click);
            // 
            // payment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(828, 450);
            this.ControlBox = false;
            this.Controls.Add(this.Check);
            this.Controls.Add(this.CreditCard);
            this.Controls.Add(this.Cash);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "payment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ÖDEME SEÇENEKLERİ";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Cash;
        private System.Windows.Forms.Button CreditCard;
        private System.Windows.Forms.Button Check;
    }
}

