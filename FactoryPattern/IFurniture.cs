﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public interface IFurniture
    {
        public double Price { get; set; }
        public string Material {  get; set; }
        public string Color { get; set; }
        void Order();
    }
}
