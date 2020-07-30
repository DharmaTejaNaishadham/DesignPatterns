using AbstractFactory.AbstractFactory;
using AbstractFactory.ConcreteFactory;
using System;
using System.Collections.Generic;

namespace AbstractFactory
{
    class Program
    {
        static void Print<T>(List<T> cars)
        {
            cars.ForEach(car => Console.WriteLine(car.GetType()));
        }

        static void Main(string[] args)
        {
            Console.Write("Enter your country (India - I, America - A): ");
            char input = Console.ReadKey().KeyChar;
            Inventory inventory;
            switch (input)
            {
                case 'I':
                    inventory = new IndiaInventory();
                    break;

                case 'A':
                    inventory = new USAInventory();
                    break;

                default:
                    throw new NotImplementedException();
            }
            Console.WriteLine("\n\n" + inventory.GetType());


            var DieselCars = inventory.CreateDieselCars();
            Console.WriteLine("\nDieselCars");
            Print(DieselCars);

            var HybridCars = inventory.CreateHybridCars();
            Console.WriteLine("\nHybridCars");
            Print(HybridCars);

            var PetrolCars = inventory.CreatePetrolCars();
            Console.WriteLine("\nPetrolCars");
            Print(PetrolCars);

            //Just to stop the console
            Console.ReadLine();
        }
    }
}
