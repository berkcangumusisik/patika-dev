using System;
using System.Collections.Generic;

namespace ToDoApp
{
    class Board
    {
        Dictionary<int, string> kisiListesi = new Dictionary<int, string>();
        List<Kart> TODO = new List<Kart>();
        List<Kart> INPROGRESS = new List<Kart>();
        List<Kart> DONE = new List<Kart>();
        public Board()
        {
            kisiListesi.Add(0, "Berkcan Gümüşışık");
            kisiListesi.Add(1, "Şevval Baydemir");
            kisiListesi.Add(2, "Nurana Jumageldiyeva");
            kisiListesi.Add(3, "Mete Serkan Özdemir");
            TODO.Add(new Kart("Kodların yazılması", "Kodların Backend ve Frontend kısmının tamamlanması", "Berkcan Gümüşışık", Kart.Buyuluk.XL));
            INPROGRESS.Add(new Kart("Kodların yazılması", "Kodların Backend ve Frontend kısmına destek olmak", "Şevval Baydemir", Kart.Buyuluk.L));
            DONE.Add(new Kart("Tasarımların hazırlanması", "Sitede kullanılacak logonun hazırlanması", "Mete Serkan Özdemir", Kart.Buyuluk.M));
        }
        public void KartEkle()
        {
            string baslik;
            string icerik;
            int buyukluk;
            int kisi;

            Console.WriteLine("Başlık giriniz                                   : ");
            baslik = Console.ReadLine();
            Console.WriteLine("İçerik giriniz                                   : ");
            icerik = Console.ReadLine();
            Console.WriteLine("Büyüklük seciniz -> XS(1),S(2),M(3),L(4),XL(5)   :");
            buyukluk = int.Parse(Console.ReadLine());
            Console.WriteLine("Kişi ID'sini giriniz                             : ");
            kisi = int.Parse(Console.ReadLine());

            if (kisiListesi.ContainsKey(kisi) && buyukluk > 0 && buyukluk <= 5)
                TODO.Add(new Kart(baslik, icerik, kisiListesi[kisi], (Kart.Buyuluk)buyukluk));
            else
                Console.WriteLine("Hatali giris yaptiniz!");


        }
        public void KartGuncelle()
        {
            Console.WriteLine("Kart Guncelle calisiyor.");
        }

        public void KartSil()
        {
            string baslik;
            string icerik;

            Console.WriteLine("Silmek istediginiz kartı seçmeniz gerekiyor.");
            Console.WriteLine("Lütfen kartın başlığını yazınız :    ");
            baslik = Console.ReadLine();
            Console.WriteLine("Lütfen kartın icerigi yazınız :    ");
            icerik = Console.ReadLine();

            bool bulundu = false;
            
            foreach (var kart in TODO.ToArray())
            {
                if (kart.Baslik == baslik && kart.Icerik == icerik)
                {
                    TODO.Remove(kart);
                    Console.WriteLine("Kart silindi.");
                    bulundu = true;
                }
            }

            foreach (var kart in INPROGRESS.ToArray()) 
            {
                if (kart.Baslik == baslik && kart.Icerik == icerik)
                {
                    INPROGRESS.Remove(kart);
                    Console.WriteLine("Kart silindi.");
                    bulundu = true;
                }
            }

            foreach (var kart in DONE.ToArray())
            {
                if (kart.Baslik == baslik && kart.Icerik == icerik)
                {
                    DONE.Remove(kart);
                    Console.WriteLine("Kart silindi.");
                    bulundu = true;
                }
            }

            if (!bulundu)
            {
                int secim;
                Console.WriteLine("Aradığınız kriterlere uygun kart bulunamadi.");
                Console.WriteLine("\n* Silmeyi sonlandırmak icin (1)");
                Console.WriteLine("\n* Yeniden denemek icin (2)");
                secim = int.Parse(Console.ReadLine());
                if (secim == 2)
                    KartSil();
                else
                    Console.WriteLine("Kart silme işlemi sonlandı.");
            }
        }



        private void KartEkle(Kart kart,ref List<Kart> addList,ref List<Kart> deleteList)
        {
            addList.Add(kart);
            deleteList.Remove(kart);
            Console.WriteLine("Taşıma işlemi basarili!");
        }

