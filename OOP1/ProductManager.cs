using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    class ProductManager
    {
        public void Add(Product product)
        {
            Console.WriteLine(product.ProductName + " eklendi.");
        }

        public void Update(Product product) 
        {
            Console.WriteLine(product.ProductName + " güncellendi");
        }

        public int Topla(int sayi1,int sayi2)    //İstediğimiz değeri birden çok kullanmak istersek
        {                                        //return ifadesi ile yazarız. Elde ettiğimiz sayıyı
            return sayi1 + sayi2;                //farklı sayılarla yeni ifadelerde kullanabiliriz.
        }

        public void Topla2(int sayi1,int sayi2)   //Tek seferlik ekrana yazdırmalık metotlarda
        {                                         //void kullanırız. 2. sefere aynı değeri farklı
            Console.WriteLine(sayi1+sayi2);       //durumlarda kullanamayız. Çalışır ve biter.
        }

        
    }
}
