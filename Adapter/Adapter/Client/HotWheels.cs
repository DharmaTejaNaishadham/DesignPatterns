using System;
using Adapter.Interface;

namespace Adapter.Client
{
    class HotWheels
    {
        private readonly IVehiclesList _vehiclesList;

        public HotWheels(IVehiclesList vehiclesList)
        {
            _vehiclesList = vehiclesList;
        }

        public void PrintVehicles()
        {
            var vehiclesList = _vehiclesList.GetAllVehicles();

            Console.WriteLine("Vehicles List:({0})", _vehiclesList.GetType().ToString());
            foreach(string vehicle in vehiclesList)
            {
                Console.WriteLine(vehicle);
            }
        }

    }
}
