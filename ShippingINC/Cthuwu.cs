using System;

namespace ShippingINC
{
    class Cthuwu
    {
        public Random Randy = new Random();

        private void ShipOrBoat()
        {
            if (Randy.Next(0, 10) == 0)
            {
                // ship
            }
            else
            {
                // boat
            }
        }

        public void SendShip(Port port)
        {
            var cargoCap = CalcShipCapacity();
            var currentCargo = calcShipCargo(cargoCap);
            var shipName = CalcShipName();
            var ship = new Ship(cargoCap, currentCargo, shipName);
        }

        private string CalcShipName()
        {
            var text = String.Empty;
            text += CharacterGenerator(3);


            return text;
        }

        private string CharacterGenerator(int num)
        {
            var text = String.Empty;
            for (var i = 0; i < num; i++)
            {
                text += (char) Randy.Next(65, 91);
            }

            return text;
        }


        private int CalcShipCapacity()
        {
            return Randy.Next(200, 5000);
        }

        private int calcShipCargo(int max)
        {
            return Randy.Next(200, max);
        }

    }
}