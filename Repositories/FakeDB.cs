using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CSharpAPI.Repositories
{
    public class FakeDB
    {
        public List<Spell> Spells;


        public FakeDB()
        {
            Spells = new List<Spell>();
            Spells.Add(new Spell(1, "Fireball", "Fire Damage", "8d8", "Fires a Ball of fire with a 20ft radius up to 150ft to a point within range", 3));
            Spells.Add(new Spell(2, "Lightning Bolt", "Lightning Damage", "8d8", "A bolt of lightning shoots 5 ft wide and 100ft long", 3));
            Spells.Add(new Spell(3, "Finger of Death", "Necrotic Damage", "7d8 + 30", "You point at a creature in range with a necrotic touch", 8));
            Spells.Add(new Spell(4, "Fire Storm", "Fire Damage", "7d10", "You a waterfall of fire spreads within range in 10 10ft cubes that connect to each other", 7));
            Spells.Add(new Spell(5, "Disintegrate", "Force Damage", "10d6 + 40", "A bolt of green energy fires at a target within range", 6));
            Spells.Add(new Spell(6, "Cone of Cold", "Cold Damage", "8d8", "A cone shaped blizzard explodes out from you.", 5));

        }
    }
}