using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VehiclesApp
{
    public class FloatCapability : ICapability
    {
        public void CurrentCapability()
        {
            Console.WriteLine("It can float now.");
        }
    }
}