using System;

namespace algoritmaSorusu2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Bir pozitif sayı giriniz: ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Bir pozitif sayı giriniz: ");
            int m = int.Parse(Console.ReadLine());

            int[] sayiDizisi = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Lütfen {0}. Sayıyı Giriniz",i+1);
                sayiDizisi[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < sayiDizisi.Length; i++)
            {
                if (sayiDizisi[i] % m == 0)
                {
                    Console.WriteLine(sayiDizisi[i]+" m Sayısına Tam Bölünmektedir.");
                }

                else if (sayiDizisi[i] == m)
                {
                    Console.WriteLine(sayiDizisi[i]+" m sayısına eşittir.");
                }
            }
        }
    }
}
/*
Bir konsol uygulamasında kullanıcıdan pozitif iki sayı girmesini isteyin (n, m). 
Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin. 
Kullanıcının girmiş olduğu sayılardan m'e eşit yada tam bölünenleri console'a yazdırın.
*/