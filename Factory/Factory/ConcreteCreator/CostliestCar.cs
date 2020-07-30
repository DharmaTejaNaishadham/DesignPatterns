using Factory.Creator;
using Factory.ConcreteProduct;

namespace Factory.ConcreteCreator
{
    class CostliestCar : Car
    {
        public override void BuildCar()
        {
            Brakes = new DiskBrakes();
            Engine = new DieselEngine();
            Steering = new PowerSteering();
            Transmission = new AutomaticTransmission();
            Wheels = new AlloyWheels();
        }
    }
}
