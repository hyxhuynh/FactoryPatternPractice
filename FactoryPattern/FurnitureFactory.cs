using FactoryPattern.Furnitures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public class FurnitureFactory
    {
        public static IFurniture GetFurniture (string option)
        {
            switch (option)
            {
                case "1":
                    return new Mattress();
                case "2": 
                    return new BedFrame();
                case "3": 
                    return new Lamp();
                default:
                    Console.WriteLine($"You have entered: {option}. \nInput NOT recognized. \nDefault option requested:");
                    return new Mattress();
            }
        }
    }
}
