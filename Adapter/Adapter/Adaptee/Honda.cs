using System.Collections.Generic;

namespace Adapter.Adaptee
{
    class Honda
    {
        private readonly List<string> BikesList;
        private readonly List<string> ScootersList;
        private readonly List<string> CarsList;

        public Honda()
        {
            BikesList = new List<string>();
            BikesList.AddRange(new List<string>() { "CBR", "Unicorn" });

            ScootersList = new List<string>();
            ScootersList.AddRange(new List<string>() { "Activa", "Dio" });

            CarsList = new List<string>();
            CarsList.AddRange(new List<string>() { "City", "Accord", "Civic", "CRV" });
        }

        public List<string> GetBikes()
        {
            return BikesList;
        }

        public List<string> GetScooters()
        {
            return ScootersList;
        }

        public List<string> GetCars()
        {
            return CarsList;
        }
    }
}
