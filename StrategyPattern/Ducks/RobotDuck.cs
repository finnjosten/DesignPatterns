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
    internal class RobotDuck : Duck
    {
        public RobotDuck() { }
        
        public override void Display()
        {
            Console.WriteLine("I'm a Robot Duck");
        }

        public override void SetFlyBehavior(FlyBehavior flyBehavior)
        {
            this.flyBehavior = new FlyWithRockets();
        }
        public override void SetQuackBehavior(QuackBehavior quackBehavior) {
            this.quackBehavior = new ElectronicQuack();
        }
        public override void SetSwimBehavior(SwimBehavior swimBehavior)
        {
            this.swimBehavior = new Sink();
        }
    }
}
