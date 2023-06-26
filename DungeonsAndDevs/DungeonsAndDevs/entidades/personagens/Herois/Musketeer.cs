using DungeonsAndDevs.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonsAndDevs.Entidades.Personagens.Herois
{
    // Mosqueteiro
    public class Musketeer : Character
    {
        public double Preparation { get; set; }


        public Musketeer()  { }

        public Musketeer(string name, List<Skill> skills, List<DamageType> advantages, List<DamageType> disadvantages,
            List<DOT> ativeDOTs, List<int> dotTurnsToWearOff)
        {
            if (name == null)
            {
                Name = "Griffin Blackwood";
            }
            Preparation = 0.5;
            Health = IncreaseHealth(10, Preparation);
            Strength = 12;
            Defense = 10;
            Skills = skills;
            Advantages = advantages;
            Disadvantages = disadvantages;
            ActiveDOTs = ativeDOTs;
            DOTTurnsToWearOff = dotTurnsToWearOff;

        }

        public int IncreaseHealth(int health, double preparation)
        {
            double newHealth = health * preparation;
            return Convert.ToInt32(newHealth);
        }




    }
}
