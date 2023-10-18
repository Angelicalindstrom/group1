using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace group1
{
    internal class LoungeChair : Chairs
    {
        public string Functionality { get; }

        public LoungeChair(string color, int price, int height, int legs, string material, string fabric, string functionality)
            : base(color, price, height, legs, material, fabric)
        {
            Functionality = functionality;
        }

        public void CreateChair()
        {
            Console.WriteLine($"This chair is {Color} , the price is {Price}\n" +
                $"This chair is {Height} cm high, it has {Legs} legs, it´s made out of {Material} and it´s upholstered with {Fabric}\n" +
                $"This chair got a special feature with {Functionality}\n");
        }
    }
}
