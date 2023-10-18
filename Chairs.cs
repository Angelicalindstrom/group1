using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace group1
{
    internal class Chairs: Furniture
    {
        public string Fabric { get; }

        public Chairs(string color, int price, int height, int legs, string material, string fabric) 
            :base(color, price, height, legs, material)
        {
            Fabric = fabric;
        }

        public void CreateChair()
        {
            Console.WriteLine($"This chair is {Color} , the price is {Price}\n" +
                $"This chair is {Height} cm high, it has {Legs} legs, it´s made out of {Material} and it´s upholstered with {Fabric}\n");
        }
    }
}
