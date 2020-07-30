using System;
using Builder.Builder;

namespace Builder.Director
{
    class VehicleCreator
    {
        private readonly IVehicle vehicle;

        public VehicleCreator(IVehicle vehicle)
        {
           this.vehicle = vehicle;
        }

        public IVehicle GetVehicle()
        {
            return vehicle;
        }

        public void GetFunctions()
        {
            Console.WriteLine("Basic functions:");
            vehicle.Start();
            vehicle.Stop();
            vehicle.Accelerate();
            vehicle.Brake();
            vehicle.Direction();
            vehicle.Steer();
        }
    }
}
