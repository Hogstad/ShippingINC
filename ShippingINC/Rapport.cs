using System;

namespace ShippingINC
{
    class Rapport
    {
        private int _days = 0;
        private int _hours = 0;
        private Wharf _wharf;
        private Harbor _harbor;
        private string _portName;


        public Rapport(string portName, Wharf wharf, Harbor harbor)
        {
            _portName = portName;
            _wharf = wharf;
            _harbor = harbor;
        }
        
        public bool IsNewDay()
        {
            if (_hours == 24)
            {
                _hours = 0;
                _days++;
                return true;
            }
            _hours++;
            return false;
        }

        public string SendRapport()
        {
            var text = $"\n\n{_portName}\nRapport day {_days}\n\n";
            text += HarborRapport();
            text += WharfRapport();
            return text;
        }
        private string HarborRapport()
        {
            return $"There is {_harbor.DockBoats.Count} / {_harbor.BoatCapacity} boats in {_portName}\n\n";
        }

        private string WharfRapport()
        {
            return "";
        }

    }
}