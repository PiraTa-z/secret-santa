using SecretSanta.Email;
using SecretSanta.EmailService;
using SecretSanta.GeneratorService;
using SecretSanta.Participants;
using System;
using System.Collections.Generic;

namespace SecretSanta
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IEmailService emailService = new EmailService.EmailService();
            IGeneratorService generator = new GeneratorService.GeneratorService();
            Participants.Participants participants = new Participants.Participants();
            Cheatings cheatings = new Cheatings();

            Dictionary<Participant, Participant> generated = generator.Generate(participants.Get, cheatings.Get);

            foreach (KeyValuePair<Participant, Participant> pair in generated)
            {
                emailService.Send(pair, Template.Get(pair));
            }
        }
    }
}
