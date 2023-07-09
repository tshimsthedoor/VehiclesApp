using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VehiclesApp
{
    public class DoNothing : ICapability
    {
        public void CurrentCapability()
        {
            Console.WriteLine("It does nothing.");
        }
    }

   
}