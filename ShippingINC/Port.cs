using System;
using System.Collections.Generic;
using System.Text;

namespace ShippingINC
{
    class Port
    {
        public List<Ship> ShipQueue = new List<Ship>();
        public List<Boat> BoatQueue = new List<Boat>();
        public Wharf Wharf;
        public Harbor Harbor;


        public void ArrivingShips(Ship ship)
        {
            ShipQueue.Add(ship);
        }
        public void ArrivingBoats(Boat boatyMcBoatface)
        {
            BoatQueue.Add(boatyMcBoatface);
        }
    }
}
