using DungeonsAndDevs.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonsAndDevs.Entities.Characters.Enemies
{
    internal class Oktopus : Enemy
    {
        public Oktopus() 
        {
            Name = "Kraken (Giant Oktopus)";
            EnemyType = "Boss";
            EnemyLevel = 30;
            Health = 95;
            Strength = 20;
            Defense = 20;
            Skills = new List<Skill>();
            Skill skill1 = new Skill("Esmagamento Profundo", DamageType.Impact, 10, 5, false);
            Skill skill2 = new Skill("Sopro Tempestuoso", DamageType.Eletric, 10, 5, false);
            Skill skill3 = new Skill("Abraço Abissal", DamageType.Puncture, 10, 5, false);
            //Skill skill4 = new Skill("Olhar dos afogados", DamageType.???, 10, 0, false); Modifica atributo
            Skills.Add(skill1);
            Skills.Add(skill2);
            Skills.Add(skill3);

            Advantages = new List<DamageType>
                    {
                        (DamageType)0,
                        (DamageType)6
                    };

            Disadvantages = new List<DamageType>
                    {
                        (DamageType)3,
                    };

            EnemyBaseXP = 75;
        }
    }
}
