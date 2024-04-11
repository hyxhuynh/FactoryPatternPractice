using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern.Furnitures
{
    public class BedFrame : IFurniture
    {
        public string FrameSize { get; set; } = "Queen";
        public double Price { get; set; } = 159.99;
        public string Material { get; set; } = "solid wood";
        public string Color { get; set; } = "brown";

        public void Order()
        {
            Console.WriteLine($"Ordering a {Color} {Material} {FrameSize} bedframe for {Price} dollars...");
        }
    }
}
