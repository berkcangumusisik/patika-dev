using System;

namespace _03_Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            // Atama ve İşlemli Atama

            Console.WriteLine("**********Atama ve İşlemli Atama*******************");
            int x = 3;
            int y = 3;
            y = y + 2;

            Console.WriteLine(y);
            Console.WriteLine("--------------");


            y += 2;
            Console.WriteLine(y);
            Console.WriteLine("--------------");



            y /= 1;
            Console.WriteLine(y);
            Console.WriteLine("--------------");

            x *= 2;

            Console.WriteLine(x);
            Console.WriteLine("--------------");

            //Mantıksal Operatörler
            // || veya ; && ve; ! değil

            Console.WriteLine("**********Mantıksal Operatörler*******************");
            bool isSuccess = true;
            bool isComplete = false;

            if(isSuccess&& isComplete)
            {
                Console.WriteLine("Perfect");
            }

            if (isSuccess || isComplete)
            {
                Console.WriteLine("Great");
            }


            if (isSuccess || !isComplete)
            {
                Console.WriteLine("Fine");
            }


            //İlişkisel operatörler
            // > , < , <= , >=, == ,!=

            Console.WriteLine("**********İlişkisel Operatörler*******************");
            int a = 3;
            int b = 4;
            bool sonuc = a < b;
            Console.WriteLine("-------------");
            Console.WriteLine(sonuc);

            sonuc = a > b;
            Console.WriteLine("-------------");
            Console.WriteLine(sonuc);

            sonuc = a >= b;
            Console.WriteLine("-------------");
            Console.WriteLine(sonuc);


            sonuc = a <= b;
            Console.WriteLine("-------------");
            Console.WriteLine(sonuc);


            sonuc = a == b;
            Console.WriteLine("-------------");
            Console.WriteLine(sonuc);


            sonuc = a != b;
            Console.WriteLine("-------------");
            Console.WriteLine(sonuc);



            Console.WriteLine("**********Aritmetiksel Operatörler*******************");
            // / , * , +, -, %


            int sayi1 = 10;
            int sayi2 = 5;

            int sonuc1 = sayi1 + sayi2;
            int sonuc2 = sayi1 - sayi2;
            int sonuc3 = sayi1 * sayi2;
            int sonuc4 = sayi1 / sayi2;
            int sonuc5 = sayi1 % sayi2;


            Console.WriteLine("-------------");
            Console.WriteLine(sonuc1);
            Console.WriteLine("-------------");
            Console.WriteLine(sonuc2);
            Console.WriteLine("-------------");
            Console.WriteLine(sonuc3);
            Console.WriteLine("-------------");
            Console.WriteLine(sonuc4);
            Console.WriteLine("-------------");
            Console.WriteLine(sonuc5);
            Console.ReadLine();

        }
    }
}
