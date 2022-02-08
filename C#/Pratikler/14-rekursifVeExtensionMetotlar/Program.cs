using System;

namespace _14_rekursifVeExtensionMetotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            // Rekürsif(Yinelemeli) Fonksiyonlar :Kendi kendini çağırabilirler.
            int result = 1;
            for (int i = 1; i < 5; i++)
            {
                result *= 3;
            }
            Console.WriteLine(result);

            Islemler islem1 = new();
            Console.WriteLine(islem1.Expo(3, 4));
            /*
            Extension Metotların kelime anlamı genişletilebilir metotlardır. C# 3.0 ile hayatımıza giren, aynı kodu defalarca yazmak yerine, bir kere yazıp her yerden erişebileceğimiz kolay kullanımı olan metotlardır.
            */
            string ifade = "Berkcan Gümüşışık";
            bool sonuc = ifade.CheckSpaces();
            Console.WriteLine(sonuc);
            if (sonuc)
            {
                Console.WriteLine(ifade.RemoveWhiteBackSpaces());
            }

            Console.WriteLine(ifade.MakeUpperCase());
            Console.WriteLine(ifade.MakeLowerCase());

            int[] dizi = { 9, 3, 6, 2, 5, 0 };
            dizi.SortArray();
            dizi.EkranaYazdir();

            int sayi = 5;
            Console.WriteLine(sayi.IsEventNumber());
            Console.WriteLine(ifade.GetFirstCharacter());
        }
    }

    public class Islemler
    {
        public int Expo(int sayi, int us)
        {
            if (us < 2)
            {
                return sayi;
            }
            return Expo(sayi, us - 1) * sayi;
        }
    }

    public static class Extension
    {
        public static bool CheckSpaces(this string param)
        {
            return param.Contains(" ");
        }

        public static string RemoveWhiteBackSpaces(this string param)
        {
            string[] dizi = param.Split(" ");
            return string.Join("-", dizi);
        }

        public static string MakeUpperCase(this string param)
        {
            return param.ToUpper();
        }

        public static string MakeLowerCase(this string param)
        {
            return param.ToLower();
        }

        public static int[] SortArray(this int[] param)
        {
            Array.Sort(param);
            return param;
        }

        public static void EkranaYazdir(this int[] param)
        {
            foreach (var item in param)
            {
                Console.WriteLine(item);
            }
        }

        public static bool IsEventNumber(this int value)
        {
            if (value % 2 == 0)
                return true;
            else
                return false;
        }

        public static string GetFirstCharacter(this string param)
        {
            return param.Substring(0,1);
        }
    }
}
