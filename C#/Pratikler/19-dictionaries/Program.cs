using System;
using System.Collections.Generic;

namespace _19_dictionaries
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int,string> kullanicilar = new Dictionary<int, string>();

            kullanicilar.Add(1,"Berkcan Gümüşışık");
            kullanicilar.Add(2,"Şevval Baydemir");
            kullanicilar.Add(3,"Nurana Jumageldiyeva");
            kullanicilar.Add(4,"Mete Serkan Özdemir");

            Console.WriteLine("----- Elemana Erişim -----");
            Console.WriteLine(kullanicilar[1]);

            foreach (var item in kullanicilar)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine(kullanicilar.Count);

            Console.WriteLine(kullanicilar.ContainsKey(2));
            Console.WriteLine(kullanicilar.ContainsValue("Berkcan Gümüşışık"));

            kullanicilar.Remove(4);
            foreach (var item in kullanicilar)
            {
                Console.WriteLine(item);
            }
            foreach (var item in kullanicilar.Keys)
            {
                Console.WriteLine(item);
            }
            foreach (var item in kullanicilar.Values)
            {
                Console.WriteLine(item);
            }
        }
    }
}

/*
Dictionary koleksiyonunda key-value yani anahtar-deger denen 2 kavram ile karşılaşıyoruz. Dizilere eklediğimiz elemanları value, index lerini ise key olarak düşünebilirsiniz.

*/
