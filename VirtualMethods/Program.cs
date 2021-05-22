using System;
using System.Threading.Channels;

namespace VirtualMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Sqlserver sqlserver = new Sqlserver();
            sqlserver.Add();
            
            
            Console.ReadLine();
        }
        // virtual metotlar voidden önce virtual yazarak override etmeye yarar. override ise inheritance oğul classında sadece o class'a özgü bir sonuç döndürmek için kullanılır.
        
        class Database
        {
            public virtual void Add() // virtual ekleyerek aşağıdaki class'ta(oğul) overrride edebileceğiz.
            {
                Console.WriteLine("Added");
            }

            public virtual void Delete()
            {
                Console.WriteLine("Deleted");
            }
            
        }
        // Örneğin sqlserver için bir class oluşturup override edersek, babadan aldığı özellikler dışında, override sayesinde kendine özgü sonuçlar da döndürecektir.
        class Sqlserver : Database
        {
            public override void Add()
            {
                base.Add();  // base "BABA" anlamındadır
                Console.WriteLine("sql server için ekleme yapıldı.");
            }
        }

       

    }
}
