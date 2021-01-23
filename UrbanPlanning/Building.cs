using System;
using System.Collections.Generic;
using System.Text;

namespace UrbanPlanning
{
    class Building
    {
        // private fields
        private string _address { get; set; }
        private string _designer { get; set; }
        private DateTime _dateConstructed { get; set; }
        private string _owner { get; set; }

        // public fields
        public int Stories { get; set; }
        public double Width { get; set; }
        public double Depth { get; set; }
        public double Volume { get { return Width * Depth * 3 * Stories; } }

        public Building(string address)
        {
            _address = address;
        }

        public void Construct()
        {
            _dateConstructed = DateTime.Now;
        }

        public void Purchase(string purchaser)
        {
            _owner = purchaser;
        }

        public void Design(string designer)
        {
            _designer = designer;
        }


        public void Display()
        {
            Console.WriteLine(@$"
        {this._address}---------------
        Designed by {this._designer}
        Constructed on {this._dateConstructed}
        Owned by {this._owner}
        {this.Volume} cubic meters of space

        ");
        }


    }
}
