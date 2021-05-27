using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events // Bir mağaza işletiyoruz, akıllı telefon ve hdd satıyoruz,
                 // hdd leri tüketmek istiyoruz ama telefonu stoklu tutmak istiyoruz.
                 // elimde 20 tane telefon kaldığında beni uyar diyen bir hatırlatıcı kuruyoruz.
                 // işte bu hatırlatıcı görevi "Event" ile yapabiliriz.
{
    class Program
    {
        static void Main(string[] args)
        {
            Product harddisk = new Product(50); // ürünler tanımlandı
            harddisk.ProductName = "Hard Disk";
            Product gsm = new Product(50);
            gsm.ProductName = "GSM";

            gsm.StockControlEvent += Gsm_StockControlEvent; // event aynı delege gibi "+=" ile event'e kayıt olunur.
                                                            // ve tetiklenmiş olur.

            for (int i = 0; i < 10; i++) // döngüyle satış yapılıyor.
            {
                harddisk.Sell(10);
                gsm.Sell(10);
                Console.ReadLine(); // her satıştan sonra bir tuşa basarak programı takip ediyoruz.
            }

            Console.ReadLine();


        }

        private static void Gsm_StockControlEvent() // event'in metodu.
        {
            Console.WriteLine("Gsm about to finish!!!");
        }
    }
}