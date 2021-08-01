using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class UserValidationManager:IUserValidationService
    {
        public bool Validate(Gamer Gamer)
        {
            if (Gamer.Id==1 && Gamer.BirthYear == 1978 && Gamer.FirstName == "Mehmet" && Gamer.LastName=="BOZDAL" && Gamer.IdentityNumber==12345)
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
