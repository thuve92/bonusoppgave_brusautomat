using System;
using System.Collections.Generic;
using System.Text;

namespace bonusoppgave_brusautomat
{
    abstract class Command
    {
        private Sodamachine sodamachine;

        protected Command(Sodamachine sodamachine)
        {
            this.sodamachine = sodamachine;
        }

        public abstract void DoCommand();

    }
}
