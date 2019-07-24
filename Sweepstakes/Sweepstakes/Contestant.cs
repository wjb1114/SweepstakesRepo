using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    class Contestant
    {
        string firstName;
        string lastName;
        string emailAddress;
        int registrationNumber;

        public Contestant(string first, string last, string email, int idNumber)
        {
            firstName = first;
            lastName = last;
            emailAddress = email;
            registrationNumber = idNumber;
        }
    }
}
