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
            Contestant c2 = Creation.CreateNewContestant();
            Contestant c3 = Creation.CreateNewContestant();
            Contestant c4 = Creation.CreateNewContestant();
            Contestant c5 = Creation.CreateNewContestant();

            sweep.RegisterContestant(c1);
            sweep.RegisterContestant(c2);
            sweep.RegisterContestant(c3);
            sweep.RegisterContestant(c4);
            sweep.RegisterContestant(c5);

            sweep.PickWinner();

            firm.manager.GetSweepstakes();

            Console.ReadLine();
        }
    }
}
