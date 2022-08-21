using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject
{
    class GamerManager : IGamerService
    {
        IUserValidation userValidation;

        public GamerManager(IUserValidation userValidation)
        {
            this.userValidation = userValidation;
        }

        public void Add(Gamer gamer)
        {
            if (userValidation.Validate(gamer)==true)
            {
                Console.WriteLine("Kayıt Oldu");
            }
            else
            {
                Console.WriteLine("Doğrulama başarısız. Kayıt Başarısız");
            }
        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine("Kayıt Güncellendi");
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine("Kayıt Silindi");
        }
    }
}
