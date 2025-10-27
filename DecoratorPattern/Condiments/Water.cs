using DecoratorPattern.Beverages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.Condiments
{
    internal class Water : CondimentDecorator
    {
        private double mainCost = 0.05;

        public Water(Beverage beverage)
        {
            this.baseBeverage = beverage;
        }

        public override double cost()
        {
            double totalCost = 0.0;
            switch (Size)
            {
                case Size.TALL:
                    totalCost = baseBeverage.cost() - mainCost;
                    break;
                case Size.GRANDE:
                    totalCost = baseBeverage.cost() + mainCost;
                    break;
                case Size.VENDI:
                    totalCost = baseBeverage.cost() + (2 * mainCost);
                    break;
                default:
                    totalCost = baseBeverage.cost() + mainCost;
                    break;
            }

            return totalCost;
        }

        public override string GetDescription()
        {
            return baseBeverage.GetDescription() + ", Water";
        }
    }
}
