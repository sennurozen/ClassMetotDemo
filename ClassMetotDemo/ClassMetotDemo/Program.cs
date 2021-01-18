using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.AdıSoyadı = "Miray Çakmaktepe";
            musteri1.TcNo = 1234567891;
            musteri1.DogumTarihi = 2015;
            musteri1.Aciklama = "17 Ocak tarihinde kayıt oldu";


            Musteri musteri2 = new Musteri();
            musteri2.AdıSoyadı = "Şennur Özen";
            musteri2.TcNo = 567867891;
            musteri2.DogumTarihi = 1995;
            musteri2.Aciklama = "18 Ocak tarihinde kayıt oldu";


            Musteri musteri3 = new Musteri();
            musteri3.AdıSoyadı = "Ayşenur x";
            musteri3.TcNo = 11111191;
            musteri3.DogumTarihi = 1999;
            musteri3.Aciklama = "12 Ocak tarihinde kayıt oldu";

           

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Kaydet(musteri1);
            musteriManager.Kaydet(musteri2);
            musteriManager.Sil(musteri3);
            musteriManager.Listele(musteri1);
        
 

        }
    }
}
