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
            MarketingFirm firm1 = new MarketingFirm();
            MarketingFirm firm2 = new MarketingFirm();
            Sweepstakes sweep1 = Creation.CreateSweepstakes();
            Sweepstakes sweep2 = Creation.CreateSweepstakes();
            Sweepstakes sweep3 = Creation.CreateSweepstakes();
            Sweepstakes sweep4 = Creation.CreateSweepstakes();
            Sweepstakes sweep5 = Creation.CreateSweepstakes();
            Contestant c1 = Creation.CreateNewContestant();
            Contestant c2 = Creation.CreateNewContestant();
            Contestant c3 = Creation.CreateNewContestant();
            Contestant c4 = Creation.CreateNewContestant();
            Contestant c5 = Creation.CreateNewContestant();

            firm1.manager.InsertSweepstakes(sweep1);
            firm1.manager.InsertSweepstakes(sweep2);
            firm1.manager.InsertSweepstakes(sweep3);
            firm1.manager.InsertSweepstakes(sweep4);
            firm1.manager.InsertSweepstakes(sweep5);

            firm2.manager.InsertSweepstakes(sweep1);
            firm2.manager.InsertSweepstakes(sweep2);
            firm2.manager.InsertSweepstakes(sweep3);
            firm2.manager.InsertSweepstakes(sweep4);
            firm2.manager.InsertSweepstakes(sweep5);

            sweep1.RegisterContestant(c1);
            sweep1.RegisterContestant(c2);
            sweep1.RegisterContestant(c3);
            sweep1.RegisterContestant(c4);
            sweep1.RegisterContestant(c5);

            sweep2.RegisterContestant(c1);
            sweep2.RegisterContestant(c2);
            sweep2.RegisterContestant(c3);
            sweep2.RegisterContestant(c4);
            sweep2.RegisterContestant(c5);

            sweep3.RegisterContestant(c1);
            sweep3.RegisterContestant(c2);
            sweep3.RegisterContestant(c3);
            sweep3.RegisterContestant(c4);
            sweep3.RegisterContestant(c5);

            sweep4.RegisterContestant(c1);
            sweep4.RegisterContestant(c2);
            sweep4.RegisterContestant(c3);
            sweep4.RegisterContestant(c4);
            sweep4.RegisterContestant(c5);

            sweep5.RegisterContestant(c1);
            sweep5.RegisterContestant(c2);
            sweep5.RegisterContestant(c3);
            sweep5.RegisterContestant(c4);
            sweep5.RegisterContestant(c5);

            sweep1.PrintContestantInfo(c1);
            sweep1.PrintContestantInfo(c2);
            sweep1.PrintContestantInfo(c3);
            sweep1.PrintContestantInfo(c4);
            sweep1.PrintContestantInfo(c5);

            sweep2.PrintContestantInfo(c1);
            sweep2.PrintContestantInfo(c2);
            sweep2.PrintContestantInfo(c3);
            sweep2.PrintContestantInfo(c4);
            sweep2.PrintContestantInfo(c5);

            sweep3.PrintContestantInfo(c1);
            sweep3.PrintContestantInfo(c2);
            sweep3.PrintContestantInfo(c3);
            sweep3.PrintContestantInfo(c4);
            sweep3.PrintContestantInfo(c5);

            sweep4.PrintContestantInfo(c1);
            sweep4.PrintContestantInfo(c2);
            sweep4.PrintContestantInfo(c3);
            sweep4.PrintContestantInfo(c4);
            sweep4.PrintContestantInfo(c5);

            sweep5.PrintContestantInfo(c1);
            sweep5.PrintContestantInfo(c2);
            sweep5.PrintContestantInfo(c3);
            sweep5.PrintContestantInfo(c4);
            sweep5.PrintContestantInfo(c5);

            Console.WriteLine("Firm 1 Sweepstakes 1 winner is " + firm1.manager.GetSweepstakes().PickWinner());
            Console.WriteLine("Firm 1 Sweepstakes 2 winner is " + firm1.manager.GetSweepstakes().PickWinner());
            Console.WriteLine("Firm 1 Sweepstakes 3 winner is " + firm1.manager.GetSweepstakes().PickWinner());
            Console.WriteLine("Firm 1 Sweepstakes 4 winner is " + firm1.manager.GetSweepstakes().PickWinner());
            Console.WriteLine("Firm 1 Sweepstakes 5 winner is " + firm1.manager.GetSweepstakes().PickWinner());

            Console.WriteLine("Firm 2 Sweepstakes 5 winner is " + firm2.manager.GetSweepstakes().PickWinner());
            Console.WriteLine("Firm 2 Sweepstakes 4 winner is " + firm2.manager.GetSweepstakes().PickWinner());
            Console.WriteLine("Firm 2 Sweepstakes 3 winner is " + firm2.manager.GetSweepstakes().PickWinner());
            Console.WriteLine("Firm 2 Sweepstakes 2 winner is " + firm2.manager.GetSweepstakes().PickWinner());
            Console.WriteLine("Firm 2 Sweepstakes 1 winner is " + firm2.manager.GetSweepstakes().PickWinner());

            Console.ReadKey();
        }
    }
}
