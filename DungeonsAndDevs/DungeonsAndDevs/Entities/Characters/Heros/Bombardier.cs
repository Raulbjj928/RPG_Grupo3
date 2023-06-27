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

        public Bombardier() { }

        public Bombardier(string name)
        {
            Name = name;
            Health = 100;
            Pyrotechnics = 0.5;
            Strength = IncreaseStrength(10, Pyrotechnics);
            Defense = 5;
            Skills.Add(new Skill("Dinamite", DamageType.Explosion, 25, 0, true));
            Skills.Add(new Skill("Molotov", DamageType.Fire, 5, 0, true));
            Skills.Add(new Skill("Granada de Ferro", DamageType.Explosion, 15, 50, true));
            Advantages.Add(DamageType.Fire);
            Disadvantages.Add(DamageType.Cut);
            Disadvantages.Add(DamageType.Puncture);

        }

        public int IncreaseStrength(int strength, double pyrotechnics)
        {
            double newStrength = strength * pyrotechnics;
            return Convert.ToInt32(newStrength);
        }
    }
}
