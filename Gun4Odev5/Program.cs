// See https://aka.ms/new-console-template for more information
using Gun4Odev5;
using System.Collections.Generic;

//Dictionary<int, string> yapilanIsSayisi = new Dictionary<int, string>();

//yapilanIsSayisi.Add(10, "Ümit");
//yapilanIsSayisi.Add(8, "Ceylin");

//foreach (var sirala in yapilanIsSayisi)
//{
//    Console.WriteLine(sirala);
//}

//bunu kendin olusturacaksın

MyDictionary<string, int> islemDurumu = new MyDictionary<string, int>();
islemDurumu.Add("Ümit", 15);
islemDurumu.Add("Ceylin", 10);
islemDurumu.Add("Kiara", 5);

islemDurumu.Listele();


