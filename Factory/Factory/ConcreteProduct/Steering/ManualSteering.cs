using System;
using Factory.Product;

namespace Factory.ConcreteProduct
{
    class ManualSteering : Steering
    {
        public override void Steer()
        {
            Console.WriteLine("Steer with Manual Steering");
        }
    }
}
