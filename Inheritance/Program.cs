using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer();
            customer.FirstName = "asd";
            customer.City = "Balikesir";

            Person[] persons = new Person[2]
            {
                new Customer{FirstName = "Salih"},
                new Person{FirstName = "Sezen"}
            };
            foreach (var person in persons)
            {
                Console.WriteLine(person.FirstName);
                
            }
            
            
            Console.ReadLine();
        }

        class Person // inheritance için belirlediğimiz "BABA" class.
        {
            public int Id { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
        }

        class Customer : Person, Iperson2 // Customer'ın "Babası" person classı, sonradan eklenen ise interface'dir. fazladan interface'de eklenebilir.
        {
            public string City { get; set; }
            public int TcKimlikNo { get; set; }
        }

        class Person2 // Bu Class'ı Customer'a interface gibi virgülden sonra ikinci Inheritance olarak ekleyemeyiz çünkü 1 kişinin 1 BABAsı olur.
        {
            public string Mesleği { get; set; }
        }

        // Eğer bir interface eklersek, oğul class'a virgülden sonra interface'i ekleyebiliriz. Önemli olan şudur ki; inheritance'lar :'dan hemen sonra yazılır daha sonra interface'ler yazılır.
        interface Iperson2
        {
            int TcKimlikNo { get; set; }
        }
    }
}
