using System;

namespace H2_CoffeeMaker
{
    class Program
    {
        static void Main(string[] args)
        {
            CoffeeMaker siemensCoffeeMaker = new CoffeeMaker(0,0,0, false, true, false);

            siemensCoffeeMaker.AddWater();
            siemensCoffeeMaker.AddGroundCoffee();
            siemensCoffeeMaker.AddFilter();
            siemensCoffeeMaker.AddGroundCoffee();
            siemensCoffeeMaker.TurnOn();
            siemensCoffeeMaker.BrewCoffee();
            siemensCoffeeMaker.TurnOff();
        }
    }
}
