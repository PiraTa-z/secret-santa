using System.Collections.Generic;
using System.Linq;

namespace SecretSanta.Participants
{
    internal class Cheatings
    {
        public Cheatings()
        {
            Get = new List<Cheating>
            {
                new Cheating
                {
                    For = "zarandia.irakli@gmail.com",
                    To = ""
                }
            };

            var duplications = Get.GroupBy(x => x.For)
                .Where(g => g.Count() > 1)
                .Select(y => y.Key)
                .ToList();

            if (duplications.Count > 0)
            {
                throw new System.Exception("Invalid cheating values");
            }
        }

        public List<Cheating> Get { get; }
    }
}
