using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Channels;

namespace Interfaces
{
    interface ICustomerDal
    {
        void Add();
        void Delete();
        void Update();
    }

    class SqlServerCustomerDal : ICustomerDal
    {
        public void Add()
        {
            Console.WriteLine("Sql Added");
        }

        public void Delete()
        {
            Console.WriteLine("Sql Deleted");
        }


        public void Update()
        {
            Console.WriteLine("Sql Updated");
        }
    }

    class OracleCustomerDal : ICustomerDal
    {
        public void Add()
        {
            Console.WriteLine("Oracle Added");
        }

        public void Delete()
        {
            Console.WriteLine("Oracle Deleted");
        }

        public void Update()
        {
            Console.WriteLine("Oracle Updated");
        }

        public class MysqlServerCustomerDal : ICustomerDal
        {
            public void Add()
            {
                Console.WriteLine("Mysql Added");
            }

            public void Delete()
            {
                Console.WriteLine("Mysql Deleted");
            }


            public void Update()
            {
                Console.WriteLine("Mysql Updated");
            }
        }

        public class CustomerManager
        {
            public void Add(ICustomerDal customerDal)  // interface'i methodun içine çekiyoruz. programcs'de kullanımı: önce class'ı newliyoruz. ardından customerManager.Add(new "sql veya oracle seç");
            {
                customerDal.Add();
            }
        }
    }
}
