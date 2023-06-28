using DungeonsAndDevs.Utils;
using System.Collections.Generic;

namespace DungeonsAndDevs.Entities.Characters.Enemies
{
    internal class Mermaid : Enemy
    {
        public Mermaid()
        {
            Name = "Nerida (Cursed Mermaid)";
            EnemyType = "Boss";
            EnemyLevel = 2;
            Health = 110;
            Strength = 5;
            Defense = 20;
            // string descSkill1 = "Entoa uma melodia mágica e envolvente, hipnotizando seus inimigos e enfraquecendo sua vontade de lutar. Diminui 50% do ataque do alvo";
            string descSkill2 = "Convoca o poder das marés e lança uma torrente de água com grande força contra seus oponentes, causando danos e empurrando-os para longe";
            // string descSkill3 = "Emite um brilho radiante e cria uma aurora mágica, que cura e revitaliza a si mesma, fortalecendo sua resistência e restaurando sua energia";
            string descSkill4 = "Saliva com toxinas que envenenam o inimigo";
            Skills = new List<Skill>();
            Skill skill1 = new Skill("Lança das Marés", DamageType.Puncture, 10, 5, true, descSkill2);
            Skill skill2 = new Skill("Cuspe ácido", DamageType.Poison, 10, 5, true, descSkill4);
            // Skill skill3 = new Skill("Canto Hipnótico", DamageType.???, 10, 5, true, descSkill1); Modifica atributo
            // Skill skill4 = new Skill("Aurora Celeste", DamageType.???, 10, 5, true, descSkill3); Modifica atributo
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
