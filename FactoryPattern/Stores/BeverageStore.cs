using FactoryPattern.Interfaces.Factories;
using FactoryPattern.Beverages;

namespace FactoryPattern.Stores
{
    internal class BeverageStore
    {
        private BeverageFactory factory;
        public BeverageStore(BeverageFactory factory)
        {
            this.factory = factory;
        }

        public Beverage OrderBeverage(string type)
        {
            Beverage beverage = factory.CreateBeverage(type);

            Console.WriteLine("\n");
            Console.WriteLine(beverage.GetDescription() + " €" +  beverage.cost().ToString("#.##"));

            return beverage;
        }
    }
}