        private void KartAra(string baslik,string icerik,ref List<Kart> kartListesi, ref bool bulundu, string listName)
        {
            foreach (var kart in kartListesi.ToArray())
            {
                if (kart.Baslik == baslik && kart.Icerik == icerik)
                {
                    bulundu = true;

                    Console.WriteLine("Bulunan Kart Bilgileri:");
                    Console.WriteLine("*******************************************");
                    Console.WriteLine("Baslik       :   {0}", kart.Baslik);
                    Console.WriteLine("Icerik       :   {0}", kart.Icerik);
                    Console.WriteLine("Atanan Kisi  :   {0}", kart.AtananKisi);
                    Console.WriteLine("Buyukluk     :   {0}", kart.Boyut);
                    Console.WriteLine("Line         :   {0}", listName);
                    Console.WriteLine();
                    Console.WriteLine("Lütfen Taşımak istediginiz Line'i secin:");
                    Console.WriteLine("(1) TODO");
                    Console.WriteLine("(2) IN PROGRESS");
                    Console.WriteLine("(3) DONE");
                    int secim = int.Parse(Console.ReadLine());
                    switch (secim)
                    {
                        case 1:
                            KartEkle(kart,ref TODO,ref kartListesi);
                            break;
                        case 2:
                            KartEkle(kart, ref INPROGRESS, ref kartListesi);
                            break;
                        case 3:
                            KartEkle(kart, ref DONE, ref kartListesi);
                            break;
                        default:
                            Console.WriteLine("Hatalı bir Seçim yaptınız!");
                            break;
                    }


                }
            }
        }

        public void KartTasi()
        {
            string baslik;
            string icerik;
            bool bulundu = false;

            Console.WriteLine("Oncelikle Taşımak istediginiz karti secmeniz gerekiyor.");
            Console.WriteLine("Lütfen kartın başlığını yazınız :    ");
            baslik = Console.ReadLine();
            Console.WriteLine("Lütfen kartın icerigi yazınız :    ");
            icerik = Console.ReadLine();


            KartAra(baslik, icerik,ref TODO,ref bulundu,"TODO");                
            KartAra(baslik, icerik,ref INPROGRESS,ref bulundu,"INPROGRESS");    
            KartAra(baslik, icerik,ref DONE, ref bulundu,"DONE");               


            if (!bulundu)
            {
                int secim;
                Console.WriteLine("Aradığınız kriterlere uygun kart bulunamadı.");
                Console.WriteLine("* Taşımayi sonlandırmak icin (1)");
                Console.WriteLine("* Yeniden denemek icin (2)");
                secim = int.Parse(Console.ReadLine());
                if (secim == 2)
                    KartTasi();
                else
                    Console.WriteLine("Kart silme işlemi sonlandı.");
            }
        }

        public void BoardListele()
        {
            Console.WriteLine();
            Console.WriteLine("TODO Line");
            Console.WriteLine("*****************************");

            foreach (var kart in TODO)
            {
                Console.WriteLine("Baslik       : {0}", kart.Baslik);
                Console.WriteLine("Icerik       : {0}", kart.Icerik);
                Console.WriteLine("Atanan Kisi  : {0}", kart.AtananKisi);
                Console.WriteLine("Buyukluk     : {0}", kart.Boyut);
                Console.WriteLine("-");
            }

            Console.WriteLine();
            Console.WriteLine("IN PROGRESS Line");
            Console.WriteLine("*****************************");

            foreach (var kart in INPROGRESS)
            {
                Console.WriteLine("Baslik       : {0}", kart.Baslik);
                Console.WriteLine("Icerik       : {0}", kart.Icerik);
                Console.WriteLine("Atanan Kisi  : {0}", kart.AtananKisi);
                Console.WriteLine("Buyukluk     : {0}", kart.Boyut);
                Console.WriteLine("-");
            }

            Console.WriteLine();
            Console.WriteLine("DONE Line");
            Console.WriteLine("*****************************");

            foreach (var kart in DONE)
            {
                Console.WriteLine("Baslik       : {0}", kart.Baslik);
                Console.WriteLine("Icerik       : {0}", kart.Icerik);
                Console.WriteLine("Atanan Kisi  : {0}", kart.AtananKisi);
                Console.WriteLine("Buyukluk     : {0}", kart.Boyut);
                Console.WriteLine("-");
            }

        }

    }
}