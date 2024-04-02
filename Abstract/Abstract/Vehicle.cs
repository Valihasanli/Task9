using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract
{
    internal abstract class Vehicle
    {
        public int Year { get; set; }
        public string Color { get; set; }
        protected Vehicle(int year, string color)
        {
            Year = year;
            Color = color;
        }
        public abstract void ShowInfo();
    }
}
