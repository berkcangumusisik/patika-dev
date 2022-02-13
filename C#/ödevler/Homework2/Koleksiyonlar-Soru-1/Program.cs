using System;
using System.Collections;

namespace Koleksiyonlar_Soru_1
{
    class Program
    {
        static void Main(string[] args)
        {

            ArrayList asalSayilar = new ArrayList();
            ArrayList asalOlmayanlar = new ArrayList();
            Console.WriteLine("Lütfen 20 adet sayı giriniz :");
            for (int i = 1; i < 21; i++)
            {
                Console.WriteLine("{0}.sayıyı giriniz :", i + 1);
                int n = int.Parse(Console.ReadLine());
                if (negatifMi(n))
                {
                    int sayac = 0;
                    for (int k = 2; k < n; k++)
                    {
                        if (n % k == 0)
                        {
                            sayac++;
                        }

                    }

                    if (sayac == 0)
                    {
                        if (sayac == 1)
                        {
                            asalOlmayanlar.Add(n);
                        }
                        else
                            asalSayilar.Add(n);
                    }

                    else
                    {
                        asalOlmayanlar.Add(n);
                    }
                }

                else
                {
                    System.Console.WriteLine("Lütfen Pozitif ve Numeric Bir sayı Giriniz");
                }


            }
            asalSayilar.Sort();
            asalSayilar.Reverse();
            asalOlmayanlar.Sort();
            asalOlmayanlar.Reverse();

            System.Console.WriteLine("----------Asal Sayılar----------");

            foreach (int item in asalSayilar)
            {
                System.Console.WriteLine(item);
            }
            System.Console.WriteLine("----------Asal Olmayan Sayılar----------");
            
            foreach (var item in asalOlmayanlar)
            {
                System.Console.WriteLine(item);
            }


            int toplam1=0;
            int toplam2=0;
            foreach (int item in asalSayilar)
            {
                toplam1=toplam1+item;
                    
            }
            Console.WriteLine("Asal Sayıların Ortalaması=  " + toplam1/asalSayilar.Count+ "  Dizideki Eleman Sayısı= "+asalSayilar.Count );
            foreach (int item in asalOlmayanlar)
            {
                toplam2=toplam2+item;
                    
            }
            Console.WriteLine("Asal Olmayan Sayıların Ortalaması=  " + toplam2/asalOlmayanlar.Count+ "  Dizideki Eleman Sayısı= "+asalOlmayanlar.Count );
        }

        private static bool negatifMi(int s)
        {
            bool sonuc = true;
            if (s < 0)
            {
                sonuc = false;
            }

            return sonuc;

        }

    }

}
/*
Klavyeden girilen 20 adet pozitif sayının asal ve asal olmayan olarak 2 ayrı listeye atın. (ArrayList sınıfını kullanara yazınız.)

Negatif ve numeric olmayan girişleri engelleyin.
Her bir dizinin elemanlarını büyükten küçüğe olacak şekilde ekrana yazdırın.
Her iki dizinin eleman sayısını ve ortalamasını ekrana yazdırın.
*/