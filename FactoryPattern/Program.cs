using System;

namespace FactoryPattern
{
    public class Program
    {
        static void Main(string[] args)
        { 
            int wheelCount;
            bool input = false;
            do
            {
                Console.WriteLine("Please enter the number of wheels you would like your vehicle to have!");
                input = int.TryParse(Console.ReadLine(), out wheelCount);
            } while (!input);

            var vehicle = VehicleFactory.GetVehicle(wheelCount);
            vehicle.Drive();
        }
    }
}
