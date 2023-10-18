using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace group1
{
    internal class KitchenTable : Tables
    {
        public string Layer { get; }

        public KitchenTable(string color, int price, int height, int legs, string material, string shape, string layer)
            : base(color, price, height, legs, material, shape)
        {
             Layer = layer;
        }

        public void CreateTable()
        {
            Console.WriteLine($"This table is {Color} , the price is {Price}\n" +
                $"This table is {Height} cm high, it has {Legs} legs, it´s made out of {Material} and the shape of the table is {Shape}\nOn top of this table there´s a {Layer} to protect it´s surface\n");
        }
    }
}
