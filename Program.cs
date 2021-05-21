using System;
using System.ComponentModel.Design;
using System.Threading.Channels;

namespace Engin_Demirog_Dersleri
{
    class Program
    {
        /*  ///  FOR DÖNGÜSÜ  
        {
            for (int i = 0; i <= 100; i++) 
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();
        }*/
        /*  ///  WHİLE
        {
            int number = 100;
            while (number > 0)
            {
                Console.WriteLine(number);
                number--;

            }
            Console.WriteLine($"now number is : {number}");
            Console.ReadLine();

        }*/
        /* ///  DO WHİLE
        {
            int number = 10;
            do
            {
                Console.WriteLine(number);
                number--;

            } while (number >= 9);
        }*/
        /*  ///  FOREACH
          {
            string[] studens = new string[3] {"ali", "veli", "mehmet"};
            foreach (var student in studens)
            {
                Console.WriteLine(student);
            }
            Console.ReadLine();

        }*/
        /*  /// ÖRNEK ASAL SAYI UYGULAMASI
        {
            Console.WriteLine("****ASAL SAYI TESPİT ÖRNEĞİ*****");
            Console.Write("Bir Sayi Giriniz :");
            int asalsayi = Convert.ToInt32(Console.ReadLine());

            
            if (Asalsayimi(asalsayi))
            {
                Console.WriteLine($"{asalsayi} Asal Sayıdır :))");
            }
            else
            {
                Console.WriteLine($"{asalsayi} Asal Sayı Değildir!!!");       
            } 
            
            Console.ReadLine();
        }


        private static bool Asalsayimi(int asalsayi)
        {
            bool sonuc = true;

            for (int i = 2; i < asalsayi-1; i++)
            {
                if (asalsayi % i == 0)
                {
                    sonuc = false;
                    i = asalsayi;

                }
                else
                {
                    sonuc = true;
                    

                }
            }





            return sonuc;
        }*/
        static void Main(string[] args)
        {

        }
    }
}
