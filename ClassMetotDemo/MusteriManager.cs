using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void Ekle1(Musteriler kullanici)
        {
            Console.WriteLine("Müşteri Eklendi : " + kullanici.MusteriAdiSoyadi);
            
        }

        public void Silme1(Musteriler silinecekKullanici)
        {
            Console.WriteLine("Müşteri Silindi : " + silinecekKullanici.MusteriAdiSoyadi);
        }

        public void Listeleme1(Musteriler[] listeleme)
        {
            
            foreach (var listele in listeleme)
            {
                Console.WriteLine(listele.MusteriAdiSoyadi);
                Console.WriteLine(listele.MusteriTelNo);
                Console.WriteLine(listele.Adres);
                Console.WriteLine("-------------------");
            }
        }
    }
}
