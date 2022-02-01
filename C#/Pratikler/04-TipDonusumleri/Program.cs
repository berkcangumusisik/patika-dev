using System;

namespace _04_TipDonusumleri
{
    class Program
    {
        static void Main(string[] args)
        {
            //Implicit Conversition(Bilinçsiz Dönüşüm)
            /*Bir değişkenin kendinden daha yüksek kapasiteli bir değişkene atanmasıdır. Hedef değişkenin veri tipi bellekte yeterli alana sahip olacağından, bu dönüşümde bir veri kaybı söz konusu olmayacaktır. Dolayısıyla bu dönüşüm kendiliğinden yapılabilir.*/
            Console.WriteLine("------- Implicit Conversition ---------");
            byte a = 5;
            sbyte b = 30;
            short c = 10;

            int d = a + b + c;
            Console.WriteLine("Toplama işleminin sonucu : " + d);
            long h = d;
            Console.WriteLine("Long değeri : " + h);

            float i = d;
            Console.WriteLine("Float Değeri : " + i);

            string e = "berkcan";
            char f = 'g';
            object g = e + f + d;
            Console.WriteLine("Object Değeri : " + g);

            //Explicit Conversition(Bilinçli Dönüşüm)

            /*Bilinçli olarak yazılımcının yaptığı dönüşümdür.*/
            Console.WriteLine("------- Explicit Conversition ---------");
            int x = 4;
            byte y = (byte)x;
            Console.WriteLine("y = " + y);

            int z = 100;
            byte t = (byte)z;
            Console.WriteLine("t = " + t);

            float w = 10.3f;
            byte v = (byte)w;
            Console.WriteLine("v = " + w);

            //ToString metodu : Aldığı veriyi stringe çevirir.
            Console.WriteLine("------- ToString Metodu---------");
            int xx = 6;
            string yy = xx.ToString();
            Console.WriteLine("yy = " + yy);

            string zz = 12.5f.ToString();
            Console.WriteLine("zz = " + zz);

            //System.Convert
            Console.WriteLine("------- System.Convert Sınıfı---------");
            string s1 = "10", s2 = "20";
            int sayi1, sayi2;
            int toplam;
            sayi1 = Convert.ToInt32(s1);
            sayi2 = Convert.ToInt32(s2);
            toplam = sayi1 + sayi2;
            Console.WriteLine("Toplam = " + toplam);

            //Parse
            Console.WriteLine("------- Parse Sınıfı---------");
            ParseMethod();
        }

        public static void ParseMethod()
        {
            string metin1 = "10";
            string metin2 = "10.25";
            int rakam1;
            double double1;
            rakam1 = Int32.Parse(metin1);
            double1 = Double.Parse(metin2);
            Console.WriteLine(rakam1);
            Console.WriteLine(double1);

        }
    }
}
