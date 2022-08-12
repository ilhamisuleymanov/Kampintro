using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            string adi = "Engin";
            int ya = 36;

            Kurs kurs1 = new Kurs();  //kurs1  Kurs klassının bir xususi deyişendir (obyektidir)
            kurs1.KursAdi = "C#";
            kurs1.Egitmen = "Engin DemiroĞ";
            kurs1.IzlenmeOrani = "68";

            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "Java";
            kurs2.Egitmen = "Kerem Varis";
            kurs2.IzlenmeOrani = "64";

            Kurs kurs3 = new Kurs();
            kurs3.KursAdi = "Phyton";
            kurs3.Egitmen = "Berkay Bilgin";
            kurs3.IzlenmeOrani = "80";

            Kurs kurs4 = new Kurs();
            kurs4.KursAdi = "C++";
            kurs4.Egitmen = "Murat Kurtboğan";
            kurs4.IzlenmeOrani = "80";
            /*
            Console.WriteLine(kurs1.KursAdi + " : " + kurs1.Egitmen);
            Console.WriteLine(kurs2.KursAdi + " : " + kurs2.Egitmen);
            Console.WriteLine(kurs3.KursAdi + " : " + kurs3.Egitmen);
            */

            Kurs[] kurslar = new Kurs[] {kurs1, kurs2, kurs3, kurs4};
            foreach (Kurs kurs in kurslar)   //foreach (var item in collection)
            {
                Console.WriteLine(kurs.KursAdi + " : " + kurs.Egitmen);
                
            }

            
            Console.WriteLine("Hello World!");
        }
    }


    class Kurs    // class MyClass 
    {
        //public int MyProperty { get; set; }
        //prop = property = özəllik
        public string KursAdi { get; set; }
        public string Egitmen { get; set; }
        public string IzlenmeOrani { get; set; }



    }


}
