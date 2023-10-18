using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace group1
{
    public abstract class Furniture
    {
        public string Color { get; set; }
        public int Price { get; set; }
        public int Height { get; set; }
        public int Legs { get; set; }
        public string Material { get; set; }
        public Furniture(string color, int price, int height, int legs, string material )
        {
            Color = color;
            Price = price;
            Height = height;
            Legs = legs;
            Material = material;
        }
    }
    
}
