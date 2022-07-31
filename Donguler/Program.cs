using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {

            string kurs1 = "Yazılım Geliştirici Yetiştirme Kampı";
            string kurs2 = "Programlamaya başlangıç için temel kurs";
            string kurs3 = "Java";
            string kurs4 = "Python";
            string kurs5 = "C#";

            Console.WriteLine(kurs1);
            Console.WriteLine(kurs2);
            Console.WriteLine(kurs3);
            Console.WriteLine(kurs4);
            Console.WriteLine(kurs5);

            Console.WriteLine("MANUEL YAZMA KOMUTU BİTER");
            Console.WriteLine("      ");

            // array - diziler
            Console.WriteLine("DÖNGÜLER");

            string[] kurslar = new string[]
            {
            "Yazılım Geliştirici Yetiştirme Kampı",
            "Programlamaya başlangıç için temel kurs",
            "Java",
            "Python",
            "C#",
            "ÇAĞLA"
            };


            // DÖNGÜLER
             
            for (int i = 0; i <kurslar.Length ; i++)   //kurslar.Length ne kadar madde varsa hepsini sıralamak için
            {                                           // kullanılır. 5 madde ise 5 ini yazdırır. Stringin uzunluk sayısı
                Console.WriteLine(kurslar[i]);          // neyse for döngüsü o kadar döner.
            }

            Console.WriteLine("FOR DÖNGÜSÜ BİTTİ");
            Console.WriteLine("       ");

            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }

            Console.WriteLine("Sayfa Sonu");
        
        }
    }
}
