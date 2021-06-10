using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H2_CoffeeMaker
{
    public abstract class Machine
    {
        // This class is responsible for the abstract object class machine

        private bool _hasElectricity;
        private bool _turnedOn;

        public bool HasElectricity
        {
            get
            {
                return this._hasElectricity;
            }
            set
            {
                this._hasElectricity = value;
            }
        }

        public bool TurnedOn
        {
            get
            {
                return this._turnedOn;
            }
            set
            {
                this._turnedOn = value;
            }
        }

        public Machine(bool hasElectricity, bool turnedOn)
        {
            HasElectricity = hasElectricity;
            TurnedOn = turnedOn;
        }

        public void TurnOn()
        {
            if (HasElectricity == true)
            {
                TurnedOn = true;
                Console.WriteLine("Turned on");
            }
        }

        public void TurnOff()
        {
            TurnedOn = false;
            Console.WriteLine("Turned off");
        }
    }
}
