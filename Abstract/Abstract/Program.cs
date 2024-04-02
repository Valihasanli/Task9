namespace Abstract
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car(2011, "black", "BMW", "F30", 280);
            Bus bus = new Bus(2010, "White", 40);
            car.ShowInfo();
            bus.ShowInfo();

        }
    }
}
