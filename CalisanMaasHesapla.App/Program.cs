using CalisanMaasHesapla.Lib;

namespace CalisanMaasHesapla.App

{
    public class Program
    {

        static void Main()

            // string arg disardan verilen parametleri dogru bir sekilde almamızı sağlar.

            // İLK HAFB NASIL BUYUTEBILIRIZ!!!!??

        {
            BasePersonel _emre = new KadroluPersonel(15514866,"Emre","yaman",8,20000);

            BasePersonel _Nisa= new SozlesmeliPersonel(12345678, "Nisa", "yaman", 28, 400);

            BasePersonel _Talha = new StajyerPersonel(15528666, "Talha", "yaman", 100, 75);
        
            Console.WriteLine(_emre.AdSoyadGetir()+"\n" + "Maas : "+ _emre.AylikHesapla().ToString());
            Console.WriteLine("---------------------------");
            Console.WriteLine(_Nisa.AdSoyadGetir() + "\n" + "Maas : " + _Nisa.AylikHesapla().ToString());
            Console.WriteLine("---------------------------");
            Console.WriteLine(_Talha.AdSoyadGetir() + "\n" + "Maas : " + _Talha.AylikHesapla().ToString());

        }
    }
}
