using DungeonsAndDevs.Utils;
using System.Collections.Generic;

namespace DungeonsAndDevs.Entities.Characters.Enemies
{
    internal class Oktopus : Enemy
    {
        public Oktopus() 
        {
            Name = "Kraken (Giant Oktopus)";
            EnemyType = "Boss";
            EnemyLevel = 3;
            Health = 95;
            Strength = 20;
            Defense = 20;
            string descSkill1 = "Desencadeia sua imensa força, mergulhando com poder avassalador sobre seus inimigos, esmagando-os com suas gigantescas tentáculos";
            string descSkill2 = "Inala profundamente e libera um poderoso jato de ar, criando uma tempestade violenta que atinge seus adversários com ventos furiosos e destroços";
            string descSkill3 = "Envolve seus oponentes em um aperto mortal com seus tentáculos, puxando-os para as profundezas do oceano, onde a pressão esmagadora causa perfurações no pulmões do alvo";
            //string descSkill4 = "Inflige um olhar penetrante, roubando 25% da defesa do inimigo";
            Skills = new List<Skill>();
            Skill skill1 = new Skill("Esmagamento Profundo", DamageType.Impact, 10, 5, false, descSkill1);
            Skill skill2 = new Skill("Sopro Tempestuoso", DamageType.Eletric, 10, 5, false, descSkill2);
            Skill skill3 = new Skill("Abraço Abissal", DamageType.Puncture, 10, 5, false, descSkill3);
            //Skill skill4 = new Skill("Olhar dos afogados", DamageType.???, 10, 0, false, descSkill4); Modifica atributo
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
