using MYAZ203.Week_4;
namespace MYAZ203.Week_4
{
    public class Program
    {
        public static void Main()
        {
            Vehicle vehicle = new Vehicle();
            vehicle.Engine = 5.0;
            vehicle.Model = "Ford";
            vehicle.Price = 500000;
            vehicle.Transmission = "auto";
            vehicle.NumberOfWheel = 4;

            Console.WriteLine(vehicle.ToString());

            Car car = new Car(6, "Volvo", 6, 750000, "auto");
            Truck truck = new Truck(5.0, "Mercedes", 12, 1500000, "manuel");
            Bus bus = new Bus(3.5, "MAN", 6, 250000, "manuel");

            Console.WriteLine(car.ToString());
            Console.WriteLine(bus.ToString());
            Console.WriteLine(truck.ToString());
        }
    }
}