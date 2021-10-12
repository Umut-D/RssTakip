using System;
using System.Windows.Forms;
using RssTakipLibrary.RssKanal;

namespace RssTakipUI
{
    public partial class FrmRssEkle : Form
    {
        private readonly Islem _islem;

        public FrmRssEkle(Islem islem)
        {
            _islem = islem;
            InitializeComponent();
        }

        private void BtnEkle_Click(object sender, EventArgs e)
        {
            Kanal kanal = new Kanal
            {
                Ad = txtRssAd.Text,
                Link = txtRssLink.Text
            };

            if (!string.IsNullOrEmpty(kanal.Ad) && !string.IsNullOrEmpty(kanal.Link))
            {
                _islem.Ekle(kanal);
                MessageBox.Show(@"RSS Kanalı başarıyla listeye eklendi", @"Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            txtRssAd.Clear();
            txtRssLink.Clear();
        }

        private void FrmRssEkle_FormClosing(object sender, FormClosingEventArgs e)
        {
            Dosya dosya = new Dosya(_islem);
            dosya.Kaydet();
        }
    }
}