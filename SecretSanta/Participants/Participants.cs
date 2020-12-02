using System.Collections.Generic;
using System.Linq;

namespace SecretSanta.Participants
{
    internal class Participants
    {
        public Participants()
        {
            Get = new List<Participant>
            {
                new Participant
                {
                    Name = "გოგა ჩინჩალაძე",
                    Email = "goga.chinchaladze@gmail.com"
                },
                new Participant
                {
                    Name = "სალომე ცირამუა",
                    Email = "salome.tsiramua@gmail.com"
                },
                new Participant
                {
                    Email = "zarandia.irakli@gmail.com",
                    Name = "ირაკლი ზარანდია"
                },
                new Participant
                {
                    Email = "",
                    Name = "ელენე ახვლედიანი"
                },
                new Participant
                {
                    Email = "tkhotivari@gmail.com",
                    Name = "თათული ხოტივარი"
                },
                new Participant
                {
                    Email = "",
                    Name = "ლევან სამუშია"
                },
                new Participant
                {
                    Email = "",
                    Name = "ნატაშა ნესოშვილი"
                },
                new Participant
                {
                    Email = "",
                    Name = "ელენე ჭიჭინაძე"
                },
                new Participant
                {
                    Email = "",
                    Name = "ხატია ნესოშვილი"
                },
                new Participant
                {
                    Email = "nutsa.ishkhneli@gmail.com",
                    Name = "ნუცა იშხნელი"
                },
            };

            var duplications = Get.GroupBy(x => x.Email)
                .Where(g => g.Count() > 1)
                .Select(y => y.Key)
                .ToList();

            if (duplications.Count > 0)
            {
                throw new System.Exception("Invalid participant values");
            }
        }

        public List<Participant> Get { get; }
    }
}
