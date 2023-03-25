using OOP.Entities;
using OOP.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Abstract
{
    public class SalesManager:ISalesService
    {
        public virtual void Add(Sales sales)
        {
            Console.WriteLine("LoL Saved To Database.");
        }

        public void Delete(Sales sales)
        {
            Console.WriteLine("LoL Deleted From Database.");
        }

        public void Update(Sales sales)
        {
            Console.WriteLine("LoL Updated.");
        }
    }
}
