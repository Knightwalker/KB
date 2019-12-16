﻿using System;
using System.Collections.Generic;
using System.Text;

using AquaShop.Models.Decorations.Contracts;

namespace AquaShop.Models.Decoration
{
    public abstract class Decoration : IDecoration
    {
        public Decoration(int comfort, decimal price)
        {
            this.Comfort = comfort;
            this.Price = price;
        }
        public int Comfort
        {
            get;
            private set;
        }

        public decimal Price
        {
            get;
            private set;
        }
    }

}