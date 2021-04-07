using System;
using System.Collections.Generic;
using System.Text;

namespace ShippingINC.Boat
{
    class Ship
    {
        public int CargoCapacity;
        public int CurrentCapacity;

        public Ship(int cargoCapacity, int currentCapacity)
        {
            CargoCapacity = cargoCapacity;
            CurrentCapacity = currentCapacity;
        }
    }
}
