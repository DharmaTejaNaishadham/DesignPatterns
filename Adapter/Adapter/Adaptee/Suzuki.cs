using System.Collections.Generic;
using Newtonsoft.Json;

namespace Adapter.Adaptee
{
    class Suzuki
    {
        private readonly List<string> VehiclesList;

        public Suzuki()
        {
            VehiclesList = new List<string>();
            VehiclesList.AddRange(new List<string>() { "Swift", "Hayabusa" });
        }

        public string GetVehicles()
        {
            var vehicles = JsonConvert.SerializeObject(VehiclesList);

            return vehicles;
        }
    }
}
