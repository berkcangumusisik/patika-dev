using System;

namespace _02_Degisken
{
    class Program
    {
        static void Main(string[] args)
        {
            int deger = 2;
            string degisken = "";
            string Degisken = null;

            byte b = 5;
            sbyte c = 5;

            short s = 5;
            ushort us = 5;

            Int16 i16 = 2;
            int i = 2;
            Int32 i32 = 2;
            Int64 i64 = 2;

            uint ui = 2;
            long l = 4; 
            ulong ul = 4;

            float f = 5;
            double d = 5;
            decimal de = 5;

            char ch = '2';
            string str = "Berkcan";

            bool b1 = true;
            bool b2 = false;

            DateTime d1 = DateTime.Now;

            Console.WriteLine(deger);
            Console.WriteLine(degisken);
            Console.WriteLine(Degisken);
            Console.WriteLine(d1);

            object o1 = "x";
            object o2 = 'a';
            object o3 = 4;
            object o4 = 4.2;


            //STRING İFADELER
            string str1 = string.Empty;
            str1 = "Berkcan Gümüşışık";
            string ad = "Berkcan";
            string soyAd = "Gümüşışık";
            string TamIsim = ad +" " + soyAd;


            // integer

            int int1 = 5;
            int int2 = 3;
            int int3 = int1 * int2;


            //boolean
            bool bool1 = 10 > 2;


            //Değişken Dönüşümleri
            string str20 = "20";
            int int20 = 21;
            string yeniDeger = str20 + int20.ToString();
            Console.WriteLine(yeniDeger);


            int int21 = int20 + Convert.ToInt32(str20);
            Console.WriteLine(int21); //Çıktısı 41 

            int int22 = int20 + int.Parse(str20);//Çıktısı 41 

            //datetime

            string date = DateTime.Now.ToString("dd.MM.yyyy");
            string date2 = DateTime.Now.ToString("dd/MM/yyyy");
            string date3 = DateTime.Now.ToString("HH:mm");
            Console.WriteLine(date);
            Console.WriteLine(date2);
            Console.WriteLine(date3);
        }
    }
}

/**
 * Büyük küçük harfe duyarlıdır.
 * Değişken adları rakamla başlayamaz. int 3degisken = 3
 * Programlamaya özel isimler verilemez. string if ="";
 * Aynı kod bloğu birden çok kez tanımlanamaz.
 * Değişken ismi tanımlanırken büyük harf, küçük harf, _ veya rakam kullanılabilir.
 * 
 
 */


/***
 * String => metinsel ifadelerdir. "" içinde yazılır.
 * byte => Bellekte 1 byte yer kaplar. 0 ile 255 arasında
 * sbyte => Bellekte 1 byte yer kaplar. -128 ile 127 arasında değer alır.
 * short => 2 byte yer kaplar. 
 * ushort => 2 byte yer kaplar. 0 ile 65300 arasında değer alır.
 * Int16 => 2 byte yer kaplar. 
 * int => 4 byte yer kaplar. 
 * Int32 => 4 byte yer kaplar. 
 * Int64 => 8 byte yer kaplar. 
 * uint => 4 byte yer kaplar.
 * long => 8 byte yer kaplar.
 * ulong => 8 byte yer kaplar.
 * float => 4 byte yer kaplar. reel sayılar
 * double => 8 byte yer kaplar.reel sayılar
 * decimal => 16 byte yer kaplar.reel sayılar
 * char => 2 byte yer kaplar. Tek karakter tutmayı sağlar.
 * String => Sınırsız yer tutar. Sınırı aslında yazdıklarımızla biz belirleriz. Metinsel yapılardır.
 * bool => true ya da false değer tutar.
 * DateTime => zaman tutar.
 * TÜM DEĞİŞKEN TÜRLERİ object ÜZERİNDEN DOĞMUŞTUR.
 */