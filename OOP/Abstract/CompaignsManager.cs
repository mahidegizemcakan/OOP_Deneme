using OOP.Entities;
using OOP.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Abstract
{
   public class CompaignsManager:ICompaignsService
    {

        public void Add(Compaigns compaigns)
        {
            Console.WriteLine("New Compaings Added. " + compaigns.Title);
        }

        public void Delete(Compaigns compaigns)
        {
            Console.WriteLine("Compaings Deleted. " + compaigns.Title);
        }

        public void Update(Compaigns compaigns)
        {
            Console.WriteLine("Compaings Updated. " + compaigns.Title);
        }
    }
}
