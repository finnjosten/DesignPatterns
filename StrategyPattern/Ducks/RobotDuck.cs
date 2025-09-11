﻿using System;
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
        public RobotDuck()
        {
            SetFlyBehavior(new FlyWithRockets());
            SetQuackBehavior(new ElectronicQuack());
            SetSwimBehavior(new Sink());
        }
        
        public override void Display()
        {
            Console.WriteLine("I'm a Robot Duck");
        }
    }
}
