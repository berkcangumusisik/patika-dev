using System;
using System.Collections.Generic;

namespace _17_genericMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            //List<T> class
            // T object türüdür

            List<int> sayiListesi = new List<int>();
            sayiListesi.Add(23);
            sayiListesi.Add(10);
            sayiListesi.Add(4);
            sayiListesi.Add(5);
            sayiListesi.Add(92);
            sayiListesi.Add(34);


            List<string> renkler = new List<string>();
            renkler.Add("Mavi");
            renkler.Add("Kırmızı");
            renkler.Add("Turuncu");
            renkler.Add("Sarı");
            renkler.Add("Yeşil");

            //Count
            Console.WriteLine(renkler.Count);
            Console.WriteLine(sayiListesi.Count);
            
            Console.WriteLine("---------- Sayı Listesi ----------");
            foreach (var sayi in sayiListesi)
            {
                Console.WriteLine(sayi);
            }

            Console.WriteLine("---------- Renk Listesi ----------");
            foreach (var renk in renkler)
            {
                Console.WriteLine(renk);
            }

            Console.WriteLine("---------- Sayı Listesi ----------");
            sayiListesi.ForEach(sayi => Console.WriteLine(sayi));

            Console.WriteLine("---------- Renk Listesi ----------");
            renkler.ForEach(renk => Console.WriteLine(renk));


            //Listeden eleman çıkarma
            sayiListesi.Remove(4);
            renkler.Remove("Yeşil");
            Console.WriteLine("---------- Sayı Listesi ----------");
            sayiListesi.ForEach(sayi => Console.WriteLine(sayi));

            Console.WriteLine("---------- Renk Listesi ----------");
            renkler.ForEach(renk => Console.WriteLine(renk));

            sayiListesi.RemoveAt(0);
            renkler.RemoveAt(0);

            Console.WriteLine("---------- Sayı Listesi ----------");
            sayiListesi.ForEach(sayi => Console.WriteLine(sayi));

            Console.WriteLine("---------- Renk Listesi ----------");
            renkler.ForEach(renk => Console.WriteLine(renk));

            //Liste içinde arama

            if(sayiListesi.Contains(10)){
                Console.WriteLine("10 sayısı bulundu");
            }

            //Eleman ile indekse erişme

            Console.WriteLine(renkler.BinarySearch("Sarı"));


            //Diziyi listeye çevirme
            string[] hayvanlar = {"Kedi","Köpek","Kuş"};
            List<string> hayvanListesi = new List<string>(hayvanlar);


            //Liste temizleme
            hayvanListesi.Clear();

            //List içerisinde nesne tutma
            List<Kullanıcılar> kullanıcıListesi = new List<Kullanıcılar>();
            Kullanıcılar kullanıcı1 = new Kullanıcılar();
            kullanıcı1.Isim = "Berkcan";
            kullanıcı1.Soyisim="Gümüşışık";
            kullanıcı1.Yas = 22;

            
            Kullanıcılar kullanıcı2 = new Kullanıcılar();
            kullanıcı2.Isim="Ayşe";
            kullanıcı2.Soyisim="Yılaz";
            kullanıcı2.Yas = 26;

            kullanıcıListesi.Add(kullanıcı1);
            kullanıcıListesi.Add(kullanıcı2);

            

        }
    }

    public class Kullanıcılar{
        private string isim;
        private string soyisim;
        private int yas;

        public string Isim { get => isim; set => isim = value; }
        public string Soyisim { get => soyisim; set => soyisim = value; }
        public int Yas { get => yas; set => yas = value; }
    }
}
