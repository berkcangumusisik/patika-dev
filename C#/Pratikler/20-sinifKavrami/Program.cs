using System;

namespace _20_sinifKavrami
{
    class Program
    {
        static void Main(string[] args)
        {
            Calisan calisan1 = new Calisan();
            calisan1.Ad = "Berkcan";
            calisan1.Soyad = "Gümüşışık";
            calisan1.No = 123456;
            calisan1.Departman = "Yazılım Geliştirme";

            calisan1.CalisanBilgiler();

            Calisan calisan2 = new Calisan();
            calisan2.Ad = "Şevval";
            calisan2.Soyad = "Baydemir";
            calisan1.No = 123457;
            calisan1.Departman = "Sosyal Medya";

            calisan2.CalisanBilgiler();
        }
    }

    class Calisan
    {
        public string Ad;
        public string Soyad;
        public int No;
        public string Departman;

        public void CalisanBilgiler()
        {
            Console.WriteLine("Çalışan Adı {0}",Ad);
            Console.WriteLine("Çalışan Soyadı {0}",Soyad);
            Console.WriteLine("Çalışan Numarası {0}",No);
            Console.WriteLine("Çalışan Departmanı {0}",Departman);
        }
    }
}
/*
* SINIFLAR
class SinifAdi
{
    [Erişim Belirleyici][Veri Tipi] ÖzellikAdı;
    [Erişim Belirleyici][Geri Dönüş Değerinin Tipi] MetotAdi([Parametreler])
    {
        //Metot Gövdesi
    }
}

ERİŞİM BELİRLEYİCİ
1. Public : Her yerden erişilebilir.

2. Private : Sadece tanımlandığı sınıf içerisinden erişilebilir.

3. Internal : Sadece bulunduğu proje içerisinden erişilebilir

4. Protected : Sadece tanımlandığı sınıfta ya da o sınıfı miras alan sınıflardan erişilebilir.
*/
