namespace ShippingINC
{
    class Ship
    {
        public int CargoCapacity;
        public int CurrentCapacity;

        public Ship(int cargoCapacity, int currentCapacity)
        {
            CargoCapacity = cargoCapacity;
            CurrentCapacity = currentCapacity;
        }
    }
}
