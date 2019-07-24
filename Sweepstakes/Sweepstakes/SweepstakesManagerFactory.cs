using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    static class SweepstakesManagerFactory
    {
        public static ISweepstakesManager GetManager(string input)
        {
            switch(input.ToLower())
            {
                case "stack":
                    return new SweepstakesStackManager();
                case "queue":
                    return new SweepstakesQueueManager();
                default:
                    throw new ApplicationException("Invalid user input.");
            }
        }
    }
}
