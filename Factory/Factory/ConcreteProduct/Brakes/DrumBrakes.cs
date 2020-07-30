using System;
using Factory.Product;

namespace Factory.ConcreteProduct
{
    class DrumBrakes : Brakes
    {
        public override void Brake()
        {
            Console.WriteLine("Brake with Drum Brakes");
        }
    }
}
