using System;

namespace Donguler 
{
    class Program
    {
        static void Main(string[] args)
        {
            //array-diziler

            string[] kurslar = new string[]
            {
             "Yazılım geliştirme kursu" ,
             "Java" ,
             "Programlamaya başlangıç",
             "Python"
            };


            for (int i = 0; i < kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }

            Console.WriteLine("For bitti");

            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }

            Console.WriteLine("Sayfa Sonu");
        }
    }
}

