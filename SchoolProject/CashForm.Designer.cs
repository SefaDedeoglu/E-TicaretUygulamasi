namespace SchoolProject
{
    partial class CashForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CashForm));
            this.SumLabel = new System.Windows.Forms.Label();
            this.TextLabelSum = new System.Windows.Forms.Label();
            this.ReceivedLabel = new System.Windows.Forms.Label();
            this.PayButton = new System.Windows.Forms.Button();
            this.GoBackButton = new System.Windows.Forms.Button();
            this.ReceivedTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // SumLabel
            // 
            this.SumLabel.AutoSize = true;
            this.SumLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.SumLabel.Location = new System.Drawing.Point(482, 158);
            this.SumLabel.Name = "SumLabel";
            this.SumLabel.Size = new System.Drawing.Size(0, 31);
            this.SumLabel.TabIndex = 3;
            // 
            // TextLabelSum
            // 
            this.TextLabelSum.AutoSize = true;
            this.TextLabelSum.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TextLabelSum.Location = new System.Drawing.Point(169, 158);
            this.TextLabelSum.Name = "TextLabelSum";
            this.TextLabelSum.Size = new System.Drawing.Size(253, 31);
            this.TextLabelSum.TabIndex = 4;
            this.TextLabelSum.Text = "TOPLAM TUTAR :";
            this.TextLabelSum.Click += new System.EventHandler(this.TextLabelSum_Click);
            // 
            // ReceivedLabel
            // 
            this.ReceivedLabel.AutoSize = true;
            this.ReceivedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ReceivedLabel.Location = new System.Drawing.Point(147, 68);
            this.ReceivedLabel.Name = "ReceivedLabel";
            this.ReceivedLabel.Size = new System.Drawing.Size(94, 25);
            this.ReceivedLabel.TabIndex = 7;
            this.ReceivedLabel.Text = "Ödenen";
            // 
            // PayButton
            // 
            this.PayButton.BackColor = System.Drawing.SystemColors.Info;
            this.PayButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.PayButton.Location = new System.Drawing.Point(258, 267);
            this.PayButton.Name = "PayButton";
            this.PayButton.Size = new System.Drawing.Size(164, 47);
            this.PayButton.TabIndex = 2;
            this.PayButton.Text = "ÖDE";
            this.PayButton.UseVisualStyleBackColor = false;
            this.PayButton.Click += new System.EventHandler(this.PayButton_Click);
            // 
            // GoBackButton
            // 
            this.GoBackButton.BackColor = System.Drawing.SystemColors.Info;
            this.GoBackButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("GoBackButton.BackgroundImage")));
            this.GoBackButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.GoBackButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.GoBackButton.Location = new System.Drawing.Point(12, 12);
            this.GoBackButton.Name = "GoBackButton";
            this.GoBackButton.Size = new System.Drawing.Size(93, 53);
            this.GoBackButton.TabIndex = 3;
            this.GoBackButton.UseVisualStyleBackColor = false;
            this.GoBackButton.Click += new System.EventHandler(this.GoBackButton_Click);
            // 
            // ReceivedTextBox
            // 
            this.ReceivedTextBox.BackColor = System.Drawing.SystemColors.Info;
            this.ReceivedTextBox.Location = new System.Drawing.Point(382, 72);
            this.ReceivedTextBox.Name = "ReceivedTextBox";
            this.ReceivedTextBox.Size = new System.Drawing.Size(100, 20);
            this.ReceivedTextBox.TabIndex = 1;
            // 
            // CashForm
            // 
            this.AcceptButton = this.PayButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(632, 371);
            this.ControlBox = false;
            this.Controls.Add(this.ReceivedTextBox);
            this.Controls.Add(this.GoBackButton);
            this.Controls.Add(this.PayButton);
            this.Controls.Add(this.ReceivedLabel);
            this.Controls.Add(this.TextLabelSum);
            this.Controls.Add(this.SumLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CashForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ödeme / Nakit";
            this.Load += new System.EventHandler(this.CashForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label SumLabel;
        private System.Windows.Forms.Label TextLabelSum;
        private System.Windows.Forms.Label ReceivedLabel;
        private System.Windows.Forms.Button PayButton;
        private System.Windows.Forms.Button GoBackButton;
        private System.Windows.Forms.TextBox ReceivedTextBox;
    }
}