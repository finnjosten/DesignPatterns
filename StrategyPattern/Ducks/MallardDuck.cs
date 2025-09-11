using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using StrategyPattern.Interfaces.FlyBehavior;
using StrategyPattern.Interfaces.QuackBehavior;
using StrategyPattern.Interfaces.SwimBehavior;

namespace StrategyPattern.Ducks
{
    internal class MallardDuck : Duck
    {
        public MallardDuck() { }
        
        public override void Display()
        {
            Console.WriteLine("I'm a Mallard Duck");
        }

        public override void SetFlyBehavior(FlyBehavior flyBehavior)
        {
            this.flyBehavior = new FlyWithWings();
        }
        public override void SetQuackBehavior(QuackBehavior quackBehavior) {
            this.quackBehavior = new RegularQuack();
        }
        public override void SetSwimBehavior(SwimBehavior swimBehavior)
        {
            this.swimBehavior = new Float();
        }
    }
}
