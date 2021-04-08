using System;
using System.Collections.Generic;
using System.Text;

namespace bonusoppgave_brusautomat
{
    internal abstract class Command
    {
        public Sodamachine Sodamachine { get; }

        protected Command(Sodamachine sodamachine)
        {
            Sodamachine = sodamachine;
        }

        public abstract void DoCommand();

    }
}
