using System;

namespace VehiclesApp
{
    class Airplane : IVehicle
    {
        public void Float()
        {
            throw new NotImplementedException();
        }

        public void Fly()
        {
            Console.WriteLine("I liek to fly");
        }
    }
}
