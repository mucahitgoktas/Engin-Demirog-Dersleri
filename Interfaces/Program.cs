using System;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {

            OracleCustomerDal.CustomerManager customerManager = new OracleCustomerDal.CustomerManager();
            // demo(customerManager);
            ICustomerDal[] customerDals = new ICustomerDal[3]
            {
                new SqlServerCustomerDal(),
                new OracleCustomerDal(),
                new OracleCustomerDal.MysqlServerCustomerDal(),

            };

            foreach (var customerDal in customerDals)
            {
                customerDal.Add();
            }

            Console.ReadLine();


        }

        private static void demo(OracleCustomerDal.CustomerManager customerManager)
        {
            customerManager.Add(new OracleCustomerDal()); // interface'den çekilen class özellikleri.
            customerManager.Add(new SqlServerCustomerDal()); // interface'den çekilen class özellikleri.
        }

        interface IPerson   // I ile başlar
        {
            int ID { get; set; }  /// prop ile açılır ancak "public" almaz.
            String FirstName { get; set; }
            String LastName { get; set; }

        }

        class Customer : IPerson  // Ampulden implemente edilir ve Interface içindeki tüm tanımları (public dahil) içeri çeker."İNTERFACE'LER CLASSLARIN ÜST ÇATILARIDIR VE METOTLARA VERİLEBİLİRLER.
        {
            public int ID { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }

            public string Adress { get; set; } // classın amacına göre class'a özel yeni tanımlamalar eklenebilir.
        }

        class Student : IPerson
        {
            public int ID { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }

            public int SinifNo { get; set; }
        }

        class PersonManager
        {

            public void Add(IPerson person)
            {
                Console.WriteLine(person.FirstName);
            }

        }

    }
}
