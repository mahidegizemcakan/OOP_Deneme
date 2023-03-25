using OOP.Abstract;
using OOP.Concrete;
using System;

namespace OOP
{
    //(engin)
    public class Program
    {
        static void Main(string[] args)
        {
            GamerManager gamermanager = new GamerManager(new UserValidationManager());
            gamermanager.Add(new Entities.Gamer
            { 
                Id = 1,
                DogumYılı = 1995,
                Ad = "Gizem",
                Soyad="Cakan",
                IdentityNumber=1234 
            });
            Console.WriteLine("");
        }
    }
}
