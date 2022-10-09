using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Metotlar
{
    class SepetManager
    {
        public void Ekle(Urun urun)
        {
            Console.WriteLine("Tebrikler. Sepete eklendi : " + urun.Adi);

        }

        public void Ekle2(string urunAdi , string urunAciklama, int Fiyat)
        {
            Console.WriteLine("Sepete Eklendi : " + urunAdi);
        }
    }
}
