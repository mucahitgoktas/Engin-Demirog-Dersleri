using System;

namespace Abstract
{
    class Program
    {
        static void Main(string[] args)
        {
            Database database = new SqlServer(); // abstractlar new'lenemez!! bunun yerine eşitliğin karşısına, alt sınıf (oğul) new'lenebilir. birkaç farklı oğul varsa herbiri ayrı değişkene atanır.
            Console.WriteLine(database);
            Console.ReadLine();
        }
    }

    // abstracklar inheritens özelliği taşır ancak, virtual methodlar gibi bazı özel durumlar için kullanılır. 
    // örneğin bir metod (add) her class için aynıysa ancak (Delete) her metot için farklı olacaksa, abstractlardan yararlanılır.


    abstract class Database 
    {
        public void Add()
        {
            Console.WriteLine("Added");
        }

        public abstract void Delete();
    }

    class SqlServer : Database
    {
        public override void Delete()
        {
            throw new NotImplementedException();
        }
    }
}
