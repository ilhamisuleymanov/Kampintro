using System;

namespace Kampintro
{
    class Program
    {
        static void Main(string[] args)
        {
            //type safety - tip guvenliyi
            //Do not repeat yourself - kendini tekrarlama
            //deger tutucu,   alias
            string kategoriEtiketi = "Kategoriler";
            int ogrenciSayisi = 32000;
            double faizOrani = 1.45;
            bool sistemeGirisYapmisMi = true;  //  bool sistemeGirisYapmisMi = sistemeGirisYapmisMiBiBak();
            double dollarDun = 7.35;
            double dollarBugun = 7.45;

            if (dollarDun> dollarBugun)
            {
                Console.WriteLine("Azalış butonu");

            }
            else if (dollarDun < dollarBugun)
            {

                Console.WriteLine("Artış butonu");
            }
              else
            {
                Console.WriteLine("değişmədi buton");  // dollarDun = dollarBugun
            }

            if (sistemeGirisYapmisMi == true)
            {
                Console.WriteLine("Kullanci ayarlari butonu");

            }
            else
            {
                Console.WriteLine("Giriş yap butonu");
            }
         
            Console.WriteLine(kategoriEtiketi);
            // Console.WriteLine("Hello World!");



        }
    }
}
