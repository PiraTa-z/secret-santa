using SecretSanta.Participants;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SecretSanta.GeneratorService
{
    internal class GeneratorService : IGeneratorService
    {
        private readonly Random _random;

        public GeneratorService()
        {
            _random = new Random();
        }

        public Dictionary<Participant, Participant> Generate(List<Participant> participants, List<Cheating> cheatings)
        {
            var participantsAmount = participants.Count;
            var tryAssign = 0;

            var generated = new Dictionary<Participant, Participant>();

            foreach (var participant in participants)
            {
                var assigned = false;
                tryAssign = 0;

                while (!assigned)
                {
                    Participant addressee;

                    tryAssign++;

                    Cheating cheatedAddressee = cheatings.FirstOrDefault(ch => ch.For == participant.Email);

                    if (cheatedAddressee != null)
                    {
                        addressee = participants.First(p => p.Email == cheatedAddressee.To);
                    }
                    else
                    {
                        var randomIndex = _random.Next(0, participantsAmount);
                        addressee = participants[randomIndex];

                        if (cheatings.FirstOrDefault(ch => ch.To == addressee.Email) != null)
                        {
                            continue;
                        }
                    }

                    if (tryAssign > participantsAmount)
                    {
                        return Generate(participants, cheatings);
                    }

                    if (generated.Values.FirstOrDefault(p => p.Email == addressee.Email) != null || participant.Email == addressee.Email)
                    {
                        continue;
                    }

                    generated.Add(participant, addressee);

                    assigned = true;
                }
            }

            return generated;
        }
    }
}
