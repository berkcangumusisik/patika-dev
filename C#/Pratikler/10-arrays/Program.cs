using System;

namespace _10_arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int[] sayiDizisi = {23,12,86,72,3,11,17,4};
            Console.WriteLine("********Sırasız Dizi ****");
            foreach (var sayi in sayiDizisi)
            {
                Console.WriteLine(sayi);
            }
            Console.WriteLine("********Sıralı Dizi ****");
            Array.Sort(sayiDizisi);
            foreach (var sayi in sayiDizisi)
            {
                Console.WriteLine(sayi);
            }
            Console.WriteLine("********Array Clear****");
            Array.Clear(sayiDizisi,2,2);
            foreach (var sayi in sayiDizisi)
            {
                Console.WriteLine(sayi);
            }

            Console.WriteLine("********Array Reverse****");
            Array.Reverse(sayiDizisi);
            foreach (var sayi in sayiDizisi)
            {
                Console.WriteLine(sayi);
            }

            Console.WriteLine("********Array Indexof****");
            
            Console.WriteLine(Array.IndexOf(sayiDizisi,23));

            Console.WriteLine("********Array Resize****");
            Array.Resize<int>(ref sayiDizisi,9);
            sayiDizisi[8] =99;
            foreach (var sayi in sayiDizisi)
            {
                Console.WriteLine(sayi);
            }
        }
    }
}
/*
* Diziler System.Array sınıfından türerler. 
* Array.Sort()
Diziler üzerinden sıralama işlemi yapar. 
* Array.Clear
Dizinin belirtilen elemanlarını varsayılan değerine getirir. Yani örneğin numeric bir dizi ise 0 olarak setler.
* Array.Reverse
Dizinin ortasını belirleyerek elemanlarını aynalar gibi düşünebilirsiniz. Yani dizinin ilk elemanı ile son elemanını yer değiştirir.
* Array.IndexOf
Verilen dizinin verilen elemanının indexini getirir. Eğer dizi içerisinde elemanı bulamazsa -1 döner.
* Array.Resize
Dizileri yeniden boyutlandırmak için kullanılır.
*/