using System;
using Factory.Product;

namespace Factory.ConcreteProduct
{
    class SpokeWheels : Wheels
    {
        public override void Spin()
        {
            Console.WriteLine("Spin with Spoke Wheels");
        }
    }
}
