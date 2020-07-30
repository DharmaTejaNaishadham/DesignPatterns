using System.Collections.Generic;

namespace Adapter.Adaptee
{
    class Yamaha
    {
        private readonly List<string> BikesList;

        public Yamaha()
        {
            BikesList = new List<string>();
            BikesList.AddRange(new List<string>() { "R15", "FZ" });
        }

        public string[] GetInventory()
        {
            return BikesList.ToArray();
        }
    }
}
