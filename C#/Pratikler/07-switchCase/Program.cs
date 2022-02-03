using System;

namespace _07_switchCase
{
    class Program
    {
        static void Main(string[] args)
        {
            int ay = DateTime.Now.Month;
            switch (ay)
            {
                case 1:
                    Console.WriteLine("Ocak ayı");
                    break;
                case 2:
                    Console.WriteLine("Şubat ayı");
                    break;
                case 3:
                    Console.WriteLine("Mart ayı");
                    break;
                case 4:
                    Console.WriteLine("Nisan ayı");
                    break;
                case 5:
                    Console.WriteLine("Mayıs ayı");
                    break;
                default:
                    Console.WriteLine("Yanlış veri");
                    break;
            }

            switch (ay)
            {
                case 1:
                case 2:
                case 12:
                    Console.WriteLine("Kış Mevsimi");
                    break;
                case 3:
                case 4:
                case 5:
                    Console.WriteLine("İlkbahar Mevsimi");
                    break;
                default:
                    Console.WriteLine("Mevsim Belirsiz");
                    break;

            }
        }
    }
}
