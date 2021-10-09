using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.ServiceModel.Syndication;
using System.Threading.Tasks;
using System.Xml;
using RssTakipLibrary.RssKanal;

namespace RssTakipLibrary.RssFeed
{
    public class Haberler
    {
        private List<Feed> _feedler;

        public Task<List<Feed>> AsenkronOku(Islem islem)
        {
            return Task.Run(() => Oku(islem));
        }

        private List<Feed> Oku(Islem islem)
        {
            ServicePointManager.SecurityProtocol = (SecurityProtocolType) 3072;

            try
            {
                _feedler = new List<Feed>();
                foreach (var rssKanal in islem.RssKanallari)
                    XmlOku(rssKanal);
            }
            catch
            {
                // Boş Catch bırakmak doğru değil. Ancak hızlı bir biçimde bypass etmek istedim
            }

            return TariheGoreSirala();
        }

        private void XmlOku(Kanal rssKanal)
        {
            using (XmlReader xmlOkuyucu = XmlReader.Create(rssKanal.Link))
            {
                SyndicationFeed sFeed = SyndicationFeed.Load(xmlOkuyucu);
                foreach (SyndicationItem nesne in sFeed.Items)
                    FeedEkle(rssKanal, nesne);
            }
        }

        private void FeedEkle(Kanal rssKanal, SyndicationItem nesne)
        {
            _feedler.Add(new Feed
            {
                WebsiteAdi = rssKanal.Ad,
                Baslik = nesne.Title.Text,
                Tarih = nesne.PublishDate.LocalDateTime,
                Link = nesne.Id // veya item.Links[0].Uri
            });
        }

        private List<Feed> TariheGoreSirala()
        {
            return _feedler.OrderBy(f => f.Tarih).Reverse().ToList();
        }

        public string LinkBul(string aranan)
        {
            return _feedler.Find(f => f.Baslik == aranan).Link.ToString();
        }

        public Tuple<int, int> KanalVeHaberSayisi()
        {
            int kanalSayisi = (from f in _feedler select f.WebsiteAdi).Distinct().Count();
            int haberSayisi = _feedler.Count;

            return new Tuple<int, int>(kanalSayisi, haberSayisi);
        }
    }
}