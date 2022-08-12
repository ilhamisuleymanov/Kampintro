using System;

namespace Donguler  //Döngü = цикль
{
    class Program
    {
        static void Main(string[] args)
        {

            //array  -  dizi
            string kurs1="Yazilim Gelistrici Yetitirme Kamp1";
            string kurs2="Proramlamaya baslangic icin tmel kurs";
            string kurs3="Java";
            string kurs4 = "Phyton";
            // Console.WriteLine(kurs1);
            //  Console.WriteLine(kurs2);
            //  Console.WriteLine(kurs3);
            //  Console.WriteLine(kurs4);

            string[] kurslar = new string[] {"Yazilim Gelistrici Yetitirme Kamp1", 
                "Proramlamaya baslangic icin tmel kurs", "Java","Phyton"};

            for (int i = 0; i <kurslar.Length; i++)     //length
            {
                Console.WriteLine(kurslar[i]);    //Javada --> System.out.println(kurslar[i])
            }
            Console.WriteLine("For bitti");
            Console.WriteLine("----------------------------------------------");

            foreach (string kurs in kurslar)   //dizi-massiv temelli yapilari tek-tek donmeye-dolaşmağa imkan verir
                                               //kurs  --> alias -dir. burda kurs yerine ixtiyari alias meselen baki, x ve saire yazma olar
            {
                Console.WriteLine(kurs);
            }

            Console.WriteLine("sayfa sonu - footer");

        }
    }
}
