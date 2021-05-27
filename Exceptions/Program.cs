using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Exceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            //ExceptionIntro();

            //TryCatch();

            //ActionDemo();

            Func<int, int, int> add = Topla; // func işlemi.

            Console.WriteLine(add(3, 5)); // func için değerler burada verilir. ve bize int döndürür.

            Func<int> getRandomNumber = delegate () // func tek parametre almış,
                                                    // demekki parametresiz metotlara delegasyon yapıyor
                                                    // ve sonuçta int döndürüyor.
            {
                Random random = new Random(); // random sınıfı çağırılıyor ( hazır sınıf ) 
                return random.Next(1, 100); // 1-100 arası random bir sayı üretir.
            };


            Func<int> getRandomNumber2 = () => new Random().Next(1, 100); // farklı tipte func yazılışı.

            Console.WriteLine(getRandomNumber()); // random sayı üreten bir func.
            Thread.Sleep(1000); // uygulamayı 1 saniye bekleten kod.
                                                // ( cpu random üretirken biraz beklesin diye)
            Console.WriteLine(getRandomNumber2()); // random sayı.

            //Console.WriteLine(Topla(2,3));

            Console.ReadLine();
        }

        static int Topla(int x, int y) // "Func" için yapılan bir örnek
        {
            return x + y;
        }

        private static void ActionDemo()
        {
            HandleException(() => { Find(); });
        }

        private static void TryCatch()
        {
            try
            {
                Find();
            }
            catch (RecordNotFoundException exception)
            {
                Console.WriteLine(exception.Message);
            }
            catch (Exception exception)
            {
            }
        }

        private static void HandleException(Action action) // action void kod bloklarını parametreler alarak kullanır.
        {
            try
            {
                action.Invoke();
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }

        }

        private static void Find()
        {
            List<string> students = new List<string> { "Engin", "Derin", "Salih" };

            if (!students.Contains("Ahmet"))
            {
                throw new RecordNotFoundException("Record Not Found!");
            }
            else
            {
                Console.WriteLine("Record Found!");
            }
        }

        private static void ExceptionIntro()
        {
            try
            {
                string[] students = new string[3] { "Engin", "Derin", "Salih" };
                students[3] = "Ahmet";
            }
            catch (IndexOutOfRangeException exception)
            {
                Console.WriteLine(exception.Message);
            }
            catch (DivideByZeroException exception)
            {
                Console.WriteLine(exception.Message);
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
        }
    }
}
