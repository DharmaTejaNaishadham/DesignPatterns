using System;
using System.Text;
using Builder.Product;

namespace Builder.ConcreteBuilder
{
    class SwiftLowEnd : Car
    {
        public string AvailableModel { get; }

        public SwiftLowEnd()
        {
            AvailableModel = "Petrol";
        }

        public override string ToString()
        {
            StringBuilder properties = new StringBuilder();
            properties = CarProperties();
            properties.AppendLine("\n");
            properties.AppendLine("Printing additional properties of SwiftLowEnd:");
            properties.AppendLine("basic car...emi evatle extra :p");

            return properties.ToString();
        }

        //Derived Class has to implement the abstract methods of abstract class
        public override void Accelerate()
        {
            Console.WriteLine("5 Gear manual transmission");
        }

        public override void Start()
        {
            Console.WriteLine("Key Start");
        }
    }
}
