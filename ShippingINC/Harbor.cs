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
            for (var i = 0; i < DockBoats.Count; i++)
            {
                DockBoats[i].TimeInPort--;
                if (DockBoats[i].TimeInPort <= 0)
                {
                    DepartBoat(DockBoats[i]);
                    i--;
                }
            }
        }
        public void HandleBoat(List<Boat> BoatQueue)
        {
            if (BoatCapacity > DockBoats.Count && BoatQueue.Count > 0)
            {
                ArrivingBoat(BoatQueue[0]);
                BoatQueue.Remove(BoatQueue[0]);
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
