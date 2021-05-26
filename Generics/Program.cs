using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics // Generic yapılar Interface'ler Classlar vb. yapılar arasında bağ oluşturur. <T> ile oluşturulur ancak T yerine herşey yazılabilir.
{
    class Program
    {
        static void Main(string[] args)
        {
            Utilities utilities = new Utilities(); 
            List<string> result = utilities.BuildList<string>("Ankara", "İzmir", "Adana"); // yeni bir listOf string oluşturulur, içerisine 3 eleman verilir.
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }

            List<Customer> result2 = utilities.BuildList<Customer>(new Customer { FirstName = "Engin" }, new Customer { FirstName = "Derin" });

            foreach (var customer in result2)
            {
                Console.WriteLine(customer.FirstName);
            }
            Console.ReadLine();
        }
    }

    class Utilities
    {
        public List<T> BuildList<T>(params T[] items)  // Constructor yazılır. Generic <T> listOf'un stringini ifade eder,
                                                       // ancak bu constructor'ı kullanan her kullanıcı farklı bir değer tanımlayabileceği için T hepsini ifade eder.
                                                       // Örneğin result2 için Customer'ı ifade eder.
                                                       // params, eleman sınırını kaldırır. "kaç tane gönderirsen gönder" anlamındadır.
        {
            return new List<T>(items); // itemleri döndürür.
        }
    }

    class Product : IEntity
    {

    }
    interface IProductDal : IRepository<Product>
    {

    }

    class Customer : IEntity
    {
        public string FirstName { get; set; }
    }

    interface ICustomerDal : IRepository<Customer> // Sen Repository'sin çalışma tipin Customer'dır.
    {
        void Custom();
    }

    interface IStudentDal : IRepository<Student> // Sen Repository'sin ancak çalışma tipin Student'tir.
    {

    }

    class Student : IEntity
    {

    }

    interface IEntity
    {

    }

    interface IRepository<T> where T : class, IEntity, new() // Generic yapıyı filtrelemek için, where T kullanılır, Class Referans yapılı demektir,
                                                             // Ientity sadece onu kullanabiliriz anlamına gelir,
                                                             // new() ise sadece new'lenebilen nesnelerin < > kullanılabileceğini ifade eder.(alt classlarda)
                                                             // Generic bir yapıyı oluşturmak için I,CLASS,ABSTRACT'a <Tsadsa> eklemek gerekir.
    {
        List<T> GetAll(); // herhangi bir operasyon metodu
        T Get(int id); // yine herhangi bir operasyon metodu
        void Add(T entity); // ekleme motodu
        void Delete(T entity); // silme
        void Update(T entity); // Update
    }

    class ProductDal : IProductDal
    {
        public void Add(Product entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Product entity)
        {
            throw new NotImplementedException();
        }

        public Product Get(int id)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Update(Product entity)
        {
            throw new NotImplementedException();
        }
    }

    class CustomerDal : ICustomerDal
    {
        public void Add(Customer entity)
        {
            throw new NotImplementedException();
        }

        public void Custom()
        {
            throw new NotImplementedException();
        }

        public void Delete(Customer entity)
        {
            throw new NotImplementedException();
        }

        public Customer Get(int id)
        {
            throw new NotImplementedException();
        }

        public List<Customer> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Update(Customer entity)
        {
            throw new NotImplementedException();
        }
    }



}

