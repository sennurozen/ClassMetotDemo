using System;

namespace Kampİntro
{
    class Program
    {
        static void Main(string[] args)
        {
            string Etiket = "Kategorilerbitti";
            int ogrenciSayisi = 32000;
            double dolarDun = 7.35;
            double dolarBugun = 7.35;

            if (dolarDun<dolarBugun)
            {
                Console.WriteLine("Büyüktür Butonu");
            }
            else if (dolarDun>dolarBugun)
            {
                Console.WriteLine("Küçüktür Butonu");
            }
            else
            {
                Console.WriteLine("Eşittir Butonu");
            }


            bool sistemeGirisYapmisMi = true;
            if (sistemeGirisYapmisMi==true )
            {
                Console.WriteLine("Profilim Butonu");
            }
            else
            {
                Console.WriteLine("Giriş Yap Butonu");
            }

            Console.WriteLine(Etiket);
        
        }
    }
}
