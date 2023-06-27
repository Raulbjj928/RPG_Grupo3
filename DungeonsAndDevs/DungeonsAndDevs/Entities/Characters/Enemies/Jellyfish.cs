using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonsAndDevs.Entities.Characters.Enemies
{
    internal class Jellyfish : Enemy
    {
        public Jellyfish() 
        {
            Name = "Jellyfish";
            EnemyType = "Monster";
            EnemyLevel = 1;
            Health = 98;
            Strength = 15;
            Defense = 15;
            Skills.Add(new Utils.Skill("Tiro de Concussão", DamageType.Eletric, 5, 0, false));
            Skills.Add(new Utils.Skill("Tiro Penetrante", DamageType.Fire, 5, 0, false));
            Skills.Add(new Utils.Skill("Tiro Inflamável", DamageType.Poison, 5, 0, false));
            Advantages.Add(DamageType.Eletric);
            Disadvantages.Add(DamageType.Cut);
            EnemyBaseXP = 6;
        }
    }
}
