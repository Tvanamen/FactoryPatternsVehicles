using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern
{
    public class ThreeWheeler : IVehicle
    {
        public void Drive()
        {
            Console.WriteLine("Building a new Three wheeler ATV!");
        }
    }
}
