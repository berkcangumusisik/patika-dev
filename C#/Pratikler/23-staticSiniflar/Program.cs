using System;

namespace _23_staticSiniflar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Çalışan Sayısı : {0}",Calisan.CalisanSayisi);
            Calisan calisan = new Calisan("Berkcan","Gümüşışık","Yazılım");
            Calisan calisan1 = new Calisan("Şevval","Baydemir","Yazılım");
            Calisan calisan3 = new Calisan("Nurana","Jumageldiyeve","Yazılım");
            Console.WriteLine("Çalışan Sayısı : {0}",Calisan.CalisanSayisi);
            
            Console.WriteLine("Toplama işleminin sonucu : {0}",Islemler.Topla(100,200));

            Console.WriteLine("Çıkarma işleminin sonucu : {0}",Islemler.Cikar(200,100));
        }
    }

    class Calisan
    {
        private static int calisanSayisi;

        public static int CalisanSayisi { get => calisanSayisi;}

        private string Isim;
        private string SoyIsim;
        private string Departman;

        static Calisan()
        {
            calisanSayisi = 0;
        }
        public Calisan(string isim, string soyIsim, string departman)
        {
            this.Isim = isim;
            this.SoyIsim = soyIsim;
            this.Departman = departman;
            calisanSayisi ++;
        }
    }
    static class Islemler
    {
        public static long Topla(int sayi1 , int sayi2)
        {
            return sayi1 + sayi2;
        }

        public static long Cikar(int sayi1 , int sayi2)
        {
            return sayi1 - sayi2;
        }
    }
}
