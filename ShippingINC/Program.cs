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
            var PortFlemming = new Port("Port Flemming", new Wharf(50, 50, 3), new Harbor(300));

            while (true)
            {
                PortFlemming.HourlyTasks();
                if (PortFlemming.Rapport.IsNewDay())
                {
                    PortFlemming.DailyTasks();
                    Thread.Sleep(3000);
                }
                Thread.Sleep(1000);
            }
        }
    }
}

