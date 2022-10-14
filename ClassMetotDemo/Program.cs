using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteriler musteri1 = new Musteriler();
            musteri1.MusteriAdiSoyadi = "Ümit ARLI";
            musteri1.MusteriTelNo = 539923;
            musteri1.Adres = "Ankara Keçioren";

            Musteriler musteri2 = new Musteriler();
            musteri2.MusteriAdiSoyadi = "Ceylin Özmercan";
            musteri2.MusteriTelNo = 534915;
            musteri2.Adres = "İzmir Karabağlar";

            //ekleme

            MusteriManager musteriDenetim = new MusteriManager();

            musteriDenetim.Ekle1(musteri1);

            musteriDenetim.Silme1(musteri2);

            Musteriler[] musteriler = new Musteriler[] {musteri1,musteri2 };
            musteriDenetim.Listeleme1(musteriler);

        }
    }
}    