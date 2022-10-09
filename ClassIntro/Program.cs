// See https://aka.ms/new-console-template for more information

Kurs kurs1 = new Kurs();
kurs1.KursAdi = "c#";
kurs1.Egitmeni = "Engin";
kurs1.IzlenmeOrani = 68;

Kurs kurs2 = new Kurs();
kurs2.KursAdi = "Java";
kurs2.Egitmeni = "Umit";
kurs2.IzlenmeOrani = 100;


//Console.WriteLine(kurs1.KursAdi + ":" + kurs1.Egitmeni);

Kurs[] kurslar = new Kurs[] 
{
    kurs1, kurs2
};
foreach (var kurs in kurslar)
{
    Console.WriteLine(kurs.KursAdi + " : " + kurs.Egitmeni);
}


class Kurs
{
    public string KursAdi { get; set; }
    public string Egitmeni { get; set; }
    public int IzlenmeOrani { get; set; }
}


