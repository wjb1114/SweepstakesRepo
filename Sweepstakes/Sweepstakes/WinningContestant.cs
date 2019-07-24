using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MailKit.Net.Smtp;
using MailKit;
using MimeKit;

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
            string messageBody = winner.GetName() + ", you won the sweepstakes!";
            MimeMessage message = new MimeMessage();
            message.From.Add(new MailboxAddress("Sweepstakes Manager", "wbtest14@gmail.com"));
            message.To.Add(new MailboxAddress(GetName(), GetEmailAddress()));
            message.Subject = "Sweepstakes Entry";
            message.Body = new TextPart("plain") { Text = messageBody };

            using (var client = new SmtpClient())
            {
                // For demo-purposes, accept all SSL certificates (in case the server supports STARTTLS)
                client.ServerCertificateValidationCallback = (s, c, h, e) => true;

                client.Connect("smtp.gmail.com", 587);

                // Note: only needed if the SMTP server requires authentication
                client.Authenticate("wbtest14@gmail.com", "TestAccount1994");

                client.Send(message);
                client.Disconnect(true);
            }
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
