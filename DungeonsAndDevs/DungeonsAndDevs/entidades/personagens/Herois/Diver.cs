using DungeonsAndDevs.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonsAndDevs.Entidades.Personagens.Herois
{
    // Mergulhador
    public class Diver : Character
    {
        public double ExcellentEquipment { get; set; }

        public Diver(string name, List<Skill> skills, List<DamageType> advantages, List<DamageType> disadvantages,
            List<DOT> ativeDOTs, List<int> dotTurnsToWearOff)
        {
            if(name == null)
            {
                Name = "Orion Deepwater";
            }
            ExcellentEquipment = 0.5;
            Health = 130;
            Strength = 5;
            Defense = IncreaseDefense(20, ExcellentEquipment);
            Skills = skills;
            Advantages = advantages;
            Disadvantages = disadvantages;
            ActiveDOTs = ativeDOTs;
            DOTTurnsToWearOff = dotTurnsToWearOff;
        }

        public int IncreaseDefense(int defense, double excellentEquipment)
        {
            double newDefense = defense * excellentEquipment;
            return Convert.ToInt32(newDefense);
        }

    }
}
