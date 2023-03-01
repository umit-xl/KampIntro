using ClassMetotDemo;
using System;

namespace KampIntro
{
    class Program
    {
        

        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            Musteri musteri2 = new Musteri();
            Musteri musteri3 = new Musteri();
            Musteri musteri4 = new Musteri();

            musteri1.AdSoyad = "Ümit ARLI";
            musteri1.SubeAdi = "Keçiören";
            musteri1.Yas = 23;
            musteri1.Id = 5;

            musteri2.AdSoyad = "Ceylin Özmercan";
            musteri2.SubeAdi = "Karabağlar";
            musteri2.Yas = 22;
            musteri2.Id = 4;

            musteri3.AdSoyad = "Eymen Arlı";
            musteri3.SubeAdi = "Seyhan";
            musteri3.Yas = 8;
            musteri3.Id = 3;

            musteri4.AdSoyad = "Alba Arlı";
            musteri4.SubeAdi = "Keçiören";
            musteri4.Yas = 1;
            musteri4.Id = 7;

            Musteri[] musteriler = new Musteri[] { musteri1, musteri2, musteri3, musteri4 }; 
            MusteriManager musteriManager = new MusteriManager();

            musteriManager.MusteriEkle(musteri1);
            musteriManager.MusteriSil(musteri2);
            musteriManager.MusteriListele(musteriler);

        }
    }
}
