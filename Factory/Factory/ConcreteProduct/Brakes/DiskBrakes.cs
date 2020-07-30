using System;
using Factory.Product;

namespace Factory.ConcreteProduct
{
    class DiskBrakes : Brakes
    {
        public override void Brake()
        {
            Console.WriteLine("Brake with Disk Brakes");
        }
    }
}
