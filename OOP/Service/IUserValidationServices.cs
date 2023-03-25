using OOP.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Service
{

    //(engin)
    internal interface IUserValidationServices
    {
        bool Validate(Gamer gamer);
    }
}
