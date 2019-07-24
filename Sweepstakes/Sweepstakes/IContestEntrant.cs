using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    interface IContestEntrant
    {
        void SendMessage(IContestEntrant winner);
        string GetEmailAddress();
        string GetName();
        string GetFirstName();
        string GetLastName();
        int GetRegistration();
    }
}
