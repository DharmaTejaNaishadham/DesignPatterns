using System;
using Factory.Product;

namespace Factory.ConcreteProduct
{
    class DieselEngine : Engine
    {
        public override void Run()
        {
            Console.WriteLine("Run with Diesel Engine");
        }
    }
}
