using System;

namespace GameProject
{
    class Program
    {
        static void Main(string[] args)
        {
            GamerManager gamerManager = new GamerManager(new UserValidationManager());
            gamerManager.Add(new Gamer
            {
                ID = 1,
                FirstName="ENGİN",
                LastName="DEMİROĞ",
                BirthNumber=1985,
                IdentyNumber = 12345
            });

        }
    }
}
