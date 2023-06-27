using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonsAndDevs.Entities.Characters.Enemies
{
    internal class Shark : Enemy
    {
        public Shark() 
        {
            Name = "White Shark";
            EnemyType = "Monster";
            EnemyLevel = 1;
            Health = 105;
            Strength = 15;
            Defense = 8;
            Skills.Add(new Utils.Skill("Fúria Aquática", DamageType.Impact, 5, 0, false));
            Skills.Add(new Utils.Skill("Presas Implacáveis", DamageType.Cut, 5, 0, false));
            Skills.Add(new Utils.Skill("Espiral do Terror", DamageType.Cut, 5, 0, false));
            Disadvantages.Add(DamageType.Impact);
            EnemyBaseXP = 1;
        }  
    }
}
