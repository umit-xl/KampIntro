using System;

namespace KampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            string kurs1 = "Yazılım Geliştirici Yetiştirme Kampı";
            string kurs2 = "Proglamlamaya başlnagıç için temel kurs";
            string kurs3 = "Java";

            //array - dizi 

            string[] kurslar = new string[] { kurs1, kurs2 , kurs3};

            for (int i = 0; i < kurslar.Length; i++)
            {

                Console.WriteLine(kurslar[i]);
            }

            Console.WriteLine("sayfa sonu");

            for (int i = 1; i <= 10; i=i+2)
            {
                Console.WriteLine(i + " defa giriş yaptınız");
            }


            Console.WriteLine("for bitti");
            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }
        }
    }
}