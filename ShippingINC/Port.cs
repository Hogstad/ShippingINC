using System;
using System.Collections.Generic;
using System.Text;

namespace ShippingINC
{
    class Port
    {
        public string Name;
        public List<Ship> ShipQueue = new List<Ship>();
        public List<Boat> BoatQueue = new List<Boat>();
        public Wharf Wharf;
        public Harbor Harbor;
        public Rapport Rapport;
        public Cthuwu Cthuwu = new Cthuwu();
        public Random Randy = new Random();

        public Port(string name, Wharf wharf, Harbor harbor)
        {
            Name = name;
            Wharf = wharf;
            Harbor = harbor;
            Rapport = new Rapport(Name, Wharf, Harbor);
        }

        public void RequestShipOrBoat()
        {
            if (Randy.Next(0, 10) == 0)
            {
                var ship = Cthuwu.SendShip();
                ArrivingShip(ship);
            }
            else
            {
                var boat = Cthuwu.SendBoat();
                ArrivingBoat(boat);
            }
        }

        public void ArrivingShip(Ship ship)
        {
            ShipQueue.Add(ship);
        }
        public void ArrivingBoat(Boat boatyMcBoatface)
        {
            BoatQueue.Add(boatyMcBoatface);
        }

        public void HandleShipsNBoats()
        {
            Harbor.HandleBoat(BoatQueue);
            Wharf.HandleShips(ShipQueue);
        }

        public void HourlyTasks()
        {
            HandleShipsNBoats();
            RequestShipOrBoat();
        }

        public void DailyTasks()
        {
            Harbor.CheckBoatTime();
            Console.WriteLine(Rapport.SendRapport());
        }
    }
}
