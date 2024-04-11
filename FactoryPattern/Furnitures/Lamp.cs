using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern.Furnitures
{
    public class Lamp : IFurniture
    {
        public string LightBulb { get; set; } = "incandescent";
        public double Price { get; set; } = 24.99;
        public string Material { get; set; } = "ceramic";
        public string Color { get; set; } = "blue";

        public void Order()
        {
            Console.WriteLine($"Ordering a {Color} {Material} lamp with {LightBulb} lightbulb for {Price} dollars...");
        }
    }
}
