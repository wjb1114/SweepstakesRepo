using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    class Program
    {
        static void Main(string[] args)
        {
            MarketingFirm firm = new MarketingFirm();
            Sweepstakes sweep = Creation.CreateSweepstakes();
            firm.manager.InsertSweepstakes(sweep);

            Contestant c1 = Creation.CreateNewContestant();

            sweep.RegisterContestant(c1);

            sweep.PickWinner();

            firm.manager.GetSweepstakes();

            Console.ReadLine();
        }
    }
}
