using System;

namespace Classlar
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager(); // Class'ı referans göstererek kullanmak için. Classlar oluşturulurken baş harfi büyük, kullanılırken baş harfi küçük verilir.
            Customer customer = new Customer();
            customerManager.Add();
            customerManager.Update();
            customer.City = "Ankara";
            customer.Id = 12;
            customer.FirstName = "Mücahit";
            customer.LastName = "Göktaş";

            Customer customer2 = new Customer // parantez yerine kıvırcık koyarsak bu yolu kullanabiliriz.
            {
                FirstName = "Mücahit",
                City = "Ankara",
                Id = 12,
                LastName = "Göktaş"   // ctrl + space basıldığında otomatik değişkenleri alabiliriz.
            };

            Console.WriteLine(customer2.FirstName);
            Console.ReadLine();
        }

        class CustomerManager
        {
            public void Add()
            {
                Console.WriteLine("Customer Added!"); // Müşteri ekleme metodu örneği
            }

            public void Update()
            {
                Console.WriteLine("Customer Updated!"); // Müşteri bilgisi güncelleme örneği
            }
        }

        public class Customer
        {
            public int Id { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string City { get; set; }



        }
    }
}