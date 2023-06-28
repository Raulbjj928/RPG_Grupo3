using DungeonsAndDevs.Entidades.Characters.Players;
using DungeonsAndDevs.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonsAndDevs.Entities.Characters.Heros
{
    // Artilheiro
    public class Bombardier : Player
    {
     
        public double Pyrotechnics { get; set; }

        public Bombardier(string name)
        {
            Name = name;
            Health = 100;
            Pyrotechnics = 0.5;
            Strength = IncreaseStrength(10, Pyrotechnics);
            Defense = 5;
            string descSkill1 = "Dano em área moderado";
            string descSkill2 = "Dano em área baixo, faz os inimigos atingidos pegarem fogo";
            string descSkill3 = "Dano em área alto, demora um turno para ser preparada";
            Skills = new List<Skill>();
            Skill skill1 = new Skill("Dinamite", DamageType.Explosion, 25, 0, true, descSkill1);
            Skill skill2 = new Skill("Molotov", DamageType.Fire, 5, 0, true, descSkill2);
            Skill skill3 = new Skill("Granada de Ferro", DamageType.Explosion, 15, 50, true, descSkill3);
            Skills.Add(skill1);
            Skills.Add(skill2);
            Skills.Add(skill3);

            Advantages = new List<DamageType>
                    {
                        (DamageType)3,
                    };

            Disadvantages = new List<DamageType>
                    {
                        (DamageType)1,
                        (DamageType)2
                    };

        }

        public int IncreaseStrength(int strength, double pyrotechnics)
        {
            double newStrength = strength * pyrotechnics;
            return Convert.ToInt32(newStrength);
        }
    }
}
