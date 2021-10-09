namespace RssTakipUI
{
    partial class FrmRssTakip
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRssTakip));
            this.tvRssKanallari = new System.Windows.Forms.TreeView();
            this.cmsSagTikMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmsSil = new System.Windows.Forms.ToolStripMenuItem();
            this.lstFeed = new System.Windows.Forms.ListView();
            this.chKanal = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chBaslik = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chTarih = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.gboxFeed = new System.Windows.Forms.GroupBox();
            this.gboxRss = new System.Windows.Forms.GroupBox();
            this.msMenu = new System.Windows.Forms.MenuStrip();
            this.tsmiRssEkle = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiGuncelle = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiHakkinda = new System.Windows.Forms.ToolStripMenuItem();
            this.ssDurum = new System.Windows.Forms.StatusStrip();
            this.tsslDurum = new System.Windows.Forms.ToolStripStatusLabel();
            this.cmsSagTikMenu.SuspendLayout();
            this.gboxFeed.SuspendLayout();
            this.gboxRss.SuspendLayout();
            this.msMenu.SuspendLayout();
            this.ssDurum.SuspendLayout();
            this.SuspendLayout();
            // 
            // tvRssKanallari
            // 
            this.tvRssKanallari.ContextMenuStrip = this.cmsSagTikMenu;
            this.tvRssKanallari.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tvRssKanallari.FullRowSelect = true;
            this.tvRssKanallari.Location = new System.Drawing.Point(3, 25);
            this.tvRssKanallari.Name = "tvRssKanallari";
            this.tvRssKanallari.Size = new System.Drawing.Size(198, 402);
            this.tvRssKanallari.TabIndex = 0;
            this.tvRssKanallari.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.TvRssKanallari_NodeMouseClick);
            // 
            // cmsSagTikMenu
            // 
            this.cmsSagTikMenu.ImageScalingSize = new System.Drawing.Size(22, 22);
            this.cmsSagTikMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmsSil});
            this.cmsSagTikMenu.Name = "cmsSagTikMenu";
            this.cmsSagTikMenu.Size = new System.Drawing.Size(104, 32);
            // 
            // cmsSil
            // 
            this.cmsSil.Image = global::RssTakipUI.Properties.Resources.sign_delete_icon;
            this.cmsSil.Name = "cmsSil";
            this.cmsSil.Size = new System.Drawing.Size(103, 28);
            this.cmsSil.Text = "Sil";
            this.cmsSil.Click += new System.EventHandler(this.CmsSil_Click);
            // 
            // lstFeed
            // 
            this.lstFeed.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chKanal,
            this.chBaslik,
            this.chTarih});
            this.lstFeed.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstFeed.FullRowSelect = true;
            this.lstFeed.GridLines = true;
            this.lstFeed.HideSelection = false;
            this.lstFeed.Location = new System.Drawing.Point(3, 25);
            this.lstFeed.Name = "lstFeed";
            this.lstFeed.Size = new System.Drawing.Size(744, 402);
            this.lstFeed.TabIndex = 2;
            this.lstFeed.UseCompatibleStateImageBehavior = false;
            this.lstFeed.View = System.Windows.Forms.View.Details;
            this.lstFeed.DoubleClick += new System.EventHandler(this.LstFeed_DoubleClick);
            // 
            // chKanal
            // 
            this.chKanal.Text = "Kanal";
            this.chKanal.Width = 125;
            // 
            // chBaslik
            // 
            this.chBaslik.Text = "Başlık";
            this.chBaslik.Width = 490;
            // 
            // chTarih
            // 
            this.chTarih.Text = "Tarih";
            this.chTarih.Width = 100;
            // 
            // gboxFeed
            // 
            this.gboxFeed.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gboxFeed.Controls.Add(this.lstFeed);
            this.gboxFeed.Location = new System.Drawing.Point(222, 34);
            this.gboxFeed.Name = "gboxFeed";
            this.gboxFeed.Size = new System.Drawing.Size(750, 430);
            this.gboxFeed.TabIndex = 4;
            this.gboxFeed.TabStop = false;
            this.gboxFeed.Text = "Feedler";
            // 
            // gboxRss
            // 
            this.gboxRss.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.gboxRss.Controls.Add(this.tvRssKanallari);
            this.gboxRss.Location = new System.Drawing.Point(12, 34);
            this.gboxRss.Name = "gboxRss";
            this.gboxRss.Size = new System.Drawing.Size(204, 430);
            this.gboxRss.TabIndex = 5;
            this.gboxRss.TabStop = false;
            this.gboxRss.Text = "RSS Kanalları";
            // 
            // msMenu
            // 
            this.msMenu.ImageScalingSize = new System.Drawing.Size(22, 22);
            this.msMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiRssEkle,
            this.tsmiGuncelle,
            this.tsmiHakkinda});
            this.msMenu.Location = new System.Drawing.Point(0, 0);
            this.msMenu.Name = "msMenu";
            this.msMenu.Size = new System.Drawing.Size(980, 31);
            this.msMenu.TabIndex = 6;
            this.msMenu.Text = "menuStrip1";
            // 
            // tsmiRssEkle
            // 
            this.tsmiRssEkle.Image = global::RssTakipUI.Properties.Resources.sign_add_icon;
            this.tsmiRssEkle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tsmiRssEkle.Name = "tsmiRssEkle";
            this.tsmiRssEkle.Size = new System.Drawing.Size(176, 27);
            this.tsmiRssEkle.Text = "RSS Kaynağı Ekle";
            this.tsmiRssEkle.Click += new System.EventHandler(this.TsmiRssEkle_Click);
            // 
            // tsmiGuncelle
            // 
            this.tsmiGuncelle.Image = global::RssTakipUI.Properties.Resources.sign_sync_icon;
            this.tsmiGuncelle.Name = "tsmiGuncelle";
            this.tsmiGuncelle.Size = new System.Drawing.Size(114, 27);
            this.tsmiGuncelle.Text = "Guncelle";
            this.tsmiGuncelle.Click += new System.EventHandler(this.TsmiGuncelle_Click);
            // 
            // tsmiHakkinda
            // 
            this.tsmiHakkinda.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsmiHakkinda.Image = global::RssTakipUI.Properties.Resources.life_buoy_icon;
            this.tsmiHakkinda.Name = "tsmiHakkinda";
            this.tsmiHakkinda.Size = new System.Drawing.Size(118, 27);
            this.tsmiHakkinda.Text = "Hakkında";
            this.tsmiHakkinda.Click += new System.EventHandler(this.TsmiHakkinda_Click);
            // 
            // ssDurum
            // 
            this.ssDurum.ImageScalingSize = new System.Drawing.Size(22, 22);
            this.ssDurum.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslDurum});
            this.ssDurum.Location = new System.Drawing.Point(0, 480);
            this.ssDurum.Name = "ssDurum";
            this.ssDurum.Size = new System.Drawing.Size(980, 22);
            this.ssDurum.TabIndex = 7;
            // 
            // tsslDurum
            // 
            this.tsslDurum.Name = "tsslDurum";
            this.tsslDurum.Size = new System.Drawing.Size(0, 15);
            // 
            // FrmRssTakip
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(980, 502);
            this.Controls.Add(this.ssDurum);
            this.Controls.Add(this.msMenu);
            this.Controls.Add(this.gboxRss);
            this.Controls.Add(this.gboxFeed);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.20895F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmRssTakip";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RSS Takip";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmRssTakip_FormClosing);
            this.Load += new System.EventHandler(this.FrmRssTakip_Load);
            this.Resize += new System.EventHandler(this.FrmRssTakip_Resize);
            this.cmsSagTikMenu.ResumeLayout(false);
            this.gboxFeed.ResumeLayout(false);
            this.gboxRss.ResumeLayout(false);
            this.msMenu.ResumeLayout(false);
            this.msMenu.PerformLayout();
            this.ssDurum.ResumeLayout(false);
            this.ssDurum.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip cmsSagTikMenu;
        private System.Windows.Forms.ToolStripMenuItem cmsSil;
        public System.Windows.Forms.TreeView tvRssKanallari;
        private System.Windows.Forms.ListView lstFeed;
        private System.Windows.Forms.ColumnHeader chKanal;
        private System.Windows.Forms.ColumnHeader chBaslik;
        private System.Windows.Forms.ColumnHeader chTarih;
        private System.Windows.Forms.GroupBox gboxFeed;
        private System.Windows.Forms.GroupBox gboxRss;
        private System.Windows.Forms.MenuStrip msMenu;
        private System.Windows.Forms.ToolStripMenuItem tsmiRssEkle;
        private System.Windows.Forms.ToolStripMenuItem tsmiGuncelle;
        private System.Windows.Forms.StatusStrip ssDurum;
        private System.Windows.Forms.ToolStripStatusLabel tsslDurum;
        private System.Windows.Forms.ToolStripMenuItem tsmiHakkinda;
    }
}

