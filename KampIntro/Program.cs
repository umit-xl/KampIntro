using System;

namespace KampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            // type safety - tip güveniliği
            // do not repeat yourself
            string katagoriEtiketi = "Kategoriler";
            int ogrenciSayisi = 32000;
            double faizOrani = 1.45;
            bool sistemeGirisYapmisMi = true;
            double dolarDun = 7.55;
            double dolarBugun = 7.55;

            if (dolarDun>dolarBugun)
            {
                Console.WriteLine("Azalış oku");
            }
            else if (dolarDun<dolarBugun)
            {
                Console.WriteLine("Artış oku");
            }
            else
            {
                Console.WriteLine("Değişmedi oku");
            }
          

            if (sistemeGirisYapmisMi == true)
            {
                Console.WriteLine("Ayarlar butonu");
            }

            else
            {
                Console.WriteLine("Giriş yap butonu");
            }

            Console.WriteLine(katagoriEtiketi);
            
        }
    }
}