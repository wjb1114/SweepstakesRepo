using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    class Contestant
    {
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public string EmailAddress { get; private set; }
        public int RegistrationNumber { get; private set; }

        public Contestant(string first, string last, string email, int idNumber)
        {
            FirstName = first;
            LastName = last;
            EmailAddress = email;
            RegistrationNumber = idNumber;
        }

        public Contestant()
        {
            Creation.CreateNewContestant();
        }
    }
}
