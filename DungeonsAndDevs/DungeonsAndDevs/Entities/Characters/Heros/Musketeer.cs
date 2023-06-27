using DungeonsAndDevs.Entidades.Characters.Players;
using DungeonsAndDevs.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonsAndDevs.Entities.Characters.Heros
{
    // Mosqueteiro
    public class Musketeer : Player
    {
        public double Preparation { get; set; }

        public Musketeer(string name)
        {
            Name = name;
            Preparation = 0.5;
            Health = IncreaseHealth(100, Preparation);
            Strength = 12;
            Defense = 10;
            Skills = new List<Skill>();
            Skill skill1 = new Skill("Tiro de Concussão", DamageType.Impact, 20, 0, false);
            Skill skill2 = new Skill("Tiro Penetrante", DamageType.Puncture, 16, 50, false);
            Skill skill3 = new Skill("Tiro Inflamável", DamageType.Explosion, 10, 0, false);
            Skills.Add(skill1);
            Skills.Add(skill2);
            Skills.Add(skill3);

            Advantages = new List<DamageType>
                    {
                        (DamageType)0,
                        (DamageType)2
                    };

            Disadvantages = new List<DamageType>
                    {
                        (DamageType)4,
                        (DamageType)3
                    };
        }

        public int IncreaseHealth(int health, double preparation)
        {
            double newHealth = health * preparation;
            return Convert.ToInt32(newHealth);
        }
    }
}
