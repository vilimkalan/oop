using LV5.interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using LV5.interfaces;
namespace LV5.classes
{
    internal class Product : IShipable
    {
        private double price;
        private string description;
        private double weight;
        public Product(string description, double price)
        {
            this.description = description;
            this.price = price;
        }
        public double Weight { get { return weight; } }
        public double Price { get { return this.price; } }
        public string Description(int depth = 0)
        {
            return new string(' ', depth) + this.description;
        }
    }
}
