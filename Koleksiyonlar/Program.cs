using System;
using System.Collections.Generic;

namespace Koleksiyonlar
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] isimler = new string[] { "engin", "mert", "cem", "mete", "emine", "ayşe", "fatma", "elif" };
            //console.writeline(isimler[0]);
            //console.writeline(isimler[1]);
            //console.writeline(isimler[2]);
            //console.writeline(isimler[3]);
            //console.writeline(isimler[4]);
            //console.writeline(isimler[5]);
            //console.writeline(isimler[6]);
            //console.writeline(isimler[7]);
            List<string> sehirler = new List<string> { "Ankara", "Antalya", "Ardahan", "Afyon", "Antep", "Adana", "Antakya", "Aydın", "Artvin", "Amasya", "Ağrı", "Aksaray", "Adıyaman" };
            Console.WriteLine("Türkiye' de " + sehirler.Count + " tane a ile başlayan il vardır");
            Console.WriteLine("İller sırasıyla:");
            Console.WriteLine("1)" + sehirler[0]);
            Console.WriteLine("2)" + sehirler[1]);
            Console.WriteLine("3)" + sehirler[2]);
            Console.WriteLine("4)" + sehirler[3]);
            Console.WriteLine("5)" + sehirler[4]);
            Console.WriteLine("6)" + sehirler[5]);
            Console.WriteLine("7)" + sehirler[6]);
            Console.WriteLine("8)" + sehirler[7]);
            Console.WriteLine("9)" + sehirler[8]);
            Console.WriteLine("10)" + sehirler[9]);
            Console.WriteLine("11)" + sehirler[10]);
            Console.WriteLine("12)" + sehirler[11]);
            Console.WriteLine("13)" + sehirler[12]+"' dır");
        }
    }
}
