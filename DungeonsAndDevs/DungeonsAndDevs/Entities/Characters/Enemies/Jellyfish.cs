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
            string descSkill1 = "Libera uma descarga elétrica poderosa de suas tentáculos, atingindo seus inimigos e paralisando-os temporariamente";
            string descSkill2 = "Dispara uma rede de tentáculos viscosos em direção aos oponentes, causando queimaduras severas";
            string descSkill3 = "Executa uma dança graciosa, liberando toxinas venenosas em seu redor, envenenando e debilitando aqueles que se aproximam dela";
            Skills = new List<Skill>();
            Skill skill1 = new Skill("Tiro de Concussão", DamageType.Eletric, 5, 0, false, descSkill1);
            Skill skill2 = new Skill("Tiro Penetrante", DamageType.Fire, 5, 0, false, descSkill2);
            Skill skill3 = new Skill("Tiro Inflamável", DamageType.Poison, 5, 0, false, descSkill3);
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
