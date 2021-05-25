using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Runtime.ExceptionServices;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            //Diziler(); // Yeni eleman ekleme sorunu var.
            //ArrayList(); // Tip güvenli değil, her tip veriyi kabul ediyor.
            //ListOf();
            List<Customer> customer = new List<Customer>(); // Yeni bir liste oluştururken böyle yazılabilir.

            customer.Add(new Customer { ID = 101, Name = "Ahmet", BirthDate = (1995, 12, 17) });
            customer.Add(new Customer { ID = 102, Name = "Fatma", BirthDate = (1991, 5, 22) });
            customer.Add(new Customer { ID = 103, Name = "Osman", BirthDate = (1995, 10, 15) });  // Ekleme yaparken parantez içinde new'lemek gerekir.
            customer.Add(new Customer { ID = 104, Name = "Hakan", BirthDate = (1993, 01, 05) });
            foreach (var cust in customer)
            {
                Console.Write(cust.ID);
                Console.Write(cust.Name);
                Console.Write(cust.BirthDate);
                Console.WriteLine();

            }

            var customerCount = customer.Count;
            Console.WriteLine($"Customer listesindeki elemanların Toplamı : {customerCount}\n");
            customer.Add(new Customer { ID = 105, Name = "Salih", BirthDate = (1985, 07, 24) });

            List<Person> person = new List<Person>();
            person.Add(new Person { Name = "Ali", Age = 18 });
            person.Add(new Person { Name = "Aslı", Age = 24 });
            

            person.AddRange(new Person[2] // Addrange listOf'a bir "dizi" için kullanılır. Hazır gelen diziler varsa eklenir.
            {
                new Person{Name = "Fatih",Age = 29},
                new Person{Name = "Hande",Age = 19}
            });
            
            
            // person.Clear(); Listedeki tüm elemanları siler.

            // Contains Fonksiyonu
            var kisi = new Person {Name = "Halil", Age = 34};// liste elemanı tanımlanır.
            person.Add(kisi);

            Console.WriteLine(person.Contains(kisi)); // listedeki tanımlanmış elemanları bulmak için kullanılır, bunun için öncelikle liste elemanı tanımlanmalıdır. 
            // Contains için bir fark, ListOf kullanılarak tek bir tipte örn string liste tanımlanmışsa, o zaman arama yapılabilir ancak classlar ile yapılan listelerde arama yaparken tanımlama gerekir.
            // contains Bool döndürür.
            


            foreach (var persons in person)
            {
                Console.Write(persons.Name);
                Console.WriteLine("  {0}", persons.Age);
            }

            // IndexOf Fonksiyonu
            var index = person.IndexOf(kisi);
            Console.WriteLine($"Halil kişisi listede {index} sıradadır.");
            var personCount = person.Count;
            Console.WriteLine($"Person listesindeki elemanların Toplamı : {personCount}");

            // DİCTİONARY
            Dictionary<string, string> dictionary = new Dictionary<string, string>(); // Öncelikle Sözlük'lerin ilk kaynak değerinin tipini(string)
                                                                                      // ve karşılık değerinin tipini(string) tanımlayıp new'lememiz gerekir.
            dictionary.Add("Book", "Kitap");
            dictionary.Add("Table", "Tablo");
            dictionary.Add("Compuer", "Bilgisayar");

            Console.WriteLine(dictionary["Book"]);  // cw ile yazdırırken köşeli parantezden kaynak değeri çağırıp, ekranda karşılık değeri görmeyi bekleriz.

            try
            {
                Console.WriteLine(dictionary["Pen"]); // Listede olmayan bir karşılık değer arandığında programın hata vermesinin önüne geçmek için kendi Exception'ımızı yazdık.
            }
            catch (Exception exception)
            {
                Console.WriteLine("Aradığınız Kelime Bulunamadı."); // hata mesajı
                
            }

            Console.WriteLine("Program çalışmaya devam ediyor..."); // hatayı verdikten sonra program durmadan devam eder.
            


            Console.ReadLine();
        }

        private static void ListOf()
        {
            List<string> Cities = new List<string>(); // List "of" string şeklinde okuruz, sadece string kabul eder.
            Cities.Add("Ankara"); // string şeklinde temel tipler değil de daha çok class'lar ile çalışılır. ve sonuçlar da Class.Obje şeklinde döndürülür.
            foreach (var city in Cities)
            {
                Console.WriteLine(city);
            }
        }

        private static void Diziler()
        {
            string[] cities = new string[2] { "Ankara", "Istanbul" }; // diziler sınırlı eleman sayısına sahiptir. ekleme yapılamaz.
            Console.WriteLine(cities);
        }

        private static void ArrayList()
        {
            ArrayList Cities = new ArrayList(); // ArrayList içerisine her tipten(örn. string, int vs) obje alabilir.
            Cities.Add("Ankara");
            Cities.Add('M');
            foreach (var city in Cities)
            {
                Console.WriteLine(city);
            }

            Cities.Add(3); // Bu yüzden ArrayList tip güvenli değildir ve çok kullanılmasına gerek olmaz.
            Console.WriteLine(Cities[2]);
        }
    }

    class Customer
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public (int, int, int) BirthDate { get; set; }
    }

    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }
}
