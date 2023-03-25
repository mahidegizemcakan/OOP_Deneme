using OOP.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Entities
{

    //(engin)
    public class Gamer:IEntity
    {
        public int Id { get; set; }
        
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public int DogumYılı { get; set; }
        public long IdentityNumber  { get; set; }
}
}
