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
            Skills.Add(new Utils.Skill("Esmagamento Profundo", DamageType.Impact, 10, 5, false));
            Skills.Add(new Utils.Skill("Sopro Tempestuoso", DamageType.Eletric, 10, 5, false));
            Skills.Add(new Utils.Skill("Abraço Abissal", DamageType.Puncture, 10, 5, false));
            //Skills.Add(new Utils.Skill("Olhar dos afogados", DamageType.???, 10, 0, false)); Modifica atributo
            Advantages.Add(DamageType.Puncture);
            Advantages.Add(DamageType.Poison);
            Disadvantages.Add(DamageType.Fire);
            EnemyBaseXP = 75;
        }
    }
}
