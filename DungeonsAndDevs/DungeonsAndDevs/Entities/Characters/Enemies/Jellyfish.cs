using DungeonsAndDevs.Utils;
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
            Skills = new List<Skill>();
            Skill skill1 = new Skill("Tiro de Concussão", DamageType.Eletric, 5, 0, false);
            Skill skill2 = new Skill("Tiro Penetrante", DamageType.Fire, 5, 0, false);
            Skill skill3 = new Skill("Tiro Inflamável", DamageType.Poison, 5, 0, false);
            Skills.Add(skill1);
            Skills.Add(skill2);
            Skills.Add(skill3);

            Advantages = new List<DamageType>
                    {
                        (DamageType)5,
                    };

            Disadvantages = new List<DamageType>
                    {
                        (DamageType)1,
                    };

            EnemyBaseXP = 6;
        }
    }
}
