using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    class WinningContestant : IContestEntrant
    {
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public string EmailAddress { get; private set; }
        public int RegistrationNumber { get; private set; }

        public WinningContestant(string first, string last, string email, int idNumber)
        {
            FirstName = first;
            LastName = last;
            EmailAddress = email;
            RegistrationNumber = idNumber;
        }

        public WinningContestant()
        {
            Creation.CreateNewContestant();
        }

        public string GetEmailAddress()
        {
            return EmailAddress;
        }
        public void SendMessage(IContestEntrant winner)
        {
            Console.WriteLine(winner.GetName() + ", you won the sweepstakes!");
        }
        public string GetName()
        {
            return FirstName + " " + LastName;
        }
        public int GetRegistration()
        {
            return RegistrationNumber;
        }
        public string GetFirstName()
        {
            return FirstName;
        }
        public string GetLastName()
        {
            return LastName;
        }
    }
}
