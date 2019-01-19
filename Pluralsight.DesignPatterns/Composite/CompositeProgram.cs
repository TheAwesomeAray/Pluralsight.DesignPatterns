using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pluralsight.DesignPatterns.Composite
{
    public static class CompositeProgram
    {
        public static void Run()
        {
            var bellocke = new Player() { Name = "Bellocke" };
            var mayleia = new Player() { Name = "Mayleia" };
            var edwith = new Player() { Name = "Edwith" };

            var party1 = new Party() { Members = { edwith, bellocke, mayleia } };

            var kagor = new Player() { Name = "Kagor" };
            var pandeena = new Player() { Name = "Pandeena" };
            var captainSnuggles = new Player() { Name = "CaptainSnuggles" };

            var party2 = new Party() { Members = { kagor, pandeena, captainSnuggles } };

            var raid = new Raid() { Parties = { party1, party2 } };

            var bossGold = 1000;
            raid.ReceiveLoot(bossGold);

            foreach (var member in raid.Parties.SelectMany(x => x.Members))
                member.Stats();
        }
    }
}
