using System;

namespace _25_enum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Gunler.Pazar);
            Console.WriteLine((int)Gunler.Cumartesi);
            int sicaklik = 32;
            if (sicaklik <= (int)HavaDurumu.Normal)
            {
                Console.WriteLine("Dışarı çıkmak için havanın ısınmasını bekleyin.");
            }
            else if (sicaklik >= (int)HavaDurumu.Sicak)
            {
                Console.WriteLine("Çok sıcak bir gün.");
            }
            else if ( sicaklik >= (int)HavaDurumu.Normal && sicaklik <= (int)HavaDurumu.CokSicak)
            {
                Console.WriteLine("Hadi dışarı çıkalım");
            }
        }
    }

    enum Gunler
    {
        Pazartesi,
        Sali,
        Carsamba,
        Persembe,
        Cuma,
        Cumartesi=23,
        Pazar
    };

    enum HavaDurumu
    {
        Soguk = 5,
        Normal = 20,
        Sicak = 25,
        CokSicak = 30

    };
}
