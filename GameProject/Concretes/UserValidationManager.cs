using GameProject.Abstract;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject.Concretes
{
    class UserValidationManager : IUserValidationService
    {
        public bool Validate(User user)
        {
            if(user.FirstName=="Mehmet" && user.LastName == "Şimbil" && user.BirthYear == 1998 && user.IdentityNumber == 1111)
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
