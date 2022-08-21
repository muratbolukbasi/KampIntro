using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject
{
    class UserValidationManager : IUserValidation
    {
        public bool Validate(Gamer gamer)
        {
            if (gamer.BirthNumber == 1985 && gamer.FirstName=="ENGİN" && 
                gamer.LastName=="DEMİROĞ" && gamer.IdentyNumber == 12345)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
