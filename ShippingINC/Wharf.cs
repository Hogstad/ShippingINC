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
            Console.WriteLine($"Ship {ship.Shipname} arrived at the Wharf loaded with {ship.CurrentCapacity} tons of stuff");
        }
        public void HandleShips(List<Ship> shipQueue)
        {
            if (LoadUnloadShips.Count < ShipCapacity && shipQueue.Count > 0)
            {
                ArrivingShips(shipQueue[0]);
                shipQueue.Remove(shipQueue[0]);
            }
            CheckShipsInProcess();
        }

        public void CheckShipsInProcess()
        {
            for (var i = 0; i < LoadUnloadShips.Count; i++)
            {
                if (ProcessShip(LoadUnloadShips[i])) i--;
            }
        }

        public bool ProcessShip(Ship ship)
        {
            if (ship.Unloading)
            {
                UnloadShip(ship);
                return false;
            }
            else
            {
                return LoadShip(ship);
            }
        }
        public void UnloadShip(Ship ship)
        {
            ship.CurrentCapacity -= _unloadCapacity;
            if (ship.CurrentCapacity <= 0)
            {
                ship.CurrentCapacity = 0;
                ship.Unloading = false;
            }
        }
        public bool LoadShip(Ship ship)
        {
            ship.CurrentCapacity += _loadCapacity;
            if (ship.CurrentCapacity >= ship.CargoCapacity)
            {
                DepartShip(ship);
                return true;
            }

            return false;
        }
        public void DepartShip(Ship ship)
        {
            Console.WriteLine($"Ship {ship.Shipname} is fully loaded and left the Wharf with {ship.CargoCapacity} tons of goods");
            LoadUnloadShips.Remove(ship);
        }
    }
}
