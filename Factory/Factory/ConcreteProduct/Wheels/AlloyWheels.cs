using System;
using Factory.Product;

namespace Factory.ConcreteProduct
{
    class AlloyWheels : Wheels
    {
        public override void Spin()
        {
            Console.WriteLine("Spin with Alloy Wheels");
        }
    }
}
