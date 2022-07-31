using System;

namespace KampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            string kategoriEtiketi = "Kategori";  // değer tutucu kategori etiketi dendiğinde
                                                  //Kategori yazdırılacak
            int ogrenciSayisi = 32000;
            double faizOrani = 1.69;             //double ondalıklı sayılar için kullanılır
            bool sistemeGirisyapmısMi = false;   //bool komutu 2 şartlı koşullarda geçerlidir
            double dolarDun = 7.35;
            double dolarBugun = 7.45;

            if (dolarDun >dolarBugun)  // DOLAR ARTTI MI AZALDI MI KOŞULU
            {
                Console.WriteLine("Azalış Oku");
            }
            else if (dolarDun < dolarBugun)
            {
                Console.WriteLine("Artış Oku");
            }
            else
            {
                Console.WriteLine("Sabit Oku");
            }


            if (sistemeGirisyapmısMi == true)
            {
                Console.WriteLine("Kullanıcı Ayarları Butonu");
            }
            else
            {
                Console.WriteLine("Giriş Yap Butonu");
            }

            
            Console.WriteLine(kategoriEtiketi);   
        }
    }
}
