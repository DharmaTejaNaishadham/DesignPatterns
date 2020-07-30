using System;
using System.Collections.Generic;
using System.Text;
using Builder.Product;

namespace Builder.ConcreteBuilder
{
    sealed class SwiftHighEnd : Car
    {
        //Additional Properties
        object BackViper;
        object Bluetooth;
        object SteeringMountedControls;

        public override string ToString()
        {
            StringBuilder properties = new StringBuilder();
            properties = CarProperties();
            properties.AppendLine("\n");
            properties.AppendLine("Printing additional properties of SwiftHighEnd:");
            properties.AppendLine("backViper");
            properties.AppendLine("bluetooth");
            properties.AppendLine("steeringMountedControls");

            return properties.ToString();
        }

        public List<string> AvailableModels { get; }

        //Constructors
        public SwiftHighEnd()
        {
            AvailableModels = new List<string>
            {
                "Petrol",
                "Diesel"
            };

            BackViper = new object();
            Bluetooth = new object();
            SteeringMountedControls = new object();
        }

        public SwiftHighEnd(List<string> availableModels)
        {
            AvailableModels = availableModels;

            BackViper = new object();
            Bluetooth = new object();
            SteeringMountedControls = new object();
        }
        //.....................................

        //Derived Class has to implement the abstract methods of abstract class
        public override void Accelerate()
        {
            Console.WriteLine("5 Gear auto transmission");
        }

        public override void Start()
        {
            Console.WriteLine("Button Start");
        }
        //.....................................

        //Methods particular to SwiftHighEnd
        public void BackViperWorking()
        {
            Console.WriteLine("backViper works");
        }

        public void BluetoothWorking()
        {
            Console.WriteLine("bluetooth works");
        }

        public void SteeringMountedControlsWorking()
        {
            Console.WriteLine("steeringMountedControls work");
        }
    }
}
