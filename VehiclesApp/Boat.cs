using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehiclesApp
{
    class Boat : Vehicle
    {
        

        public Boat(string registrationId)
        {
            this.registrationNumber = registrationId;
            this.vehicleType = "Boat";
            this.vehicleBehavior = new DoNothing();
        }
        public override void DisplayDetails()
        {
            Console.WriteLine("Current status of the boat: ");
        }

        public override void SetVehicleBehavior(ICapability behavior)
        {
            this.vehicleBehavior = behavior;
        }
    }
}
