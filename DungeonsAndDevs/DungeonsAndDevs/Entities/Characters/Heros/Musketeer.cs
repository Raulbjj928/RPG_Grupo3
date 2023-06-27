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


        public Musketeer()  { }

        public Musketeer(string name)
        {
            Name = name;
            Preparation = 0.5;
            Health = IncreaseHealth(100, Preparation);
            Strength = 12;
            Defense = 10;
            Skills.Add(new Skill("Tiro de Concussão", DamageType.Impact, 20, 0, false));
            Skills.Add(new Skill("Tiro Penetrante", DamageType.Puncture, 16, 50, false));
            Skills.Add(new Skill("Tiro Inflamável", DamageType.Explosion, 10, 0, false));
            Advantages.Add(DamageType.Impact);
            Advantages.Add(DamageType.Puncture);
            Disadvantages.Add(DamageType.Bleed);
            Disadvantages.Add(DamageType.Fire);

        }

        public int IncreaseHealth(int health, double preparation)
        {
            double newHealth = health * preparation;
            return Convert.ToInt32(newHealth);
        }
    }
}
