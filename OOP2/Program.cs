// See https://aka.ms/new-console-template for more information

using OOP2;

GercekMusteri musteri1 = new GercekMusteri();
musteri1.Id = 1;
musteri1.MusteriNo = "12345";
musteri1.Adi = "Ümit";
musteri1.soyadi = "Arlı";
musteri1.Tcno = "12344534";

TuzelMusteri musteri2 = new TuzelMusteri();
musteri2.Id = 2;
musteri2.MusteriNo = "1234";
musteri2.SirketAdi = "Samsung";
musteri2.VergiNo = "345456";

Musteri musteri3 = new GercekMusteri();
Musteri musteri4 = new TuzelMusteri();

CustomerManager customerManager = new CustomerManager();
customerManager.Add(musteri4);
customerManager.Add(musteri3);