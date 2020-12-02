using SecretSanta.Participants;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SecretSanta.EmailService
{
    internal interface IEmailService
    {
        public void Send(KeyValuePair<Participant, Participant> pair, string htmlBody);
    }
}