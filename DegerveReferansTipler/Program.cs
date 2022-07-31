using System;

namespace DegerveReferansTipler
{
    class Program
    {
        static void Main(string[] args)
        {

            int sayi1 = 10;             //int,decimal,float,double ve bool tipleri değer tipleridir.
            int sayi2 = 30;              //anında değerleri değişiklik gösterebilir.
            sayi1 = sayi2;
            sayi2 = 65;
            Console.WriteLine(sayi1);  // 30 olacaktır.

            int[] sayilar1 = new int[] { 10, 20, 30 }; 
            int[] sayilar2 = new int[] { 100, 200, 300 };
            sayilar1 = sayilar2;                       //arrayler, classlar ve interfaceler
            sayilar2[0] = 999;                      // referans tiplerdir. Sadece referansları
            Console.WriteLine(sayilar1[0]);         // değişiklik gösterir. Değerleri değişiklik
                                                                // göstermez.

            //Bellekte Stack ve Heap diye 2 alan vardır. Değer tip olanlar stack te gerçekleşir.
            //Arraylerde new yazdığın zaman stackteki değerler heap e aktarılır.
        }
    }
}
