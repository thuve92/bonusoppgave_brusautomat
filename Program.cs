using System;
using System.Collections.Generic;

namespace bonusoppgave_brusautomat
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Soda> sodas = new List<Soda>()
            {
                new Fanta(19, "330 ml"),
                new CocaCola(19, "330 ml"),
                new Urge(23, "330 ml"),
            };
        }
    }
}
