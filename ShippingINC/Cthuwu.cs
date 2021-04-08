using System;
using System.Security.Cryptography;
using static System.String;

namespace ShippingINC
{
    class Cthuwu
    {
        public Random Randy = new Random();

        public Ship SendShip()
        {
            return CreateShip();
        }
        public Ship CreateShip()
        {
            var cargoCap = CalcShipCapacity();
            var currentCargo = calcShipCargo(cargoCap);
            var shipName = CalcLicenseCode(3, 3);
            return new Ship(cargoCap, currentCargo, shipName);
        }
        private int CalcShipCapacity()
        {
            return Randy.Next(200, 5000);
        }
        private int calcShipCargo(int max)
        {
            return Randy.Next(200, max);
        }

        public Boat SendBoat()
        {
            return CreateBoat();
        }

        private Boat CreateBoat()
        {
            var size = CalcBoatSize();
            var timeInPort = CalcTimeInPort();
            var license = CalcLicenseCode(2,4);
            return new Boat(size, timeInPort, license);
        }

        private int CalcBoatSize()
        {
            return Randy.Next(10, 81);
        }

        private int CalcTimeInPort()
        {
            return Randy.Next(1, 20);
        }


        // license makers
        private string CalcLicenseCode(int numberOfCharacters, int numberOfNumbers)
        {
            var text = Empty;
            text += CharacterGenerator(numberOfCharacters);
            text += NumberGenerator(numberOfNumbers);

            return text;
        }
        private string NumberGenerator(int num)
        {
            var text = Empty;
            for (var i = 0; i < num; i++)
            {
                text += Randy.Next(10);
            }
            return text;
        }
        private string CharacterGenerator(int num)
        {
            var text = Empty;
            for (var i = 0; i < num; i++)
            {
                text += (char) Randy.Next(65, 91);
            }

            return text;
        }

    }
}