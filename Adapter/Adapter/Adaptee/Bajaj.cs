using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;

namespace Adapter.Adaptee
{
    class Bajaj
    {
        private readonly List<string> BikesList;

        public Bajaj()
        {
            BikesList = new List<string>();
            BikesList.AddRange(new List<string>() { "Pulsar", "Dominar", "Avenger" });
        }

        public XElement GetBikes()
        {
            var xElement = new XElement("bikes", BikesList.Select(a => new XElement("bike", a)));

            return xElement;
        }
    }
}
