using OOP.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Abstract
{
    public interface IBaseGamer<T> where T : IEntity,new()
    {
        public void Delete(Gamer gamer)
        {
            throw new NotImplementedException();
        }

        public virtual void Save(Gamer gamer)
        {
            Console.WriteLine("Saved to db : " + gamer.Ad);
        }

        public void Update(Gamer gamer)
        {
            throw new NotImplementedException();
        }
    }
}
