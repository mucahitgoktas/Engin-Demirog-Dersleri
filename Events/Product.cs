using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events // eventler delegelerle birlikte kullanılırlar.
{
    public delegate void StockControl(); // delege tanımlandı
    public class Product
    {
        private int _stock; 

        public Product(int stock) // ctor
        {
            _stock = stock;
        }

        public event StockControl StockControlEvent; // event tanımlandı.
        public string ProductName { get; set; }

        public int Stock // propla üretilen get ve set içerisi dolduruluyor.
        {
            get { return _stock; } // get içerisine _stok döndürdü.
            set
            {
                _stock = value; // set içerisine kişinin verdiği değer eşitledi.
                if (value <= 15 && StockControlEvent != null) // eğer stok değeri 15<= ise
                                                              // ve stockkontrolevent 0 dan fazlaysa,
                                                              // event tetiklenir.
                {
                    StockControlEvent();
                }
            }
        }

        public void Sell(int amount) // kaç tane satmak istediğimizi amount ile tanımladık.
        {
            Stock -= amount; // satış yapıldığında stoktan düştü
            Console.WriteLine("{1} Stock amount : {0}", Stock, ProductName); // kalan stok adedini cw etti.
        }
    }
}