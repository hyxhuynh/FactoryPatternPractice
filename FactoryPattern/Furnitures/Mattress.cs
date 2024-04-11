using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern.Furnitures
{
    public class Mattress : IFurniture
    {
        public string MattressSize { get; set; } = "Queen";
        public double Price { get; set; } = 449.99;
        public string Material { get; set; } = "innerspring";
        public string Color { get; set; } = "white";

        public void Order()
        {
            Console.WriteLine($"Ordering a {Color} {Material} {MattressSize} mattress for {Price} dollars...");
        }
    }
}
