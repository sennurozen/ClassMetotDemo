using System;
using System.Collections.Generic;

namespace Koleksiyonlar
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> isimler = new List<string> { "Miray", "Şennur", "Fatma" };
            Console.WriteLine(isimler[0]);
            Console.WriteLine(isimler[1]);
            Console.WriteLine(isimler[2]);
            isimler.Add("Eda");
            Console.WriteLine(isimler[3]);
            Console.WriteLine(isimler[0]);
        }
    }
}
