using System;
using Factory.Product;

namespace Factory.ConcreteProduct
{
    class PowerSteering : Steering
    {
        public override void Steer()
        {
            Console.WriteLine("Steer with Power Steering");
        }
    }
}
