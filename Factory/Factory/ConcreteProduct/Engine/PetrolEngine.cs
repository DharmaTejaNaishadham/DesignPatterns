using System;
using Factory.Product;

namespace Factory.ConcreteProduct
{
    class PetrolEngine : Engine
    {
        public override void Run()
        {
            Console.WriteLine("Run with Petrol Engine");
        }
    }
}
