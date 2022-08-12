using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {

            string urunadi = "Elma";
            double fiati = 15;
            string aciqlama = "Amasya elmai";

            string[] meveler = new string[] {"Elma","Karpuz" };

            Urun urun1 = new Urun();
            urun1.Adi = "Elma";
            urun1.Fiati = 15;
            urun1.Aciklama = "Amasya elmai";

            Urun urun2 = new Urun();
            urun2.Adi = "Karpuz";
            urun2.Fiati = 80;
            urun2.Aciklama = "Diyarbakir karpuzu";

            Urun[] urunler = new Urun[] {urun1,urun2};

            //type-safe -- tip guvenli
            //foreach (var urun in urunler) 
            foreach (Urun urun in urunler)  
            {
                Console.WriteLine(urun.Adi);

                Console.WriteLine(urun.Fiati);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine("------------------------------------------");
            }



            Console.WriteLine("============== Metotlar =============");
            //intanse - ornek
            //encapulation
            Console.WriteLine("------------------ Ekle1 ---------------------");
            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);
                sepetManager.Ekle(urun2);

            Console.WriteLine("============== Ekle2 =============");
            sepetManager.Ekle2("Armut", "Yesil armut", 12, 10);
            sepetManager.Ekle2("Elma", "Yesil elma", 12, 9);
            sepetManager.Ekle2("Karpiz", "Diyarbakir karpizi", 12, 8);

        }
    }
}


//Dont repeat yourslf - DRY - Clean code -Best Practice