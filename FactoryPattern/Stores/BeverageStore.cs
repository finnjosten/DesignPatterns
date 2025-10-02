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

        public Beverage OrderBeverage(string type, string size = "")
        {
            Beverage beverage = factory.CreateBeverage(type);
            beverage.SetSize(size);

            Console.WriteLine(beverage.GetDescription() + " €" +  beverage.cost().ToString("#.##"));

            return beverage;
        }
    }
}