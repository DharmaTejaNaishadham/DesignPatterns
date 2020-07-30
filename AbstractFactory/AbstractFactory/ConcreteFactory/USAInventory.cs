using AbstractFactory.AbstractFactory;
using AbstractFactory.AbstractProduct;
using AbstractFactory.ConcreteProduct;
using System.Collections.Generic;

namespace AbstractFactory.ConcreteFactory
{
    class USAInventory : Inventory
    {
        public override List<DieselCar> CreateDieselCars()
        {
            return new List<DieselCar>();
        }

        public override List<HybridCar> CreateHybridCars()
        {
            return new List<HybridCar>() { new Accord_Hybrid() };
        }

        public override List<PetrolCar> CreatePetrolCars()
        {
            return new List<PetrolCar>() { new Accord_Petrol(), new Civic_Petrol(), new CR_V_Petrol(), new HR_V_Petrol() };
        }
    }
}
