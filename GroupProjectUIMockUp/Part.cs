using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupProjectUIMockUp
{
    class Part
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }


        public Part(string name, string description, decimal price)
        {
            Name = name;
            Description = description;
            Price = price;
        }
    }
}
