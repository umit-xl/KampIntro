using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metotlar
{
    internal class SepetManager
    {
        public void Ekle(Urun urun)
        {
            Console.WriteLine("Tebrlikler. Sepete Eklendi : " + urun.Adi);

        }

        public void Ekle2(Urun urun)
        {
            Console.WriteLine("Tebrlikler. Sepete Eklendi!! : " + urun.Adi);
        }
    }
}
