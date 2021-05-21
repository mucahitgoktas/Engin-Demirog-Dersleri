using System;
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
        static void Main(string[] args)  /// ÖRNEK ASAL SAYI UYGULAMASI
        {

            Console.Write("Bir Sayi Giriniz :");
            int asalsayi = Convert.ToInt32(Console.ReadLine());
            Asalsayimi(asalsayi);
            Console.ReadLine();
        }

        private static bool Asalsayimi(int asalsayi)
        {
            bool sonuc = true;


            if (asalsayi % 1 == 0)
            {
                sonuc = true;
                Console.WriteLine("Asal Sayıdır :)");
            }

            else if (asalsayi % asalsayi == 0)
            {
                Console.WriteLine("Asal Sayıdır :)");
            }
            else
            {
                Console.WriteLine("Asal Sayı DEĞİLDİR!");
            }




            return sonuc;
        }
    }
}
