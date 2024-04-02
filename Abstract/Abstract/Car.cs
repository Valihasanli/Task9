using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract
{
    internal class Car : Vehicle
    {
        public Car(int year, string color, string brand, string model, int maxSpeed) : base(year, color)
        {
            Brand = brand;
            Model = model;
            MaxSpeed = maxSpeed;
        }
        public string Brand { get; set; }
        public string Model { get; set; }
        private int _maxspeed;
        public int MaxSpeed { get { return _maxspeed; } set { if (value > 0) _maxspeed = value; } }



        public override void ShowInfo()
        {
            Console.WriteLine($"{Year} {Color} {Brand} {Model} {MaxSpeed}");
        }
    }
}
