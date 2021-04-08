using System;
using System.Collections.Generic;
using System.Text;

namespace bonusoppgave_brusautomat
{
    class Sodamachine
    {
        public int _moneyInMachine = 100;
        public List<Soda> _sodas;
        

        public Sodamachine(List<Soda> sodas)
        {
            _sodas = sodas;
        }

    }
}
