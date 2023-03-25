using OOP.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Entities
{
    public class Sales:IEntity
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public int Unit { get; set; }
        public double Total { get; set; }
    }
}
