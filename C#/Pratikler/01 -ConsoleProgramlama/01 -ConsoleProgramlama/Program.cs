using System;

namespace _01__ConsoleProgramlama
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("İsminizi Giriniz:");
            string isim = Console.ReadLine();
            Console.WriteLine("Soyadınızı Giriniz:");
            string soyad = Console.ReadLine();
            Console.WriteLine("Merhaba " + isim + " " + soyad);
        }
    }
}


// Console.WriteLine() ekrana yazdırmayı sağlar
