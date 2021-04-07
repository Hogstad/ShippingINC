﻿using System;

namespace ShippingINC
{
    class Ship
    {
        public string Shipname;
        public int CargoCapacity;
        public int CurrentCapacity;
        public bool InWharf = false;

        public Ship(int cargoCapacity, int currentCapacity, string shipname)
        {
            CargoCapacity = cargoCapacity;
            CurrentCapacity = currentCapacity;
            Shipname = shipname;
        }
    }
}
