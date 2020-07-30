using System;
using Adapter.Client;
using Adapter.Adapter;

namespace Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            HotWheels bajaj = new HotWheels(new Bajaj_Adapter());
            bajaj.PrintVehicles();

            HotWheels honda = new HotWheels(new Honda_Adapter());
            honda.PrintVehicles();

            HotWheels suzuki = new HotWheels(new Suzuki_Adapter());
            suzuki.PrintVehicles();

            HotWheels yamaha = new HotWheels(new Yamaha_Adapter());
            yamaha.PrintVehicles();

            //Just to stop the console
            Console.ReadLine();
        }
    }
}
