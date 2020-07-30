using System;
using Builder.Director;
using Builder.Builder;
using Builder.ConcreteBuilder;
using System.Collections.Generic;

namespace Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            VehicleCreator vehicleCreator = null;

            //we can use var instead of dynamic...var cannot be initialized to null
            //However, var will let you figure out mistakes during compile time
            //Need to be careful with Typos while using dynamic
            dynamic car = null;

            ////////////////////////////////////////////
            Console.WriteLine("//////////////////SwiftLowEnd//////////////////////////");
            vehicleCreator = new VehicleCreator(new SwiftLowEnd());
            vehicleCreator.GetFunctions();
            IVehicle swiftLowEnd = vehicleCreator.GetVehicle();
            car = (SwiftLowEnd)swiftLowEnd;

            //public properties            
            Console.WriteLine(car.ToString());//Overrided ToString()   
            Console.WriteLine("\nAvailbale models: {0}", car.AvailableModel);            
            Console.WriteLine("///////////////////////////////////////////////////////\n\n");
            ////////////////////////////////////////////


            ////////////////////////////////////////////
            Console.WriteLine("//////////////////SwiftMidVariant///////////////////////");
            vehicleCreator = new VehicleCreator(new SwiftMidVariant());
            vehicleCreator.GetFunctions();
            IVehicle swiftMidVariant = vehicleCreator.GetVehicle();
            car = (SwiftMidVariant)swiftMidVariant;

            //public properties            
            Console.WriteLine(car.ToString());//Overrided ToString()   
            Console.WriteLine("\nAvailbale models: {0}", car.AvailableModel);
            Console.WriteLine("///////////////////////////////////////////////////////\n\n");
            ////////////////////////////////////////////


            ////////////////////////////////////////////
            Console.WriteLine("///////////////////SwiftHighEnd////////////////////////");
            List<string> availableModels = new List<string>
            {
                "Petrol",
                "Diesel",
                "Hybrid - Petrol + CNG"
            };
            vehicleCreator = new VehicleCreator(new SwiftHighEnd(availableModels));
            vehicleCreator.GetFunctions();
            IVehicle swiftHighEnd = vehicleCreator.GetVehicle();
            car = (SwiftHighEnd)swiftHighEnd;

            //public properties
            Console.WriteLine(car.ToString());//Overrided ToString()   
            Console.WriteLine("\nAvailbale models:");
            foreach (string model in car.AvailableModels)
            {
                Console.WriteLine(model);
            }

            //SwiftHighEnd special ones
            Console.WriteLine("\nSpecial functions:");
            car.BackViperWorking();
            car.BluetoothWorking();
            car.SteeringMountedControlsWorking();
            Console.WriteLine("///////////////////////////////////////////////////////\n\n");
            ////////////////////////////////////////////


            ////////////////////////////////////////////
            Console.WriteLine("///////////////////FordMustangGT////////////////////////");
            vehicleCreator = new VehicleCreator(new FordMustangGT());
            vehicleCreator.GetFunctions();
            IVehicle fordMustangGT = vehicleCreator.GetVehicle();
            car = (FordMustangGT)fordMustangGT;

            //public properties
            Console.WriteLine(car.ToString());//Overrided ToString()   

            //FordMustangGT special ones
            Console.WriteLine("\nSpecial functions:");
            car.NitrousOxideWorking();
            Console.WriteLine("///////////////////////////////////////////////////////\n\n");
            ////////////////////////////////////////////


            //Just to stop the console
            Console.ReadLine();
        }
    }
}
