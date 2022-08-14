using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    interface IKrediManager  //interface ler diğer sınıflara yol gösterici,rehberlik
    {                         //yapmak için oluşturulur.Zorunlu olan bazı özelliklerin
        void Hesapla();           //aktarılmasını sağlayan kavramdır.
        void BiseyYap();
    }                           //NOT: Interfaceleri birbirinin alternatifi olan
}                               //ama kod içerikleri farklı olan durumlar için kullanırız.
