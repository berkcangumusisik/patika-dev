using System;

namespace _26_inheritance
{
    public class Hayvanlar : Canlilar
    {
        public void Adaptasyon()
        {
            Console.WriteLine("Hayvanlar adaptasyon kurabilirler");

        }

        public ovveride void UyaranlaraTepki()
        {
            base.UyaranlaraTepki(); 
            Console.WriteLine("Hayvanlar güneşe tepki verir.");
        }
    }

    public class Surungenler : Hayvanlar
    {
        public Surungenler()
        {
            base.Adaptasyon();
            base.Bosaltim();
            base.Beslenme();
            base.Solunum();
        }
        public void SurunerekHareketEtme()
        {
            Console.WriteLine("Sürüngenler sürünerek hareket eder.");
        }
    }
    public class Kus : Hayvanlar
    {
        public Kus()
        {
            base.Adaptasyon();
            base.Bosaltim();
            base.Beslenme();
            base.Solunum();
        }
        public void Ucmak()
        {
            Console.WriteLine("Kuşlar uçar");
        }
    }


}
