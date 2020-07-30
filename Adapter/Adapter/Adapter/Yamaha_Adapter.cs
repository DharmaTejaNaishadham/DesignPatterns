using System.Collections.Generic;
using Adapter.Adaptee;
using Adapter.Interface;

namespace Adapter.Adapter
{
    class Yamaha_Adapter : Yamaha, IVehiclesList
    {
        public List<string> GetAllVehicles()
        {
            List<string> vehiclesList = new List<string>();

            vehiclesList.AddRange(GetInventory());

            return vehiclesList;
        }
    }
}
