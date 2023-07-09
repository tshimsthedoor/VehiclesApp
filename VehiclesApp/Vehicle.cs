using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehiclesApp
{
    abstract class Vehicle
    {
        
        protected string vehicleType;
        protected ICapability vehicleBehavior;
        protected string registrationNumber = String.Empty;
        public abstract void SetVehicleBehavior(ICapability behavior);
        public abstract void DisplayDetails();
    }
}
