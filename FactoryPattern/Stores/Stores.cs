using FactoryPattern.Interfaces.Factories;

namespace FactoryPattern.Stores
{
    internal class BeverageStore : Store
    {
        private readonly Factory _factory;

        public BeverageStore(Factory factory)
        {
            _factory = factory;
        }

        public abstract void OrderBeverage(string type);
    }
}