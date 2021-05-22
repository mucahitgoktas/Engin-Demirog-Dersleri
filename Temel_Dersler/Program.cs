using System;

namespace Temel_Dersler
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
        /*  ///  STRİNG
         {
             string sentence = "My name is Mücahit Göktaş";
             var result = sentence.Length; // cümledeki karakterlerin sayısını döndürür. (boşluklar da 1 karakter sayılır)
             var result2 = sentence.Clone(); // cümleyi klonlar
             bool result3 = sentence.EndsWith("ş"); // bu cümle "ş" ile bitiyor mu?
             bool result4 = sentence.StartsWith("My name"); // bu cümle "My name" ile başlıyor mu?
             var result5 = sentence.IndexOf("name"); // metinde başta başlayarak "My name" arar.
             var result6 = sentence.LastIndexOf("m"); // metinde sondan başlayarak "m" arar.
             var result7 = sentence.Insert(0,"Hello, "); // 0'ıncı karakterden itibaren metine ekleme yapar.
             var result8 = sentence.Substring(3); // 3. karakterden sonrasını yazdırır. (name is...)
             string result9 = sentence.Substring(11,7); // 11. karakterden sonraki 7 karakteri yazdırır. (Mücahit)
             var result10 = sentence.ToLower(); // Bütün karakterleri küçük harfe çevirir.
             var result11 = sentence.ToUpper(); // Bütün karakterleri büyük harfe çevirir.
             var result12 = sentence.Replace(" ", "-"); // boşluk yerine "-" yazar.
             var result13 = sentence.Remove(2); // 2. karakterden itibaren siler. Remove(2,5) 2' den itibaren 5 karakteri uçurur.



             Console.WriteLine(result9);
             Console.ReadLine();

         }*/

        static void Main(string[] args)
        {
            Console.WriteLine("Selam");
            Console.ReadLine();
        }
    }
}
