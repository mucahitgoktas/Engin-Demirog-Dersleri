using System;

namespace ReferenceAndValueType
{
    class Program
    {
        static void Main(string[] args)
        {
            // değer tipler
            int number1 = 10;
            int number2 = 20;
            number2 = number1; // number2 is number1, bu aşamaya kadar olan değerleri dikkate alır.
            number1 = 30; // bu değer eşitlikte dikkate alınmaz.
            
            Console.WriteLine(number2); // 11. satırdan önceyi dikkate alır.

            // referans tipler
            string[] cities1 = new[] {"Ankara", "Adana", "İzmir"}; // eşitliğin sağı için bir RefNo:101 atanır.
            string[] cities2 = new[] {"İstanbul", "BURSA", "Balıkesir"}; // eşitliğin sağı için RefNo:102 atanır.
            cities2 = cities1;// 102 is 101 deriz ve 102 >>> 101e dönüşür. 
            foreach (var city in cities2)
            {
                Console.WriteLine(city);
            }

            
            
            
            
            Console.ReadLine();
        }
    }
}
