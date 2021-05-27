using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates // "Elçiler" yorum katmadan bilgi aktarırlar.
{
    public delegate void MyDelegate(); // void olduğu için void nesnelerle çalışır.
    public delegate void MyDelegate2(string text); // parametre alan void Delegate. 

    public delegate int MyDelegate3(int number1, int number2); // int döndüren Delegate.

    class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();
            //customerManager.SendMessage();
            //customerManager.ShowAlert();

            MyDelegate myDelegate = customerManager.SendMessage; // Delegenin SendMessage görevi tanıtılır.
            myDelegate += customerManager.ShowAlert; // Delegenin ikinci operasyonu tanıtılır "+=" kullanılarak.

            myDelegate -= customerManager.SendMessage; // Send message görevi iptal/çıkarılır "-=" kullanılarak.

            MyDelegate2 myDelegate2 = customerManager.SendMessage2;
            myDelegate2 += customerManager.ShowAlert2;

            Matematik matematik = new Matematik(); // metematik instance'ı nesnesi tanıtıldı.
            MyDelegate3 myDelegate3 = matematik.Topla; // topla görevi verildi.
            myDelegate3 += matematik.Carp; // çarp görevi eklendi.

            var sonuc = myDelegate3(2, 3); // var sonuc değişkeni tanımlandı.
            Console.WriteLine(sonuc); // sonuç yazdırdı.
                                      // Ancak yukarıda hem toplama hem çarpma görevi verilmişti.
                                      // Biz sadece sonuc değerini döndürdüğümü için,
                                      // delege burada en son verilen görev olan ÇARP görevini yerine getirdi
                                      // ve çarpma sonucunu döndürdü.

            myDelegate2("Hello"); // Delege2 çalıştırılır
                                  // string parametre aldığı için (message) ve (alert)'e "hello" yazdırıldı.

            myDelegate(); // Delege Çalıştırılır.

            Console.ReadLine();
        }
    }

    public class CustomerManager // örnek bir operasyon içerisindeki işlemler : void olduğu için void çalışır.
    {
        public void SendMessage() 
        {
            Console.WriteLine("Hello!");
        }

        
        public void ShowAlert()
        {
            Console.WriteLine("Be careful!");
        }

        public void SendMessage2(string message)
        {
            Console.WriteLine(message);
        }

        public void ShowAlert2(string alert)
        {
            Console.WriteLine(alert);
        }
    }

    public class Matematik // int parametre döndüren delegate için nesne.
    {
        public int Topla(int sayi1, int sayi2)
        {
            return sayi1 + sayi2;
        }

        public int Carp(int sayi1, int sayi2)
        {
            return sayi1 * sayi2;
        }
    }
}