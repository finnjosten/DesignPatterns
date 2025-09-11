using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern.Interfaces.QuackBehavior
{
    class ElectronicQuack : QuackBehavior
    {
        public void Quack() {
            Console.WriteLine("Quack beep boop");
        }
    }
}
