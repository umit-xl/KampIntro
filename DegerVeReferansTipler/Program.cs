using System;

namespace KampIntro
{
    class Program
    {
        static void Main(string[] args)
        {


            int sayi1 = 10;
            int sayi2 = 30;

            sayi1 = sayi2;

            sayi2 = 65;

            int[] sayilar1 = new int[] { 10, 20 , 30 };
            int[] sayilar2 = new int[] { 100, 200, 300 };
            sayilar1 = sayilar2;
            sayilar1[0] = 999;
            sayilar2[1] = 72839479;
            
            Console.WriteLine( "Sayilar : " +  sayilar1[1]);

            //int decimal float double bool = değer tip
            //array class interface = referans tip
        }
    }
}