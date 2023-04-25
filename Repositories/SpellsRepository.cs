using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CSharpAPI.Repositories
{
    public class SpellsRepository
    {


        private readonly FakeDB _db;

        public SpellsRepository(FakeDB db)
        {
            _db = db;
        }

        internal List<Spell> Get()
        {
            return _db.Spells;
        }

        internal Spell GetOne(int spellId)
        {
            Spell spell = _db.Spells.Find(s => s.Id == spellId);
            return spell;
        }

        internal Spell Create(Spell spellData)
        {
            int spellId = _db.Spells[_db.Spells.Count - 1].Id + 1;
            Spell newSpell = new Spell(spellId, spellData.Name, spellData.DamageType, spellData.DamageDice, spellData.Description, spellData.Level);
            _db.Spells.Add(newSpell);
            return newSpell;
        }

        internal void Remove(int spellId)
        {
            Spell spell = this.GetOne(spellId);
            _db.Spells.Remove(spell);
        }

    }
}