using System;

namespace VehiclesApp
{
    class Airplane : Vehicle
    {

        public Airplane(string registrationId)
        {
            this.registrationNumber = registrationId;
            this.vehicleType = "Airplane";
            this.vehicleBehavior = new DoNothing();

        }
       
        public override void SetVehicleBehavior(ICapability behavior)
        {
            this.vehicleBehavior = behavior;
        }
        public override void DisplayDetails()
        {
            Console.WriteLine("Current status of the airplane: ");
            Console.WriteLine($"Registration number: {this.registrationNumber}");
            vehicleBehavior.CurrentCapability();
        }

    }
}
