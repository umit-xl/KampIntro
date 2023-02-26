using System;

namespace KampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            string adi = "Ümit";
            int yas = 23;

            Kurs kurs1 = new Kurs();

            kurs1.KursAdi = "C#";
            kurs1.Egitmeni = "Ümit Arlı";
            kurs1.IzlenmeOrani = 70;

            Kurs kurs2 = new Kurs();

            kurs2.KursAdi = "Java";
            kurs2.Egitmeni = "Alba";
            kurs2.IzlenmeOrani = 10000;

            Kurs kurs3 = new Kurs();

            kurs3.KursAdi = "Python";
            kurs3.Egitmeni = "Ceylin Arlı";
            kurs3.IzlenmeOrani = 70;

            //Console.WriteLine(kurs1.KursAdi + " " + kurs1.Egitmeni);

            Kurs[] kurslar = new Kurs[] { kurs1, kurs2, kurs3, };
            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs.KursAdi + " : " + kurs.Egitmeni);
            }
        }
    }

    class Kurs
    {
        public string KursAdi { get; set; }
        public string Egitmeni { get; set; }
        public int IzlenmeOrani { get; set; }

    }
}