using AbstractFactory.AbstractProduct;
using System.Collections.Generic;

namespace AbstractFactory.AbstractFactory
{
    abstract class Inventory
    {
        public abstract List<DieselCar> CreateDieselCars();
        public abstract List<PetrolCar> CreatePetrolCars();
        public abstract List<HybridCar> CreateHybridCars();
    }
}
