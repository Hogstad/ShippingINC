using System;
using System.Collections.Generic;

namespace ShippingINC
{
    class Wharf
    {
        private int _loadCapacity;
        private int _unloadCapacity;
        public int ShipCapacity;
        public List<Ship> LoadUnloadShips = new List<Ship>();

        public Wharf(int loadCapacity, int unloadCapacity, int shipCapacity)
        {
            _loadCapacity = loadCapacity;
            _unloadCapacity = unloadCapacity;
            ShipCapacity = shipCapacity;
        }

        public void ArrivingShips(Ship ship)
        {
            LoadUnloadShips.Add(ship);
            Console.WriteLine($"Ship {ship.Shipname} arrived at the Wharf");
        }
        public void HandleShips(List<Ship> ShipQueue)
        {
            if (LoadUnloadShips.Count < ShipCapacity && ShipQueue.Count > 0)
            {
                ArrivingShips(ShipQueue[0]);
                ShipQueue.Remove(ShipQueue[0]);
            }
        }

        public void CheckShipsInProcess()
        {
            foreach (var ship in LoadUnloadShips)
            {
                if (ship.InWharf = false)
                {
                    ProcessShip(ship);
                }
            }
        }

        public void ProcessShip(Ship ship)
        {
            ship.InWharf = true;
            UnloadShip(ship);
            LoadShip(ship);
            DepartShip(ship);
        }
        public void UnloadShip(Ship ship)
        {

        }
        public void LoadShip(Ship ship)
        {

        }
        public void DepartShip(Ship ship)
        {
            LoadUnloadShips.Remove(ship);
            Console.WriteLine($"Ship {ship.Shipname} is fully loaded and left the Wharf");
        }
    }
}
