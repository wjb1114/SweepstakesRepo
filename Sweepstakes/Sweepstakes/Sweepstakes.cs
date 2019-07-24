using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    class Sweepstakes
    {
        Dictionary<int, Contestant> entries;
        Random rand;
        public Sweepstakes()
        {
            entries = new Dictionary<int, Contestant>();
            rand = new Random();
            System.Threading.Thread.Sleep(5);
        }

        public void RegisterContestant(Contestant contestant)
        {
            entries.Add(contestant.RegistrationNumber, contestant);
        }

        public string PickWinner()
        {
            int randomNumber = rand.Next(0, entries.Count);
            return entries.ElementAt(randomNumber).Value.EmailAddress;
        }

        public void PrintContestantInfo(Contestant contestant)
        {
            Console.WriteLine("Name: " + contestant.FirstName + " " + contestant.LastName + "\nEmail Address: " + contestant.EmailAddress + "\nRegistration Number: " + contestant.RegistrationNumber);
        }
    }
}
