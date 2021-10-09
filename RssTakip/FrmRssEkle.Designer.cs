namespace RssTakipUI
{
    partial class FrmRssEkle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRssEkle));
            this.btnEkle = new System.Windows.Forms.Button();
            this.lblRssAd = new System.Windows.Forms.Label();
            this.lblRssLink = new System.Windows.Forms.Label();
            this.txtRssAd = new System.Windows.Forms.TextBox();
            this.txtRssLink = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(243, 82);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(75, 32);
            this.btnEkle.TabIndex = 0;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.BtnEkle_Click);
            // 
            // lblRssAd
            // 
            this.lblRssAd.AutoSize = true;
            this.lblRssAd.Location = new System.Drawing.Point(7, 15);
            this.lblRssAd.Name = "lblRssAd";
            this.lblRssAd.Size = new System.Drawing.Size(85, 24);
            this.lblRssAd.TabIndex = 1;
            this.lblRssAd.Text = "RSS Adı:";
            // 
            // lblRssLink
            // 
            this.lblRssLink.AutoSize = true;
            this.lblRssLink.Location = new System.Drawing.Point(7, 50);
            this.lblRssLink.Name = "lblRssLink";
            this.lblRssLink.Size = new System.Drawing.Size(95, 24);
            this.lblRssLink.TabIndex = 2;
            this.lblRssLink.Text = "RSS Linki:";
            // 
            // txtRssAd
            // 
            this.txtRssAd.Location = new System.Drawing.Point(98, 12);
            this.txtRssAd.Name = "txtRssAd";
            this.txtRssAd.Size = new System.Drawing.Size(220, 29);
            this.txtRssAd.TabIndex = 3;
            // 
            // txtRssLink
            // 
            this.txtRssLink.Location = new System.Drawing.Point(98, 47);
            this.txtRssLink.Name = "txtRssLink";
            this.txtRssLink.Size = new System.Drawing.Size(220, 29);
            this.txtRssLink.TabIndex = 4;
            // 
            // FrmRssEkle
            // 
            this.AcceptButton = this.btnEkle;
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(327, 121);
            this.Controls.Add(this.txtRssLink);
            this.Controls.Add(this.txtRssAd);
            this.Controls.Add(this.lblRssLink);
            this.Controls.Add(this.lblRssAd);
            this.Controls.Add(this.btnEkle);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.20895F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmRssEkle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RssEkle";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmRssEkle_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Label lblRssAd;
        private System.Windows.Forms.Label lblRssLink;
        private System.Windows.Forms.TextBox txtRssAd;
        private System.Windows.Forms.TextBox txtRssLink;
    }
}