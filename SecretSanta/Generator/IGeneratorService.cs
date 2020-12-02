using SecretSanta.Participants;
using System.Collections.Generic;

namespace SecretSanta.GeneratorService
{
    internal interface IGeneratorService
    {
        Dictionary<Participant, Participant> Generate(List<Participant> participants, List<Cheating> cheatings);
    }
}
