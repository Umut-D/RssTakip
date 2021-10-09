using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;

namespace RssTakipLibrary.RssKanal
{
    public class Dosya
    {
        private readonly Islem _islem;
        private readonly XmlSerializer _xmlSerialize;
        private readonly string _kayitDizini = Application.StartupPath + @"\" + "RssKanallari.xml";

        public Dosya(Islem islem)
        {
            _islem = islem;

            if (_islem != null)
                _xmlSerialize = new XmlSerializer(_islem.RssKanallari.GetType());
        }

        public void Kaydet()
        {
            EskiRssBelgesiniSil();

            using (FileStream dosyaAkis = new FileStream(_kayitDizini, FileMode.Create))
            {
                if (_islem != null)
                    _xmlSerialize.Serialize(dosyaAkis, _islem.RssKanallari);
            }
        }

        private void EskiRssBelgesiniSil()
        {
            if (File.Exists(_kayitDizini))
                File.Delete(_kayitDizini);
        }

        public void Yukle()
        {
            using (FileStream dosyaAkis = new FileStream(_kayitDizini, FileMode.OpenOrCreate))
            {
                XmlTextReader xmlOku = new XmlTextReader(dosyaAkis);
                FileInfo xmlBelgeBilgi = new FileInfo(_kayitDizini);

                if (xmlBelgeBilgi.Exists && xmlBelgeBilgi.Length != 0)
                {
                    _islem.RssKanallari.Clear();
                    _islem.RssKanallari?.AddRange((IEnumerable<Kanal>) _xmlSerialize.Deserialize(xmlOku));
                }
            }
        }
    }
}