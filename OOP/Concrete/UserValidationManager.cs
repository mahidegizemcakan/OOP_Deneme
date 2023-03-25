using OOP.Entities;
using OOP.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Concrete
{

    //(engin)
    internal class UserValidationManager : IUserValidationServices
    {
        public bool Validate(Gamer gamer)
        {
            if (gamer.DogumYılı == 1995 && gamer.Ad == "Gizem" 
                && gamer.Soyad == "cakan" && gamer.IdentityNumber == 1234)
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
