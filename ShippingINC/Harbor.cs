using System;
using System.Collections.Generic;

namespace ShippingINC
{
    class Harbor
    {
        public int BoatCapacity;
        public List<Boat> DockBoats = new List<Boat>();

        public Harbor(int boatCapacity)
        {
            BoatCapacity = boatCapacity;
        }

        public void CheckBoatTime()
        {
            foreach (var boat in DockBoats)
            {
                boat.TimeInPort--;
                if (boat.TimeInPort <= 0)
                {
                    DepartBoat(boat);
                }
            }
        }
        public void ArrivingBoat(Boat boat)
        {
            DockBoats.Add(boat);
            Console.WriteLine($"Boat {boat.Boatname} arrived at the Harbor");
        }

        public void DepartBoat(Boat boat)
        {
            DockBoats.Remove(boat);
            Console.WriteLine($"Boat {boat.Boatname} left the Harbor");
        }
    }
}
