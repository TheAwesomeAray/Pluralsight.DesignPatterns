using System.Collections.Generic;

namespace Pluralsight.DesignPatterns.Composite
{
    class Party : ILoot
    {
        public List<Player> Members { get; set; } = new List<Player>();

        public void ReceiveLoot(decimal gold)
        {
            foreach (var player in Members)
                player.ReceiveLoot(gold / Members.Count);
        }
    }
}
