using System;
using System.Collections;
using System.Collections.Generic;

namespace _18_arrayList
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList liste = new ArrayList();
            liste.Add("Berkcan");
            liste.Add("Şevval");
            liste.Add("Nurana");
            liste.Add("Mete Serkan");
            liste.Add(2);
            liste.Add(true);

            //Veri Erişim
            Console.WriteLine(liste[1]);

            foreach (var item in liste)
            {
                Console.WriteLine(item);
            }

            //Add Range
            Console.WriteLine("********* Add Range ***********");
            //string[] renkler = {"Kırmızı","Sarı","Yeşil"};
            //liste.AddRange(renkler);

            List<int> sayilar = new List<int>() { 1, 8, 3, 7, 9, 92, 5 };
            liste.AddRange(sayilar);
            foreach (var item in liste)
            {
                Console.WriteLine(item);
            }

            //Sort
            Console.WriteLine("----- Sort ------");
            liste.Sort();
            foreach (var item in liste)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("------- Binary Search -------");
            Console.WriteLine(liste.BinarySearch(9));

            Console.WriteLine("------- Reverse -------");
            liste.Reverse();
            foreach (var item in liste)
            {
                Console.WriteLine(item);
            }

            liste.Clear();
        }

    }
}
