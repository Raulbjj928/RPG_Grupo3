using DungeonsAndDevs.Utils;
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
            Skills = new List<Skill>();
            Skill skill1 = new Skill("Fúria Aquática", DamageType.Impact, 5, 0, false);
            Skill skill2 = new Skill("Presas Implacáveis", DamageType.Cut, 5, 0, false);
            Skill skill3 = new Skill("Espiral do Terror", DamageType.Cut, 5, 0, false);
            Skills.Add(skill1);
            Skills.Add(skill2);
            Skills.Add(skill3);

            Advantages = new List<DamageType>
                    {
                        //NONE
                    };

            Disadvantages = new List<DamageType>
                    {
                        (DamageType)0,
                    };
            
            EnemyBaseXP = 1;
        }  
    }
}
