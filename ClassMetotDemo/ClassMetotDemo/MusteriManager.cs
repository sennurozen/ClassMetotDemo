using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void Kaydet(Musteri musteri)
        { Console.WriteLine("Yeni müşteri başarıyla kaydedildi.   "+ musteri.TcNo +"-" + musteri.AdıSoyadı + " :" +musteri.Aciklama);
        
        }
        public void Sil(Musteri musteri)
        {
            Console.WriteLine( "Müşteri silindi." + musteri.TcNo + "-" + musteri.AdıSoyadı);
        }

        public void Listele(Musteri musteri)
        {
             Console.WriteLine("Müşteriler listelendi: " + "\n" + musteri.AdıSoyadı);
        }

    }
}
