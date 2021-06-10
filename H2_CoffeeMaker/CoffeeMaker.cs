using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H2_CoffeeMaker
{
    public class CoffeeMaker : Machine
    {
        // This class is responsible for the object class "CoffeMaker"

        private int _waterContainerInMl;
        private int _groundCoffeeContainerInGram;
        private int _pitcherContainereInMl;
        private bool _coffeeFilterInContainer;

        public int WaterContainerInMl
        {
            get
            {
                return this._waterContainerInMl;
            }
            set
            {
                this._waterContainerInMl = value;
            }
        }

        public int GroundCoffeeContainerInGram
        {
            get
            {
                return this._groundCoffeeContainerInGram;
            }
            set
            {
                this._groundCoffeeContainerInGram = value;
            }
        }

        public int PitcherContainerInMl
        {
            get
            {
                return this._pitcherContainereInMl;
            }
            set
            {
                this._pitcherContainereInMl = value;
            }
        }

        public bool CoffeeFilterInContainer
        {
            get
            {
                return this._coffeeFilterInContainer;
            }
            set
            {
                this._coffeeFilterInContainer = value;
            }
        }

        public CoffeeMaker(int waterContainerInMl, int groundCoffeeContainerInGram, int pitcherContainerInMl, bool coffeeFilterInContainer, bool hasElectricity, bool turnedOn) : base(hasElectricity, turnedOn)
        {
            WaterContainerInMl = waterContainerInMl;
            GroundCoffeeContainerInGram = groundCoffeeContainerInGram;
            PitcherContainerInMl = pitcherContainerInMl;
            CoffeeFilterInContainer = coffeeFilterInContainer;
        }

        public void AddWater()
        {
            WaterContainerInMl += 200;
            Console.WriteLine("Added water for 1 cup of coffee. (200ml)");
        }

        public void AddGroundCoffee()
        {
            if (CoffeeFilterInContainer == true)
            {
                GroundCoffeeContainerInGram += 10;
                Console.WriteLine("Added ground beans for 1 cup of coffee. (10 grams)");
            }
            else
            {
                Console.WriteLine("No filter in the container. Ground beans went directly through and into the pitcher.");
            }
        }

        public void BrewCoffee()
        {
            if (TurnedOn == true)
            {
                Console.WriteLine("Coffee is brewing");
                
                for (int i = WaterContainerInMl; i > 0; i -= 200)
                {
                    WaterContainerInMl -= 200;
                    GroundCoffeeContainerInGram -= 10;
                    PitcherContainerInMl += 200;

                    Console.WriteLine("Coffee for 1 cup is added to pitcher.");                    
                }

                Console.WriteLine("Coffee is done brewing.");
            }
        }

        public void AddFilter()
        {
            CoffeeFilterInContainer = true;
            Console.WriteLine("Added coffee filter to the container.");
        }
    }
}
