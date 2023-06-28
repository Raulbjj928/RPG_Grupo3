using DungeonsAndDevs.Utils;
using System.Collections.Generic;

namespace DungeonsAndDevs.Entities.Characters.Enemies
{
    internal class Mullet : Enemy
    {
        public Mullet() 
        {
            Name = "Mullet";
            EnemyType = "Monster";
            EnemyLevel = 1;
            Health = 105;
            Strength = 8;
            Defense = 15;
            string descSkill1 = "O cardume ataca em um frenesi coordenado, nadando em rápida sucessão e desferindo uma série de golpes rápidos e precisos contra seus adversários";
            string descSkill2 = "O cardume se agrupa em uma formação numerosa e avança em uma investida poderosa, colidindo com seus oponentes como se fossem incontáveis facas estocando o alvo";
            string descSkill3 = "O cardume de Tainhas forma um redemoinho de movimentos fluidos e rápidos, criando uma ilusão prateada que confunde e desorienta seus inimigos antes de atacarem em uníssono";
            Skills = new List<Skill>();
            Skill skill1 = new Skill("Frenesi Aquático", DamageType.Cut, 5, 0, false, descSkill1);
            Skill skill2 = new Skill("Investida Coletiva", DamageType.Puncture, 5, 0, false, descSkill2);
            Skill skill3 = new Skill("Redemoinho Prateado", DamageType.Bleed, 5, 0, false, descSkill3);
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
