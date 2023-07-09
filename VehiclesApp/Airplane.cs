using System;

namespace VehiclesApp
{
    class Airplane : Vehicle
    {
        public override void Float()
        {
            throw new NotImplementedException();
        }

        public override  void Fly()
        {
            Console.WriteLine("I liek to fly");
        }
    }
}
