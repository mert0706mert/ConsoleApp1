using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string kontrol = "mert";
            int deger1= 20;
            double deger2 = 2.30;
            bool sistemDogruMu = true;
            double dolarınDunkuDegeri = 8.35;
            double dolarınBugunkuDegeri = 8.35;
            if (dolarınDunkuDegeri>dolarınBugunkuDegeri)
            {
                Console.WriteLine("azalış butonu");
            }
            else if(dolarınDunkuDegeri<dolarınBugunkuDegeri)
            {
                Console.WriteLine("artış butonu");
            }
            else
            {
                Console.WriteLine("değişmedi butonu");
            }
            if (sistemDogruMu==false)
            {
                Console.WriteLine("sisteme giriş yapmadı");
            }
            else
            {
                Console.WriteLine("ayarlar var mı ülen.");
            }

            Console.WriteLine(kontrol);
        }
    }
}
