namespace Builder.Builder
{
    public interface IVehicle
    {
        void Start();
        void Stop();
        void Accelerate();
        void Brake();
        void Direction(); //forward || backwards
        void Steer(); //control directions left || right
    }
}
