using System;
using System.Text;
using Builder.Product;

namespace Builder.ConcreteBuilder
{
    sealed class FordMustangGT : Car
    {
        object NitrousOxide;

        public override string ToString()
        {
            StringBuilder properties = new StringBuilder();
            properties = CarProperties();
            properties.AppendLine("\n");
            properties.AppendLine("Printing additional properties of FordMustangGT:");
            properties.AppendLine("Nitrous Oxide");

            return properties.ToString();
        }

        //Constrcutor
        public FordMustangGT() : base(2, 8, "Sports")
        {
            NitrousOxide = new object();
        }

        //Derived Class has to implement the abstract methods of abstract class
        public override void Accelerate()
        {
            Console.WriteLine("6 Gears auto + manual transmission");
        }

        public override void Start()
        {
            Console.WriteLine("Button Start");
        }
        //.....................................

        //Overriding one of the base class method
        public override void Steer()
        {
            base.Steer();
            Console.WriteLine("Also has a self driven mode");
        }

        //Methods particular to SwiftHighEnd
        public void NitrousOxideWorking()
        {
            Console.WriteLine("NitrousOxide works");
        }
    }
}
