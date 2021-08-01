using System;

namespace GameProject
{
    class Program
    {
        static void Main(string[] args)
        {
            GamerManager gamerManager = new GamerManager(new UserValidationManager());
            gamerManager.Add(new Gamer { Id = 1, FirstName = "Mehmet", LastName = "BOZDAL", BirthYear = 1978, IdentityNumber =12345 });
        }
    }
}
