using System.Collections.Generic;
using Adapter.Adaptee;
using Adapter.Interface;

namespace Adapter.Adapter
{
    class Honda_Adapter : Honda, IVehiclesList
    {
        public List<string> GetAllVehicles()
        {
            List<string> vehiclesList = new List<string>();

            vehiclesList.AddRange(GetBikes());
            vehiclesList.AddRange(GetScooters());
            vehiclesList.AddRange(GetCars());

            return vehiclesList;
        }
    }
}
