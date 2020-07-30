using System;
using Factory.Product;

namespace Factory.ConcreteProduct
{
    class AutomaticTransmission : Transmission
    {
        public override void Shift()
        {
            Console.WriteLine("Shift with Auto transmissions");
        }
    }
}
