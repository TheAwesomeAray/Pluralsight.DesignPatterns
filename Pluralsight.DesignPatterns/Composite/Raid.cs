using System.Collections.Generic;
using System.Linq;

namespace Pluralsight.DesignPatterns.Composite
{
    class Raid : ILoot
    {
        public List<Party> Parties { get; set; } = new List<Party>();

        public void ReceiveLoot(decimal gold)
        {
            int raidSize = Parties.Sum(p => p.Members.Count);

            foreach (var party in Parties)
            {
                decimal partyPercentage = (decimal)party.Members.Count / raidSize;
                party.ReceiveLoot(gold * partyPercentage);
            }
        }
    }
}
