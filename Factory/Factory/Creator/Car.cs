using Factory.Product;

namespace Factory.Creator
{
    abstract class Car
    {
        public Brakes Brakes { get; set; }
        public Engine Engine { get; set; }
        public Steering Steering { get; set; }
        public Transmission Transmission { get; set; }
        public Wheels Wheels { get; set; }

        public Car()
        {
            BuildCar();
        }

        public abstract void BuildCar();

        public void DescribeCar()
        {
            Brakes.Brake();
            Engine.Run();
            Steering.Steer();
            Transmission.Shift();
            Wheels.Spin();
        }
    }
}
