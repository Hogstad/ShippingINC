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

        public Port(Wharf wharf, Harbor harbor)
        {
            Wharf = wharf;
            Harbor = harbor;
        }

        public void ArrivingShip(Ship ship)
        {
            ShipQueue.Add(ship);
        }
        public void ArrivingBoat(Boat boatyMcBoatface)
        {
            Harbor.ArrivingBoat(boatyMcBoatface);
        }

        public void HandleShipsNBoats()
        {
            HandleBoat();
            HandleShips();
        }
        public void HandleShips()
        {
            if (Wharf.LoadUnloadShips.Count < Wharf.ShipCapacity)
            {
                Wharf.ArrivingShips(ShipQueue[0]);
                ShipQueue.Remove(ShipQueue[0]);
            }
        }
        public void HandleBoat()
        {
            if (Harbor.BoatCapacity > Harbor.DockBoats.Count)
            {
                Harbor.DockBoats.Add(BoatQueue[0]);
                BoatQueue.Remove(BoatQueue[0]);
            }
        }
    }
}
