using System;

namespace _15_stringMetotlari
{
    class Program
    {
        static void Main(string[] args)
        {
            string degisken = "Dersimiz C# , Hoşgeldiniz.";
            string degisken2 = "Dersimiz C#.";
            //Lenght => kaç harf olduğunu verir.
            Console.WriteLine(degisken.Length);
            // ToUpper() => tüm karakterleri büyük yazdırır.
            //ToLower() => tüm karakterleri küçük yazdırır.
            Console.WriteLine(degisken.ToLower());
            Console.WriteLine(degisken.ToUpper());

            //Concat(degisken,eklemek istenilen) => Verilen değerin sonuna ekleme işlemi yapar.

            Console.WriteLine(String.Concat(degisken,"Merhaba!"));

            //Compare => Parametre olarak verilen iki string ifadeyi karşılaştırır ve geriye int türünde bir veri döndürür. Eğer dönüş değeri sıfır (0) ise iki metin birbirine eşittir. Aksi takdirde parametre olarak verilen metinleri ilk harflerinden itibaren tek tek karşılaştırır ve farklılığın olduğu ilk harflerin alfabedeki sıralarına göre -1 veya 1 sayı değerlerini döndürür.
            //CompareTo =>     String Compare yöntemi ile iki tane string değer karşılaştırılır.  Karşılaştırma da büyük küçük harf kontrolü ile sıralaması kontrol edilir.
            Console.WriteLine(degisken.CompareTo(degisken2));
            Console.WriteLine(String.Compare(degisken,degisken2,false));
            Console.WriteLine(String.Compare(degisken,degisken2,true));

            //Contains
            Console.WriteLine(degisken.Contains(degisken2));
            Console.WriteLine(degisken.EndsWith("Hoşgeldiniz."));
            Console.WriteLine(degisken.StartsWith("Merhaba!"));

            //IndexOf

            Console.WriteLine(degisken.IndexOf("C#"));
            Console.WriteLine(degisken.IndexOf("Berkcan"));
            Console.WriteLine(degisken.LastIndexOf("i"));

            //Insert
            Console.WriteLine(degisken.Insert(0,"Merhaba"));
            
            //PadLeft,PadRight
            Console.WriteLine(degisken + degisken2.PadLeft(30,'*'));
            Console.WriteLine(degisken.PadRight(50,'-') + degisken2);

            //Remove
            Console.WriteLine(degisken.Remove(10));
            Console.WriteLine(degisken.Remove(5,3));
            Console.WriteLine(degisken.Remove(0,1));

            //Replace
            Console.WriteLine(degisken.Replace("C#","C Sharp"));
            Console.WriteLine(degisken.Replace(" ","*"));

            //Split
            Console.WriteLine(degisken.Split(" ")[1]);

            //SubString
            Console.WriteLine(degisken.Substring(4));
        }
    }
}
