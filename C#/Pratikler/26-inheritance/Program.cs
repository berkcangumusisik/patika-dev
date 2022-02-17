using System;

namespace _26_inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            TohumluBitkiler tohumluBitki = new TohumluBitkiler();
            tohumluBitki.TohumlaCogalma();

            Console.WriteLine("***************");
            Kus marti = new Kus();
            marti.Ucmak();
        }
    }
}
