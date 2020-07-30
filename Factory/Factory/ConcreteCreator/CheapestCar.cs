using Factory.Creator;
using Factory.ConcreteProduct;

namespace Factory.ConcreteCreator
{
    class CheapestCar : Car
    {
        public override void BuildCar()
        {
            Brakes = new DrumBrakes();
            Engine = new PetrolEngine();
            Steering = new ManualSteering();
            Transmission = new ManualTransmission();
            Wheels = new SpokeWheels();
        }
    }
}
