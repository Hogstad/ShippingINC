using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;
using System.Threading;
using Microsoft.VisualBasic;


namespace ShippingINC
{
    class Program
    {
        public static Random Randy = new Random();
        static void Main()
        {
            int hours = 0;
            int days = 0;

            var cthuwu = new Cthuwu();
            var PortFlemming = new Port(new Wharf(5, 5, 2), new Harbor(300));

            while (true)
            {
                // hva som skjer hver time
                PortFlemming.HandleShipsNBoats();
                PortFlemming.RequestShipOrBoat();
                Console.WriteLine(hours);



                // kjsadhfkjahsdkfjhaskjdhfkja
                hours++;
                if (hours == 5)
                {
                    hours = 0;
                    days++;
                    // hva som skjer hvert døgn

                    PortFlemming.Harbor.CheckBoatTime();


                    Console.WriteLine($"\nDay {days}\nThere is {PortFlemming.Harbor.DockBoats.Count} boats in the harbor\n");


                    //hkafsgdkjfhaksjhdfkjahskjdf
                }
                Thread.Sleep(1000);
            }

        }
        
    }
}
/*
 *  C lager båter og ship
 *  P tar imot og sender til riktig plass
 *  W motar ship og håndterer de
 *  H mottar boat og håndterer de
 *
 *
 *
 *
 */
