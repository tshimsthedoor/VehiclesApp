using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehiclesApp
{
    class Boat : IVehicle
    {
        public void Float()
        {
            Console.WriteLine("I liek to float");
        }

        public void Fly()
        {
            throw new NotImplementedException();
        }
    }
}
