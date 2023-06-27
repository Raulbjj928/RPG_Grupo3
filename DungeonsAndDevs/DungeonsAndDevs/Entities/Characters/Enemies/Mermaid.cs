using DungeonsAndDevs.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DungeonsAndDevs.Entities.Characters.Enemies
{
    internal class Mermaid : Enemy
    {
        public Mermaid() 
        {
            Name = "Nerida (Cursed Mermaid)";
            EnemyType = "Boss";
            EnemyLevel = 20;
            Health = 110;
            Strength = 5;
            Defense = 20;
            Skills = new List<Skill>();
            Skill skill1 = new Skill("Lança das Marés", DamageType.Puncture, 10, 5, true);
            Skill skill2 = new Skill("Cuspe ácido", DamageType.Poison, 10, 5, true);
            // Skill skill3 = new Skill("Canto Hipnótico", DamageType.???, 10, 5, true); Modifica atributo
            // Skill skill4 = new Skill("Aurora Celeste", DamageType.???, 10, 5, true); Modifica atributo
            Skills.Add(skill1);
            Skills.Add(skill2);

            Advantages = new List<DamageType>
                    {
                        (DamageType)4
                    };

            Disadvantages = new List<DamageType>
                    {
                        (DamageType)7
                    };

            EnemyBaseXP = 45;
        }
    }
}
