using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    class MarketingFirm
    {
        ISweepstakesManager manager;
        public MarketingFirm()
        {
            bool validInput;
            do
            {
                Console.WriteLine("Will you use a stack or a queue?");
                string input = Console.ReadLine();
                try
                {
                    manager = SweepstakesManagerFactory.GetManager(input);
                    validInput = true;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    validInput = false;
                }
            }
            while (validInput == false);
        }
    }
}
