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
    internal abstract class Duck
    {
        protected FlyBehavior? flyBehavior;
        protected QuackBehavior? quackBehavior;
        protected SwimBehavior? swimBehavior;

        public abstract void Display();

        public void SetFlyBehavior(FlyBehavior flyBehavior)
        {
            this.flyBehavior = flyBehavior;
        }
        public void SetQuackBehavior(QuackBehavior quackBehavior) {
            this.quackBehavior = quackBehavior;
        }
        public void SetSwimBehavior(SwimBehavior swimBehavior)
        {
            this.swimBehavior = swimBehavior;
        }
        
        public void PerformQuack() { quackBehavior?.Quack(); }
        public void PerformFly()    { flyBehavior?.Fly(); }
        public void PerformSwim()   { swimBehavior?.Swim(); }
    }
}
