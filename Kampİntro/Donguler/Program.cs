using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
         
            Console.WriteLine("Hello World!");

            Kurs kurs1 = new Kurs();
            kurs1.KursAdi = "C#";
            kurs1.Egitmen = "Engin";
            kurs1.IzlenmeOrani = "86";

            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "Python";
            kurs2.Egitmen = "Berkay";
            kurs2.IzlenmeOrani = "74";


            class Kurs
            public string KursAdi { get; set; }
            public string Egitmen { get; set; }
            public int IzlenmeOrani { get; set; }

        



        Kurs[] kurslar = new Kurs[] {kurs1, kurs2}; 
        foreach (var kurs in kurslar)
	        {
            Console.WriteLine(Kurs.KursAdi);
	}
           
        }
    }
}
