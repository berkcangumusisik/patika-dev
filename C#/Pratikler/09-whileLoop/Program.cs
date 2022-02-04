using System;

namespace _09_whileLoop
{
    class Program
    {
        static void Main(string[] args)
        {

            // 1'den console üzerinden girilen sayıya kadar ortalama hesaplayıp console üzerinden yazdırınız.
            Console.WriteLine("Bir sayı giriniz : ");
            int sayi = int.Parse(Console.ReadLine());
            int sayac = 1;
            int toplam = 0;
            while (sayac <= sayi)
            {
                toplam += sayi;
                sayac++;
            }
            Console.WriteLine("Sayıların ortalaması : " + (toplam/sayi));
            Console.WriteLine("--------------------------");
            //"a"dan "z"ye kadar console üzerinden yazdırınız.
            char character = 'a';
            while (character < 'z')
            {
                Console.Write(character);
                character++;
            }

            Console.WriteLine("--------------------------");
            string[] arabalar = { "BMW", "Ford", "Toyoto", "Nissan" };

            foreach (var araba in arabalar)
            {
               Console.WriteLine(araba);
            }

        }   
    }
}

/*
* While Döngüsü
Koşullar sağlandıkça komut satırlarının çalıştırılmasını sağlar. 
For döngüsünden farklı olarak iterasyon sayısı belli değildir.

*/