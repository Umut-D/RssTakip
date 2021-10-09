using System;
using System.Windows.Forms;
using RssTakipLibrary.RssFeed;
using RssTakipLibrary.RssKanal;
using RssTakipUI.Properties;

namespace RssTakipUI
{
    public partial class FrmRssTakip : Form
    {
        private readonly Islem _islem;
        private readonly Dosya _dosya;
        private readonly Haberler _haber;

        public FrmRssTakip()
        {
            InitializeComponent();

            _islem = new Islem();
            _dosya = new Dosya(_islem);
            _haber = new Haberler();
        }

        private void FrmRssTakip_Load(object sender, EventArgs e)
        {
            _dosya.Yukle();

            KanallariYukle(_islem);
        }

        private void KanallariYukle(Islem islem)
        {
            if (tvRssKanallari.Nodes.Count == 0)
                tvRssKanallari.Nodes.Add("RSS");

            if (islem.RssKanallari.Count != 0)
            {
                foreach (var kanal in islem.RssKanallari)
                    tvRssKanallari.Nodes[0].Nodes.Add(kanal.Ad);
            }

            tvRssKanallari.ExpandAll();
            tvRssKanallari.Sort();
        }

        private void TsmiRssEkle_Click(object sender, EventArgs e)
        {
            FrmRssEkle frmRssEkle = new FrmRssEkle(_islem);
            frmRssEkle.Show();

            frmRssEkle.FormClosing += FrmRssEkle_FormClosing;
        }

        private void FrmRssEkle_FormClosing(object sender, FormClosingEventArgs e)
        {
            tvRssKanallari.Nodes[0].Remove();
            FrmRssTakip_Load(sender, e);
        }

        private void CmsSil_Click(object sender, EventArgs e)
        {
            if (tvRssKanallari.SelectedNode == null)
                return;

            if (tvRssKanallari.SelectedNode.Parent == null)
            {
                _islem.Sil(-1);
                tvRssKanallari.SelectedNode.Remove();
            }
            else
            {
                _islem.Sil(tvRssKanallari.SelectedNode.Index);
                tvRssKanallari.SelectedNode.Remove();
            }
        }

        private void TvRssKanallari_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
                tvRssKanallari.SelectedNode = e.Node;
        }

        private void FrmRssTakip_FormClosing(object sender, FormClosingEventArgs e)
        {
            _dosya.Kaydet();
        }

        private async void TsmiGuncelle_Click(object sender, EventArgs e)
        {
            lstFeed.Items.Clear();

            foreach (var kvp in await _haber.AsenkronOku(_islem))
            {
                ListViewItem lvi = lstFeed.Items.Add(kvp.WebsiteAdi);
                lvi.SubItems.Add(string.Join(", ", kvp.Baslik));
                lvi.SubItems.Add(string.Join(", ", kvp.Tarih));
            }

            SutunGenisliginiOtomatikAyarla();

            SayiBilgileri();
        }

        private void SutunGenisliginiOtomatikAyarla()
        {
            lstFeed.Columns[0].AutoResize(ColumnHeaderAutoResizeStyle.ColumnContent);
            lstFeed.Columns[2].AutoResize(ColumnHeaderAutoResizeStyle.ColumnContent);
            lstFeed.Columns[1].Width = lstFeed.Width - (lstFeed.Columns[0].Width + lstFeed.Columns[2].Width) - 30; // ScrollBar'ı da hesaptan düştüm
        }

        private void SayiBilgileri()
        {
            Tuple<int, int> sayilar = _haber.KanalVeHaberSayisi();
            tsslDurum.Text = $@"{sayilar.Item1} kaynaktan, {sayilar.Item2} adet haber çekildi.";
        }

        private void FrmRssTakip_Resize(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                SutunGenisliginiOtomatikAyarla();

            if (WindowState == FormWindowState.Maximized)
                foreach (ColumnHeader sutunBaslik in lstFeed.Columns)
                    sutunBaslik.AutoResize(ColumnHeaderAutoResizeStyle.ColumnContent);
        }

        private void LstFeed_DoubleClick(object sender, EventArgs e)
        {
            string linkIcinAra = lstFeed.SelectedItems[0].SubItems[1].Text;
            string haberLinki = _haber.LinkBul(linkIcinAra);

            Link.Ac(haberLinki);
        }

        private void TsmiHakkinda_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Resources.Hakkinda1 + Environment.NewLine + Environment.NewLine + Resources.Hakkinda2, @"Hakkında", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}