using System;
using System.Text;
using Builder.Builder;

namespace Builder.Product
{
    abstract class Car : IVehicle
    {        
        public int NoOfTires { get; }
        public int NoOfDoors { get; }
        public int NoOfCylinders { get; }
        public string Type { get; } //Domestic || Sports        

        public Car()
        {
            NoOfTires = 4;
            NoOfDoors = 4;
            NoOfCylinders = 4;
            Type = "Domestic";
        }

        //remember to write optional parameters at the end...reqd. ones have to be listed first
        public Car(int noOfDoors, int noOfCylinders, string type, int noOfTires = 4)
        {
            NoOfTires = noOfTires;
            NoOfDoors = noOfDoors;
            NoOfCylinders = noOfCylinders;
            Type = type;
        }

        public StringBuilder CarProperties()
        {
            StringBuilder properties = new StringBuilder();
            properties.AppendLine();
            properties.AppendLine("Basic Properties:");
            properties.AppendLine("NoOfTires : " + NoOfTires);
            properties.AppendLine("NoOfDoors : " + NoOfDoors);
            properties.AppendLine("NoOfCylinders : " + NoOfCylinders);
            properties.AppendLine("Type : " + Type);

            return properties;
        }

        //Have to implement them as we've inherited IVehicle        
        public abstract void Start();//Leaving + Enforcing it to the derived classes

        public void Stop()
        {
            Console.WriteLine("Stops normally");
        }

        public abstract void Accelerate();//Leaving + Enforcing it to the derived classes

        public void Brake()
        {
            Console.WriteLine("Slows down normally");
        }

        public void Direction()
        {
            Console.WriteLine("Can move Forward or backwards");
        }

        public virtual void Steer()
        {
            Console.WriteLine("Can move left n right");
        }
    }
}
