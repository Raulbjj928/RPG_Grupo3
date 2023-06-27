using DungeonsAndDevs.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonsAndDevs.Entities.Characters.Enemies
{
    internal class Mullet : Enemy
    {
        public Mullet() 
        {
            Name = "School of Mullets";
            EnemyType = "Monster";
            EnemyLevel = 2;
            Health = 105;
            Strength = 8;
            Defense = 15;
            Skills = new List<Skill>();
            Skill skill1 = new Skill("Frenesi Aquático", DamageType.Cut, 5, 0, false);
            Skill skill2 = new Skill("Investida Coletiva", DamageType.Puncture, 5, 0, false);
            Skill skill3 = new Skill("Redemoinho Prateado", DamageType.Bleed, 5, 0, false);
            Skills.Add(skill1);
            Skills.Add(skill2);
            Skills.Add(skill3);

            Advantages = new List<DamageType>
                    {
                        (DamageType)2,
                    };

            Disadvantages = new List<DamageType>
                    {
                        (DamageType)7
                    };

            EnemyBaseXP = 3;
        }
    }
}
