using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri = new Musteri();
            Musteri[] musteriler = new Musteri[] { };

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(musteri);
            musteriManager.Listele(musteri);
            musteriManager.Sil();
        }
    }
}
