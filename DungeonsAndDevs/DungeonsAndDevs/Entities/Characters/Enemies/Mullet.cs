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
            Skills.Add(new Utils.Skill("Frenesi Aquático", DamageType.Cut, 5, 0, false));
            Skills.Add(new Utils.Skill("Investida Coletiva", DamageType.Puncture, 5, 0, false));
            Skills.Add(new Utils.Skill("Redemoinho Prateado", DamageType.Bleed, 5, 0, false));
            Advantages.Add(DamageType.Puncture);
            Disadvantages.Add(DamageType.Explosion);
            EnemyBaseXP = 3;
        }
    }
}
