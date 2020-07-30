using System;
using Factory.Product;

namespace Factory.ConcreteProduct
{
    class ManualTransmission : Transmission
    {
        public override void Shift()
        {
            Console.WriteLine("Shift with Manual transmissions");
        }
    }
}
