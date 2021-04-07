using System.Collections.Generic;

namespace ShippingINC
{
    class Harbor
    {
        public int BoatCapacity;
        private List<Boat> _dockbBoats = new List<Boat>();

        public Harbor(int boatCapacity)
        {
            BoatCapacity = boatCapacity;
        }

        public void HandleBoat(Boat boat)
        {
            DeparteBoat(boat);
        }
        public void ArrivinBoats(Boat boat)
        {
            _dockbBoats.Add(boat);
        }

        public void DeparteBoat(Boat boat)
        {

        }
    }
}
