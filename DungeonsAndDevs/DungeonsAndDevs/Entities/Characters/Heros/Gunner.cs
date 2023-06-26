using DungeonsAndDevs.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonsAndDevs.Entities.Characters.Heros
{
    // Artilheiro
    public class Gunner : Character
    {
     
        public double Pyrotechnics { get; set; }

        public Gunner() { }

        public Gunner(string name, List<Skill> skills, List<DamageType> advantages, List<DamageType> disadvantages, 
            List<DOT> ativeDOTs, List<int> dotTurnsToWearOff)
        {
            if (name == null)
            {
                Name = "Flint Ironsides";
            }
            Pyrotechnics = 0.5;
            Health = 100;
            Strength = IncreaseStrength(10, Pyrotechnics);
            Defense = 5;
            Skills = skills; 
            Advantages = advantages;
            Disadvantages = disadvantages;
            ActiveDOTs = ativeDOTs;
            DOTTurnsToWearOff = dotTurnsToWearOff;

        }

        public int IncreaseStrength(int strength, double pyrotechnics)
        {
            double newStrength = strength * pyrotechnics;
            return Convert.ToInt32(newStrength);
        }
    }
}
