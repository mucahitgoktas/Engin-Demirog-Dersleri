using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Attributes // Öznitelikler 
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer { Id = 1, LastName = "Demiroğ", Age = 32 }; // LastName'i boş geçti.
            CustomerDal customerDal = new CustomerDal();
            customerDal.Add(customer);
            Console.ReadLine();
        }
    }

    [ToTable("Customers")] // Class'a Attribute(Şart) eklendi.
    [ToTable("TblCustomers")] // Üzerine yazılan kodu etkiler. ( nu örnekte class Customer etkilendi.)
    class Customer
    {
        public int Id { get; set; } // zorunlu değil.
        [RequiredProperty] // Girmesi zorunlu olsun.
        public string FirstName { get; set; }
        [RequiredProperty] // Zorunlu
        public string LastName { get; set; }
        [RequiredProperty] // Zorunlu
        public int Age { get; set; }
    }

    class CustomerDal
    {
        [Obsolete("Dont use Add, instead use AddNew Method")] // Hazır Attirbute [Obsolote] eskiyen Attirbute'lerde programcılara uyarı vermek amacıyla yazılabilir. 
        public void Add(Customer customer)
        {

            Console.WriteLine("{0},{1},{2},{3} added!",
                customer.Id, customer.FirstName, customer.LastName, customer.Age);
        }

        public void AddNew(Customer customer)
        {

            Console.WriteLine("{0},{1},{2},{3} added!",
                customer.Id, customer.FirstName, customer.LastName, customer.Age);
        }
    }

    [AttributeUsage(AttributeTargets.Property, AllowMultiple = true)] // AtributeTargets .fonksiyonları ile Attribute'ün kimlere kullanılacağını belirleyebiliriz.
                                                                            // Class,All,Property(nesne),Ctor,Field.
                                                                            // Eğer fazla eklemek gerekirse | kullanarak devam edilebilir. Class | Field vs.
                                                                            // AllowMultiple ile birden fazla yerde kullanıp kullanamayacağına T/F şeklinde belirleyebiliriz.
    class RequiredPropertyAttribute : Attribute // Attribute Classı :Attribute sınıfından inherite edilmesi gerekir.
    {

    }
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = true)]
    class ToTableAttribute : Attribute // Database tablolarının attribute'u
    {
        private string _tableName;

        public ToTableAttribute(string tableName) // 
        {
            _tableName = tableName;
        }
    }


}