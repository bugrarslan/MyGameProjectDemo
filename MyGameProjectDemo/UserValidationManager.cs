using System;
using System.Collections.Generic;
using System.Text;

namespace MyGameProjectDemo
{
    class UserValidationManager : IUserValidationService
    {
        bool IUserValidationService.Validate(Gamer gamer)
        {
            if (gamer.BirthYear == 2002 && gamer.FirstName == "BUĞRA" && gamer.LastName == "ARSLAN" && gamer.IdentityNumber == 12345)
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
