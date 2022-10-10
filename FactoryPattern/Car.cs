using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern
{
    public class Car : IVehicle
    {
        public void Drive()
        {
            Console.WriteLine("Would you like a car or truck?");
            var userInput = Console.ReadLine();
            userInput.ToLower();

            if (userInput == "car")
            {
                Console.WriteLine("Building a new Car!");
            }if (userInput == "truck")
            {
                Console.WriteLine("Building a new Truck!");
            }    
        }
    }
}
