using System;
using System.Collections.Generic;
using System.Text;

namespace bonusoppgave_brusautomat
{
    class BuyDrink : Command
    {
        private Soda _chosenSoda;
        public Sodamachine sodamachine;
        public BuyDrink(Sodamachine Sodamachine) : base(Sodamachine)
        {
            sodamachine = Sodamachine;
        }

        public override void DoCommand()
        {
            var price = _chosenSoda._price;
            if (EnoughMoney(price))
            {
                sodamachine._moneyInMachine -= price;
                Console.WriteLine($"Bought {_chosenSoda._name}");
            }
            else
            {
                Console.WriteLine("Not enough money");
            }
        }

        private bool EnoughMoney(int price)
        {
            return price < sodamachine._moneyInMachine;
        }

        public void ChooseSoda(int index)
        {
            _chosenSoda = sodamachine._sodas[index];
        }
    }
}
