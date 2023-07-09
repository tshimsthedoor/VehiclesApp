using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VehiclesApp
{
    public class FlyCapability : ICapability
    {
        public void CurrentCapability()
        {
            Console.WriteLine("It can fly now.");
        }
    }
}