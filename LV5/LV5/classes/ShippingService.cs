using LV5.interfaces;
using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace LV5.classes
{
    //Napisati klasu ShippingService koja ima metodu za računanje cijene dostave paketa. Cijena se računa na
    //temelju mase/težine paketa i jedinične cijene za masu.Jedinična cijena za masu je atribut navedene klase.

    internal class ShippingService
    {
        double PricePerKG = 0.5;
        

        public double CalculatePrice(IShipable item)
        {
            return item.Price + item.Weight * PricePerKG;
        }
        
    }
}
