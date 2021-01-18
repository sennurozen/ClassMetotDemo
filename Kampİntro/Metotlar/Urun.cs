using System;
using System.Collections.Generic;
using System.Text;

namespace Metotlar
{
    class Urun
    {

        Urun urun1 = new Urun();
        urun1.Adi = "Elma";
        urun1.Fiyati = "15";
        urun1.Aciklama = "Amasya elması";

        Urun urun2 = new Urun();
        urun2.Adi = "Karpuz";
        urun2.Fiyati = "60";
        urun2.Aciklama = "Diyarbakır karpuzu";

            Urun[] urunler = new Urun[] { urun1, urun2 };

            foreach (var urun in urunler)
            {
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine("..........");
            }
}
}
