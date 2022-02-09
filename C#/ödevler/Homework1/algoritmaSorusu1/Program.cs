using System;

namespace algoritmaSorusu1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--------------- Çift Sayı Bulma Uygulamasına Hoş Geldiniz ---------------");
            Console.Write("Pozitif sayı adedi giriniz :");
            int diziUzunlugu = int.Parse(Console.ReadLine());
            int[] sayiDizisi = new int[diziUzunlugu];
            for (int i = 0; i < diziUzunlugu; i++)
            {
                Console.WriteLine("Lütfen {0}. Sayıyı Giriniz",i+1);
                sayiDizisi[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("----------------------");
            for (int i = 0; i < sayiDizisi.Length; i++)
            {
                if(sayiDizisi[i] % 2 == 0)
                {
                    Console.WriteLine(sayiDizisi[i]);
                }
            }
        }
    }
}


/*
Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin(n). 
Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin. Kullanıcının
 girmiş olduğu sayılardan çift olanlar console'a yazdırın.
*/