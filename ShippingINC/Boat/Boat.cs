using System;
using System.Collections.Generic;
using System.Text;

namespace ShippingINC.Boat
{
    class Boat
    {
        public int Size;
        public int TimeInPort;

        public Boat(int size, int timeInPort)
        {
            Size = size;
            TimeInPort = timeInPort;
        }
    }
}
