using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace RssTakipLibrary.RssKanal
{
    public class Kanal
    {
        private string _ad;

        public string Ad
        {
            get => _ad;
            set
            {
                _ad = value;
                if (string.IsNullOrWhiteSpace(_ad))
                    _ad = null;
            }
        }

        private string _link;

        public string Link
        {
            get => _link;
            set
            {
                _link = value;
                if (!HtmlDeseni().IsMatch(_link))
                {
                    MessageBox.Show(@"RSS Kanal linki boş veya yanlış. Bir kontrol edin derim.", @"Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    _link = null;
                }
            }
        }

        private static Regex HtmlDeseni()
        {
            string desen = @"^(ht)tp(s?)\:\/\/[0-9a-zA-Z]([-.\w]*[0-9a-zA-Z])*(:(0-9)*)*(\/?)([a-zA-Z0-9\-\.\?\,\'\/\\\+&amp;%\$#_]*)?$";
            return new Regex(desen);
        }
    }
}