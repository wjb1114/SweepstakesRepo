using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    class Sweepstakes
    {
        Dictionary<int, IContestEntrant> entries;
        Random rand;
        public Sweepstakes()
        {
            entries = new Dictionary<int, IContestEntrant>();
            rand = new Random();
            System.Threading.Thread.Sleep(5);
        }

        public void RegisterContestant(Contestant contestant)
        {
            entries.Add(contestant.GetRegistration(), contestant);
        }

        public string PickWinner()
        {
            int randomNumber = rand.Next(0, entries.Count);
            IContestEntrant winner = entries.ElementAt(randomNumber).Value;
            entries.Remove(winner.GetRegistration());
            WinningContestant winningContestant = new WinningContestant(winner.GetFirstName(), winner.GetLastName(), winner.GetEmailAddress(), winner.GetRegistration());
            entries.Add(winningContestant.GetRegistration(), winningContestant);
            for (int i = 0; i < entries.Count; i++)
            {
                entries.ElementAt(i).Value.SendMessage(winningContestant);
            }
            return entries.ElementAt(randomNumber).Value.GetEmailAddress();
        }

        public void PrintContestantInfo(Contestant contestant)
        {
            Console.WriteLine("Name: " + contestant.FirstName + " " + contestant.LastName + "\nEmail Address: " + contestant.EmailAddress + "\nRegistration Number: " + contestant.RegistrationNumber);
        }
    }
}
