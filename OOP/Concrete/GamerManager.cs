using OOP.Abstract;
using OOP.Entities;
using OOP.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Concrete
{
    //MicroService(engin)
    class GamerManager : IGamerService
    {
        IUserValidationServices _userValidationServices;

        public GamerManager(IUserValidationServices userValidationServices)
        {
            _userValidationServices = userValidationServices;
        }

        public void Add(Gamer gamer)
        {
            if (_userValidationServices.Validate(gamer)==true)
            {
                Console.WriteLine("Kayıt oldu");
            }
            else
            {
                Console.WriteLine("Kayıt basarısız");
            }
            
        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine(" kayıt silindi");
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine("Guncelleme oldu");
        }
    }
}
