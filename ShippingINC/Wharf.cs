using System.Collections.Generic;

namespace ShippingINC
{
    class Wharf
    {
        private int _loadCapacity;
        private int _unloadCapacity;
        private int _shipCapacity;
        private List<Ship> _loadUnloadShips = new List<Ship>();

        public Wharf(int loadCapacity, int unloadCapacity, int shipCapacity)
        {
            _loadCapacity = loadCapacity;
            _unloadCapacity = unloadCapacity;
            _shipCapacity = shipCapacity;
        }

        public void ArrivingShips(Ship ship)
        {
            _loadUnloadShips.Add(ship);
        }

        public void LoadShips()
        {

        }

        // metode tar inn et ship 
        // se om det er plass til ship
        //      ikke: plasser i load queue
    }
}
