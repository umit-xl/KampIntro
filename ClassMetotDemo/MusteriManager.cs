using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetotDemo
{
    internal class MusteriManager
    {
        public void MusteriEkle (Musteri musteri)
        {
            Console.WriteLine("Müşteri Eklendi");
        }

        public void MusteriSil(Musteri musteri)
        {
            Console.WriteLine("Müşteri Silindi");
        }

        public void MusteriListele(Musteri[] musteri)
        {
            foreach (var item in musteri)
            {
                Console.WriteLine("Müşteriler =  " + item.AdSoyad);
            }
            
        }
    }
}
