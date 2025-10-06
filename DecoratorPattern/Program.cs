using Bev = DecoratorPattern.Beverages;
using Con = DecoratorPattern.Condiments;

namespace DecoratorPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Bev::Beverage Espresso = new Bev::Espresso();
            PrintBeverage(Espresso);

            Bev::Beverage Doppio = new Bev::Espresso();
            Doppio = new Con::Espresso(Doppio);
            PrintBeverage(Doppio);

            Bev::Beverage Lungo = new Bev::Espresso();
            Lungo = new Con::Water(Lungo);
            PrintBeverage(Lungo);

            Bev::Beverage Macchiato = new Bev::Espresso();
            Macchiato = new Con::MilkFoam(Macchiato);
            PrintBeverage(Macchiato);

            Bev::Beverage Corretta = new Bev::Espresso();
            Corretta = new Con::Liqour(Corretta);
            PrintBeverage(Corretta);

            Bev::Beverage ConPanna = new Bev::Espresso();
            ConPanna = new Con::Whip(ConPanna);
            PrintBeverage(ConPanna);

            Bev::Beverage Cappucinno = new Bev::Espresso();
            Cappucinno = new Con::SteamedMilk(Cappucinno);
            Cappucinno = new Con::MilkFoam(Cappucinno);
            PrintBeverage(Cappucinno);

            Bev::Beverage Americano = new Bev::Espresso();
            Americano = new Con::Water(Americano);
            Americano = new Con::Water(Americano);
            PrintBeverage(Americano);

            Bev::Beverage CafféLatte = new Bev::Espresso();
            CafféLatte = new Con::SteamedMilk(CafféLatte);
            CafféLatte = new Con::SteamedMilk(CafféLatte);
            CafféLatte = new Con::MilkFoam(CafféLatte);
            PrintBeverage(CafféLatte);

            Bev::Beverage FlatWhite = new Bev::Espresso();
            FlatWhite = new Con::SteamedMilk(FlatWhite);
            FlatWhite = new Con::SteamedMilk(FlatWhite);
            PrintBeverage(FlatWhite);

            Bev::Beverage Romana = new Bev::Espresso();
            Romana = new Con::Lemon(Romana);
            PrintBeverage(Romana);

            Bev::Beverage Morocchino = new Bev::Espresso();
            Morocchino = new Con::Chocolate(Morocchino);
            Morocchino = new Con::MilkFoam(Morocchino);
            PrintBeverage(Morocchino);

            Bev::Beverage Mocha = new Bev::Espresso();
            Mocha = new Con::Chocolate(Mocha);
            Mocha = new Con::SteamedMilk(Mocha);
            Mocha = new Con::Whip(Mocha);
            PrintBeverage(Mocha);

            Bev::Beverage Bicerin = new Bev::Espresso();
            Bicerin = new Con::BlackChocolate(Bicerin);
            Bicerin = new Con::WhiteChocolate(Bicerin);
            Bicerin = new Con::Whip(Bicerin);
            PrintBeverage(Bicerin);

            Bev::Beverage Breve = new Bev::Espresso();
            Breve = new Con::MilkFoam(Breve);
            Breve = new Con::HalfMilk(Breve);
            PrintBeverage(Breve);

            Bev::Beverage RafCoffee = new Bev::Espresso();
            RafCoffee = new Con::VanillaSugar(RafCoffee);
            RafCoffee = new Con::Cream(RafCoffee);
            PrintBeverage(RafCoffee);

            Bev::Beverage MeadRaf = new Bev::Espresso();
            MeadRaf = new Con::Honey(MeadRaf);
            MeadRaf = new Con::Cream(MeadRaf);
            PrintBeverage(MeadRaf);

            Bev::Beverage Galao = new Bev::Espresso();
            Galao = new Con::MilkFoam(Galao);
            Galao = new Con::MilkFoam(Galao);
            PrintBeverage(Galao);

            Bev::Beverage CafféAffogato = new Bev::Espresso();
            CafféAffogato = new Con::Espresso(CafféAffogato);
            CafféAffogato = new Con::IceCream(CafféAffogato);
            PrintBeverage(CafféAffogato);

            Bev::Beverage ViennaCoffee = new Bev::Espresso();
            ViennaCoffee = new Con::Espresso(ViennaCoffee);
            ViennaCoffee = new Con::Whip(ViennaCoffee);
            ViennaCoffee = new Con::Whip(ViennaCoffee);
            PrintBeverage(ViennaCoffee);

            Bev::Beverage Glace = new Bev::Espresso();
            Glace = new Con::IceCream(Glace);
            PrintBeverage(Glace);

            Bev::Beverage ChocolateMilk = new Bev::Espresso();
            ChocolateMilk = new Con::Milk(ChocolateMilk);
            ChocolateMilk = new Con::Milk(ChocolateMilk);
            PrintBeverage(ChocolateMilk);

            Bev::Beverage DemiCreme = new Bev::Espresso();
            DemiCreme = new Con::Espresso(DemiCreme);
            DemiCreme = new Con::Cream(DemiCreme);
            DemiCreme = new Con::Cream(DemiCreme);
            PrintBeverage(DemiCreme);

            Bev::Beverage LatteMacchiato = new Bev::Espresso();
            LatteMacchiato = new Con::SteamedMilk(LatteMacchiato);
            LatteMacchiato = new Con::SteamedMilk(LatteMacchiato);
            LatteMacchiato = new Con::MilkFoam(LatteMacchiato);
            PrintBeverage(LatteMacchiato);

            Bev::Beverage Freddo = new Bev::Espresso();
            Freddo = new Con::Liqour(Freddo);
            Freddo = new Con::Ice(Freddo);
            PrintBeverage(Freddo);

            Bev::Beverage Frappuccino = new Bev::Espresso();
            Frappuccino = new Con::Ice(Frappuccino);
            Frappuccino = new Con::SteamedMilk(Frappuccino);
            Frappuccino = new Con::Whip(Frappuccino);
            PrintBeverage(Frappuccino);

            Bev::Beverage CaramelFrappuccino = new Bev::Espresso();
            CaramelFrappuccino = new Con::Ice(CaramelFrappuccino);
            CaramelFrappuccino = new Con::SteamedMilk(CaramelFrappuccino);
            CaramelFrappuccino = new Con::Cream(CaramelFrappuccino);
            CaramelFrappuccino = new Con::Syrup(CaramelFrappuccino);
            PrintBeverage(CaramelFrappuccino);

            Bev::Beverage Frappe = new Bev::Espresso();
            Frappe = new Con::SteamedMilk(Frappe);
            Frappe = new Con::SteamedMilk(Frappe);
            Frappe = new Con::IceCream(Frappe);
            PrintBeverage(Frappe);

            Bev::Beverage IrishCoffee = new Bev::Espresso();
            IrishCoffee = new Con::Espresso(IrishCoffee);
            IrishCoffee = new Con::Whiskey(IrishCoffee);
            IrishCoffee = new Con::Whip(IrishCoffee);
            PrintBeverage(IrishCoffee);





            Bev::Beverage VendiIrishCoffee = new Bev::Espresso();
            VendiIrishCoffee.SetSize("vendi");
            VendiIrishCoffee = new Con::Espresso(VendiIrishCoffee);
            VendiIrishCoffee = new Con::Whiskey(VendiIrishCoffee);
            VendiIrishCoffee = new Con::Whip(VendiIrishCoffee);
            PrintBeverage(VendiIrishCoffee);

        }

        static void PrintBeverage(Bev::Beverage beverage)
        {
            Console.WriteLine(beverage.GetDescription() + " €" +  beverage.cost().ToString("#.##"));
        }
    }
}