using StrategyPattern.Ducks;
using StrategyPattern.Interfaces.FlyBehavior;

namespace StrategyPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Duck mallardDuck = new MallardDuck();
            Duck redheadDuck = new RedheadDuck();
            Duck decoyDuck = new DecoyDuck();
            Duck rubberDuck = new RubberDuck();
            Duck robotDuck = new RobotDuck();

            System.Console.Clear();
            System.Console.WriteLine("\n\n");
            mallardDuck.Display();
            mallardDuck.PerformSwim();
            mallardDuck.PerformFly();
            mallardDuck.PerformQuack();

            System.Console.WriteLine("\n\n");
            redheadDuck.Display();
            redheadDuck.PerformSwim();
            redheadDuck.PerformFly();
            redheadDuck.PerformQuack();

            System.Console.WriteLine("\n\n");
            decoyDuck.Display();
            decoyDuck.PerformSwim();
            decoyDuck.PerformFly();
            decoyDuck.PerformQuack();

            System.Console.WriteLine("\n\n");
            rubberDuck.Display();
            rubberDuck.PerformSwim();
            rubberDuck.PerformFly();
            rubberDuck.PerformQuack();


            System.Console.WriteLine("\n\n");
            robotDuck.Display();
            robotDuck.PerformSwim();
            robotDuck.PerformFly();
            robotDuck.PerformQuack();
        }
    }
}