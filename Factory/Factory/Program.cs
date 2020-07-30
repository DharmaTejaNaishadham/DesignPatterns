using System;
using Factory.Creator;
using Factory.ConcreteCreator;

namespace Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            ///////////////////////////////////////////////////////////////////////////
            Console.WriteLine("/////////////Cheapest Car/////////////////////////////");
            Car cheapestCar = new CheapestCar();
            cheapestCar.DescribeCar();
            Console.WriteLine("//////////////////////////////////////////////////////");
            ///////////////////////////////////////////////////////////////////////////
            Console.WriteLine("/////////////Costliest Car////////////////////////////");
            Car costliestCar = new CostliestCar();
            costliestCar.DescribeCar();
            Console.WriteLine("//////////////////////////////////////////////////////");
            ///////////////////////////////////////////////////////////////////////////


            //Just to stop the console
            Console.ReadLine();
        }
    }
}
