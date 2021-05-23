using System;

namespace Constructors
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Bir Sayı Giriniz : ");
            int sayi = Convert.ToInt32(Console.ReadLine());
            CustomerManager customerManager = new CustomerManager(sayi);
            customerManager.Add();

            Product product = new Product { Id = 1457854458, Name = "Hasan" };

            Calisan calisan = new Calisan(new Logger()); // ctor ile parametre verilir.
            calisan.Calis(); // metot burda çalıştırılır.

            PersonManager personManager = new PersonManager(entity: "Entitiyim");
            personManager.Add();
            
            DoSomeThing.VersionNumber(); // static nesneden gelen bilgi.


            Console.ReadLine();
        }
    }

    class CustomerManager
    {

        public CustomerManager(int sayi) // constructor new'lenen classın parametresini döndürür. 
        {
            Console.WriteLine($"istediğiniz sayi : {sayi * 2} ");
        }
        public void List()
        {
            Console.WriteLine("Listed!");
        }

        public void Add()
        {
            Console.WriteLine("Added!");
        }
    }

    class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    interface ICalisan
    {
        void Calis();
    }

    interface ILogger
    {
        void log();
    }

    class Logger : ILogger
    {
        public void log()
        {
            DateTime time = DateTime.Now;
            Console.WriteLine($"log işlemi {time} saatinde başarıyla gerçekleştirdildi!");
        }
    }
    class Calisan : ICalisan
    {
        private ILogger _logger; // private bir değişken oluşur
        public Calisan(ILogger logger) // private değişkeni eşitlemek için bir ctor açılır.
        {
            _logger = logger; // private değişken eşitlenir.
        }
        public void Calis() // esas kullanım metotu bu olur.
        {
            Console.WriteLine("Calisma Başladı!");
            _logger.log(); // private değişken fonksiyonunu kullanır. 

        }
    }

    class BaseClass : ILogger
    {
        private string _Entity;

        public BaseClass(string entity)
        {
            _Entity = entity;
        }
        public void Message()
        {
            Console.WriteLine($"{_Entity} Mesaj Gösterilmiştir!");

        }

        public void log()
        {
            DateTime time = DateTime.Now;
            Console.WriteLine($"log işlemi {time} saatinde başarıyla gerçekleştirdildi!");
        }
    }

    class PersonManager : BaseClass
    {

        public PersonManager(string entity) : base(entity)
        {
        }

        public void Add()
        {
            Console.WriteLine("Veri Tabanına Eklendi.");
            Message();
            log();
        }
    }

    static class DoSomeThing // static nesneler new'lenmeden kullanılır. ve sabittir. değişken değildir.
    {
        public static void VersionNumber() // örneğin her sayfada aynı kalması gereken şeyler static kullanılır.
        {
            double VersionNumber = 1.3550;
            Console.WriteLine("Program Sürümü : {0}v",VersionNumber);

        }
    }
}
