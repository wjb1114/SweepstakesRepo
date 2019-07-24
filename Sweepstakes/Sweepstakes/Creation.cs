using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    static class Creation
    {
        public static Contestant CreateNewContestant()
        {
            Contestant newContestant;
            string fName;
            string lName;
            string email;
            int idNumber = -1;

            Console.Write("Contestant\'s first name: ");
            fName = Console.ReadLine();
            Console.Write("Contestant\'s last name: ");
            lName = Console.ReadLine();
            bool validEmail;
            do
            {
                Console.Write("Contestant\'s email address: ");
                email = Console.ReadLine();
                validEmail = IsValidEmail(email);
            }
            while (validEmail == false);
            bool validNumber;
            do
            {
                try
                {
                    Console.WriteLine("Contestant\'s registration number: ");
                    idNumber = Convert.ToInt32(Console.ReadLine());
                    validNumber = true;
                }
                catch (Exception e)
                {
                    validNumber = false;
                    Console.WriteLine(e.Message);
                }
            }
            while (validNumber == false);
            newContestant = new Contestant(fName, lName, email, idNumber);
            return newContestant;
        }
        static bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }

        public static Sweepstakes CreateSweepstakes()
        {
            return new Sweepstakes();
        }

    }
}
