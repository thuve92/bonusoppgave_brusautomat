using System;
using System.Collections.Generic;
using System.Text;

namespace bonusoppgave_brusautomat
{
    abstract class Command
    {
        private Sodamachine _sodamachine;

        protected Command(Sodamachine sodamachine)
        {
            _sodamachine = sodamachine;
        }

        public abstract void DoCommand();

    }
}
