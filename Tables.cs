using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace group1
{
    internal class Tables : Furniture
    {
        public string Shape { get; }

        public Tables(string color, int price, int height, int legs, string material, string shape)
            : base(color, price, height, legs, material)
        {
            Shape = shape;
        }

        public void CreateTable()
        {
            Console.WriteLine($"This table is {Color} , the price is {Price}\n" +
                $"This table is {Height} cm high, it has {Legs} legs, it´s made out of {Material} and the shape of the table is {Shape}\n");
        }
    }
}
