namespace Singleton
{
    internal class Program
    {
        static void Main(string[] args)
        {

            ChocolateBoiler boiler1 = ChocolateBoiler.getInstance();
            ChocolateBoiler boiler2 = ChocolateBoiler.getInstance();

            if (boiler1 == boiler2) {
                Console.WriteLine("Both are same instance");
            } else {
                Console.WriteLine("Different instances");
            }

            boiler1.fill();
            boiler1.boil();
            boiler1.drain();

            Console.WriteLine("Boiler 1 - is empty: {0}, is boiled: {1}", boiler1.IsEmpty, boiler1.IsBoiled);
            Console.WriteLine("Boiler 2 - is empty: {0}, is boiled: {1}", boiler2.IsEmpty, boiler2.IsBoiled);
        }
    }
}