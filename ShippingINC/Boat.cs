namespace ShippingINC
{
    class Boat
    {
        public string Boatname;
        public int Size;
        public int TimeInPort;
        public bool InHarbor = false;

        public Boat(int size, int timeInPort, string boatname)
        {
            Size = size;
            TimeInPort = timeInPort;
            Boatname = boatname;
        }
    }
}
