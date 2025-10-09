using FactoryPattern.Interfaces.Factories;
using FactoryPattern.Beverages;

namespace FactoryPattern.Stores
{
    internal class BeverageStore : Store
    {
        public Beverage OrderBeverage(string type, string size = "")
        {
            Beverage beverage = _factory.CreateBeverage(type);
            beverage.SetSize(size);

            Console.WriteLine(beverage.GetDescription() + " €" +  beverage.cost().ToString("#.##"));

            return beverage;
        }
    }
}