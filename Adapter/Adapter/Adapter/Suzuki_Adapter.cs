using System.Collections.Generic;
using Adapter.Adaptee;
using Adapter.Interface;
using Newtonsoft.Json;

namespace Adapter.Adapter
{
    class Suzuki_Adapter : Suzuki, IVehiclesList
    {
        public List<string> GetAllVehicles()
        {
            List<string> vehiclesList = new List<string>();

            vehiclesList.AddRange(JsonConvert.DeserializeObject<List<string>>(GetVehicles().ToString()));            

            return vehiclesList;
        }
    }
}
