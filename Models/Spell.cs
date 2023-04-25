using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CSharpAPI.Models
{
    public class Spell
    {
        public Spell(int id, string name, string damageType, string damageDice, string description, int level)
        {
            Id = id;
            Name = name;
            DamageType = damageType;
            DamageDice = damageDice;
            Description = description;
            Level = level;


        }



        public int Id { get; set; }

        public string Name { get; set; }

        public string DamageType { get; set; }

        public string DamageDice { get; set; }

        public string Description { get; set; }

        public int Level { get; set; }

    }
}