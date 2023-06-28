using DungeonsAndDevs.Utils;
using System.Collections.Generic;

namespace DungeonsAndDevs.Entities.Characters.Enemies
{
    internal class Megalodon : Enemy
    {
        public Megalodon()
        {
            Name = "Vorax (Megalodon)";
            EnemyType = "Boss";
            EnemyLevel = 2;
            Health = 110;
            Strength = 20;
            Defense = 5;
            string descSkill1 = "Um ataque poderoso no qual o Megalodon se lança com ferocidade sobre seus inimigos, lançando-os para o ar com sua força brutal";
            string descSkill2 = "Um ataque no qual o Megalodon abre sua enorme boca e morde com uma força avassaladora, causando um dano massivo ao oponente";
            string descSkill3 = "Convoca as forças oceânicas ao seu redor, criando uma poderosa correnteza de água carregada de sangue que atinge seus inimigos com uma violência implacável";
            Skills = new List<Skill>();
            Skill skill1 = new Skill("Fúria das Profundezas", DamageType.Impact, 10, 5, false, descSkill1);
            Skill skill2 = new Skill("Mordida Devastadora", DamageType.Bleed, 10, 5, false, descSkill2);
            Skill skill3 = new Skill("Torrente Sanguinária", DamageType.Impact, 10, 5, false, descSkill3);
            Skills.Add(skill1);
            Skills.Add(skill2);
            Skills.Add(skill3);

            Advantages = new List<DamageType>
                    {
                        (DamageType)1,
                    };

            Disadvantages = new List<DamageType>
                    {
                        (DamageType)0,
                    };

            EnemyBaseXP = 30;
        }
    }
}
