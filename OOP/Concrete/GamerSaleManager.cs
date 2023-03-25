using OOP.Abstract;
using OOP.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Concrete
{
    public class GamerSaleManager:SalesManager
    {
        public override void Add(Sales sales)
        {
            Compaigns compaigns1 = new Compaigns()
            {
                Id = 1,
                Title = "New Year Compaings",
                Description = "Espacially To New Year %30 Sale From Game.",
            };
            AddCompaigns(compaigns1);
            base.Add(sales);
        }

        private void AddCompaigns(Compaigns compaigns)
        {
            Console.WriteLine("Compaings Added. " + compaigns.Title);
        }
    }
}
