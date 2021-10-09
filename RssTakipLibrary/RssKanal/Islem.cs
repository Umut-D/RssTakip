using System.Collections.Generic;

namespace RssTakipLibrary.RssKanal
{
    public class Islem
    {
        public List<Kanal> RssKanallari { get; private set; }

        public Islem()
        {
            RssKanallari = new List<Kanal>();
        }

        public void Ekle(Kanal kanal)
        {
            RssKanallari.Add(kanal);
        }

        public void Sil(int indeks)
        {
            if (indeks == -1)
                RssKanallari.Clear();
            else
                RssKanallari.RemoveAt(indeks);
        }
    }
}