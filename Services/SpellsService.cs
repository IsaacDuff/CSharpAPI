using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CSharpAPI.Services
{
    public class SpellsService
    {

        private readonly SpellsRepository _repo;

        public SpellsService(SpellsRepository repo)
        {
            _repo = repo;
        }

        internal List<Spell> Get()
        {
            List<Spell> spells = _repo.Get();
            return spells;
        }

        internal Spell GetOne(int spellId)
        {
            Spell spell = _repo.GetOne(spellId);
            if (spell == null) throw new Exception($"no spell at id {spellId}");
            return spell;
        }

        internal Spell Create(Spell spellData)
        {

            Spell spell = _repo.Create(spellData);
            return spell;

        }

        internal string Remove(int spellId)
        {
            Spell spell = this.GetOne(spellId);
            _repo.Remove(spellId);
            return $"{spell.Name} was Cast!";
        }
    }
}