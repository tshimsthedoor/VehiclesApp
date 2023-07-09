using System;

namespace VehiclesApp
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("*********** Vehicles demo. ***********");
                Vehicle vehicle = new Boat("B0002");
                vehicle.DisplayDetails();
                Console.WriteLine("**************************************");

                ICapability currentCapability = new FloatCapability();
                vehicle.SetVehicleBehavior(currentCapability);
                vehicle.DisplayDetails();
                Console.WriteLine("**************************************");

                vehicle = new Airplane("A0005");
                currentCapability = new FlyCapability();
                vehicle.SetVehicleBehavior(currentCapability);
                vehicle.DisplayDetails();
                Console.WriteLine("***************************************");

                Console.WriteLine("Adding float behavior to the airplane.");
                // Adding float capability to an airplane
                currentCapability = new FloatCapability();
                vehicle.SetVehicleBehavior(currentCapability);
                vehicle.DisplayDetails();
                Console.WriteLine("****************************************");
                Console.ReadKey();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex}");
                
            }
        }
    }
}
