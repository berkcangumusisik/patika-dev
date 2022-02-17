using System;

namespace ToDoApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Board board = new Board();
            int input = MenuYaz();

            while (true)
            {
                switch (input)
                {
                    case 1: 
                        board.KartEkle();
                        input = MenuYaz();
                        break;
                    case 2: 
                        board.KartGuncelle();
                        input = MenuYaz();
                        break;
                    case 3: 
                        board.KartSil();
                        input = MenuYaz();
                        break;
                    case 4: 
                        board.KartTasi();
                        input = MenuYaz();
                        break;
                    case 5: 
                        board.BoardListele();
                        input = MenuYaz();
                        break;
                    case 6:
                        Environment.Exit(0);
                        break;

                    default:
                        Console.WriteLine("Böyle bir seçim bulunamadı çıkış yapılıyor.");
                        Environment.Exit(0);
                        break;
                }
            }

            
        }

        public static int MenuYaz()
        {
            Console.WriteLine();
            Console.WriteLine("Lütfen yapmak istediğiniz işlemi seçin");
            Console.WriteLine("************************************");
            Console.WriteLine("(1) Kart Eklemek");
            Console.WriteLine("(2) Kart Guncelle");
            Console.WriteLine("(3) Kart Sil");
            Console.WriteLine("(4) Kart Taşı");
            Console.WriteLine("(5) Board Listelemek");
            Console.WriteLine("(6) Çıkış");
            return int.Parse(Console.ReadLine());
        }
    }
}
