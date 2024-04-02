using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract
{
    internal class Bus : Vehicle
    {
        public Bus(int year, string color, byte passengercount) : base(year, color)
        {
            PassengerCount = passengercount;
        }
        private byte _passengercount;
        public byte PassengerCount
        {
            get { return _passengercount; }
            set { if (value > 0) _passengercount = value; }
        }
        public override void ShowInfo()
        {
            Console.WriteLine($"{Year} {Color} {PassengerCount}");
        }
    }
}
