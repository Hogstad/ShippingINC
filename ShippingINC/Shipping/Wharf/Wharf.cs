using System;
using System.Collections.Generic;
using System.Text;

namespace ShippingINC.Shipping.Wharf
{
    class Wharf
    {
        public int LoadCapacity;
        public int UnloadCapacity;
        public int ShipCapacity;

        public Wharf(int loadCapacity, int unloadCapacity, int shipCapacity)
        {
            LoadCapacity = loadCapacity;
            UnloadCapacity = unloadCapacity;
            ShipCapacity = shipCapacity;
        }
    }
}
