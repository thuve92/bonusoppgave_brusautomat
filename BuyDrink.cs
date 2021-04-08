using System;
using System.Collections.Generic;
using System.Text;

namespace bonusoppgave_brusautomat
{
    class BuyDrink : Command
    {
        private Soda _chosenSoda;

        public Sodamachine Sodamachine;
        public BuyDrink(Sodamachine sodamachine) : base(sodamachine)
        {
            this.Sodamachine = sodamachine;
        }

        public override void DoCommand()
        {
            var price = _chosenSoda._price;
            if (EnoughMoney(price))
            {
                Sodamachine._moneyInMachine -= price;
                Console.WriteLine($"Bought {_chosenSoda._name}");
            }
            else
            {
                Console.WriteLine("Not enough money");
            }
        }

        private bool EnoughMoney(int price)
        {
            return price < Sodamachine._moneyInMachine;
        }

        public void ChooseSoda(int index)
        {
            _chosenSoda = Sodamachine._sodas[index];
        }
    }
}
