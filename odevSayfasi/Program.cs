// See https://aka.ms/new-console-template for more information


Telefon telefon1 = new Telefon();

Telefon telefon2 = new Telefon();



telefon1.Uretici = "Samsung";
telefon1.Model = "Fold 4";
telefon1.Fiyat = 30000;

telefon2.Uretici = "iPhone";
telefon2.Model = "iPhone 14";
telefon2.Fiyat = 40000;


//foreach ile döndürülmesi 


Telefon[] telefonlar = new Telefon[]
{
    telefon1, telefon2
};

foreach (var tel in telefonlar)
{
    Console.WriteLine(tel.Uretici + " : " + tel.Model + " : "
        + tel.Fiyat);
}

//for ile döndürülmesi

for (int i = 0; i < telefonlar.Length; i++)
{
    Console.WriteLine(telefonlar[i].Uretici + " : " + telefonlar[i].Model + " : " +  
        telefonlar[i].Fiyat);
}


//while döngüsü

int a = 0; 

while (a < telefonlar.Length)
{
    Console.WriteLine(telefonlar[a].Uretici + " : " + telefonlar[a].Model + " : " +
        telefonlar[a].Fiyat);

    a++;
}
class Telefon
{
    public string Uretici { get; set; }
    public string Model { get; set; }

    public int Fiyat { get; set; }

}

