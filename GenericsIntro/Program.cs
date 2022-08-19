using System;

namespace GenericsIntro    //List -evezi nece yazardiq?
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<string> isimler = new MyList<string>();
           isimler.Add("Engin");
           Console.WriteLine(isimler.Length);

           isimler.Add("Kerem");
           Console.WriteLine(isimler.Length);

            foreach (var isim in isimler.Items)  //(var item in isimler.Items)
            {
                Console.WriteLine(isim);        //Console.WriteLine(item);
            }


            Console.WriteLine("Hello World!");
        }
    }
}
