using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehiclesApp
{
    class Boat : Vehicle
    {
        string registrationId;

        public Boat(string registration)
        {
            this.registrationNumber = registrationId;
            this.vehicleType = "Boat";
            this.vehicleBehavior = new DoNothing();
        }
        public override void DisplayDetails()
        {
            throw new NotImplementedException();
        }

        //public override void Float()
        //{
        //    Console.WriteLine("I liek to float");
        //}

        //public override void Fly()
        //{
        //    throw new NotImplementedException();
        //}

        public override void SetVehicleBehavior(ICapability behavior)
        {
            throw new NotImplementedException();
        }
    }
}
