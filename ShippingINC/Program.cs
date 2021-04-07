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
            CharacterGenerator(3);
            void CharacterGenerator(int num)
            {
                var text = String.Empty;
                for (var i = 0; i < num; i++)
                {
                    text += (char)Randy.Next(65, 91);
                }
                Console.WriteLine(text);
            }

            //int hours = 65;
            //int days = 0;

            //var PortFlemming = new Port(new Wharf(5, 5, 2), new Harbor(300));

            //while (true)
            //{
            //    // hva som skjer hver time





            //    // kjsadhfkjahsdkfjhaskjdhfkja
            //    hours++;
            //    if (hours == 24)
            //    {
            //        hours = 0;
            //        days++;
            //        // hva som skjer hvert døgn

            //        PortFlemming.Harbor.CheckBoatTime();


            //        Console.WriteLine($"Day {days}");

            //        //hkafsgdkjfhaksjhdfkjahskjdf
            //    }
            //    Thread.Sleep(1000);
            //}

        }
        
    }
}
