using System;

namespace InterfacesDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            
            IEat[] eats = new IEat[2]
            {
                new Manager(), new Worker()


            };
            foreach (var eat in eats)
            {
                eat.Eat();
            }

            Console.ReadLine();
        }
        
    }

    interface IWork
    {
        void Work();
        
    }

    interface IEat
    {
        void Eat();
    }

    interface IGetSalary
    {
        void GetSalary();
    }
    class Manager : IWork, IEat, IGetSalary
    {
        public void Work()
        {
            throw new NotImplementedException();
        }

        public void Eat()
        {
            Console.WriteLine("Manager eated");
        }

        public void GetSalary()
        {
            throw new NotImplementedException();
        }
    }

    class Worker : IWork, IEat, IGetSalary
    {
        public void Work()
        {
            throw new NotImplementedException();
        }

        public void Eat()
        {
            Console.WriteLine("Worker eated.");
        }

        public void GetSalary()
        {
            throw new NotImplementedException();
        }
    }

    class Robot : IWork
    {
        public void Work()
        {
            throw new NotImplementedException();
        }
    }
}
