using Metotlar;
using System;

namespace KampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            Urun urun1 = new Urun();
            Urun urun2 = new Urun();
            Urun urun3 = new Urun();

            urun1.Adi = "Elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Amasya elması";

            urun2.Adi = "Çilek";
            urun2.Fiyati = 10;
            urun2.Aciklama = "Çilek gibi çilek";

            Urun[] urunler = new Urun[] { urun1, urun2};

            //type-safe == tip güvenli
            foreach (Urun item in urunler)
            {
                Console.WriteLine(item.Adi);
                Console.WriteLine(item.Fiyati);
                Console.WriteLine(item.Aciklama);
                Console.WriteLine("----------------------------");

            }

            Console.WriteLine("----------Metotlar----------");

            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);

            sepetManager.Ekle2(urun1);
            sepetManager.Ekle2(urun2);
            
        }
    }
}

