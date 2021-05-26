using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Reflection // Çalışma anında bilgi toplayabilir ve toplanan bir bilgiye göre örneğin bir metotu çalıştırabiliriz.
                     // Reflection pahalı bir şeydir, performans kaybına sebep olur.
                     // Bir çok fonksiyona sahiptir, araştırarak üzerine koyulabilir.

{
    class Program
    {
        static void Main(string[] args)
        {
            //DortIslem dortIslem=new DortIslem(2,3); 
            //Console.WriteLine(dortIslem.Topla2());
            //Console.WriteLine(dortIslem.Topla(3, 4));

            var tip = typeof(DortIslem); // Reflection giriş, çalışacağım bir tip var o da (DortIslem) = "tip alma işlemi"

            //DortIslem dortIslem = (DortIslem)Activator.CreateInstance(tip,6,7);
            //Console.WriteLine(dortIslem.Topla(4, 5));
            //Console.WriteLine(dortIslem.Topla2());

            var instance = Activator.CreateInstance(tip, 6, 5); // Activator ile çalışma anında (DortIslem)'i new'lemiş oluyoruz.

            MethodInfo methodInfo = instance.GetType().GetMethod("Topla2"); // GetType ile instance'ın yani DortIslem'in tipini alabiliyoruz(DortIslem)

            Console.WriteLine(methodInfo.Invoke(instance, null)); // Invoke ile metot'u çalıştırıyoruz parametresiz çalışmak için "Null".
                                                                          // Özetle Bir tipin(GetType) metoduna ulaşabiliriz (GetMethod) ve onu çalıştırabiliriz(Invoke)

            Console.WriteLine("------------------");
            var metodlar = tip.GetMethods(); // tipin metotlarına ulaşır, arraydir.

            foreach (var info in metodlar)
            {
                Console.WriteLine("Metod adı : {0}", info.Name); // classtaki tüm metotların isimlerini listeler.
                foreach (var parameterInfo in info.GetParameters())
                {
                    Console.WriteLine("Parametre : {0}", parameterInfo.Name); // Parametlerini listeler
                }

                foreach (var attribute in info.GetCustomAttributes()) 
                {
                    Console.WriteLine("Attribute Name : {0}", attribute.GetType().Name); // Attirbute'lerini listeler.
                }
            }

            Console.ReadLine();
        }
    }

    public class DortIslem
    {
        private int _sayi1;
        private int _sayi2;

        public DortIslem(int sayi1, int sayi2)
        {
            _sayi1 = sayi1;
            _sayi2 = sayi2;
        }

        public DortIslem()
        {

        }
        public int Topla(int sayi1, int sayi2)
        {
            return sayi1 + sayi2;
        }

        public int Carp(int sayi1, int sayi2)
        {
            return sayi1 * sayi2;
        }

        public int Topla2()
        {
            return _sayi1 + _sayi2;
        }

        [MetodName("Carpma")]
        public int Carp2()
        {
            return _sayi1 * _sayi2;
        }
    }

    public class MetodNameAttribute : Attribute // örnek bir attirbute tanımı, yukarıdaki GetCustomAttributes fonksiyonu için.
    {
        public MetodNameAttribute(string name)
        {

        }
    }
}
