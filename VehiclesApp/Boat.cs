using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehiclesApp
{
    class Boat : Vehicle
    {
        public override void Float()
        {
            Console.WriteLine("I liek to float");
        }

        public override void Fly()
        {
            throw new NotImplementedException();
        }
    }
}
