using System.Collections.Generic;
using System.Linq;
using Adapter.Adaptee;
using Adapter.Interface;

namespace Adapter.Adapter
{
    class Bajaj_Adapter : Bajaj, IVehiclesList
    {
        public List<string> GetAllVehicles()
        {
            List<string> vehiclesList = new List<string>();

            vehiclesList.AddRange(GetBikes().Elements("bike").Select(a => a.Value).ToList());

            return vehiclesList;
        }
    }
}
