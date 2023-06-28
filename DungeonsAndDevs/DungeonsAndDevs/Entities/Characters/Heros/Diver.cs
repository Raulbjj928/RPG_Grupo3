using DungeonsAndDevs.Entidades.Characters.Players;
using DungeonsAndDevs.Utils;
using System;
using System.Collections.Generic;

namespace DungeonsAndDevs.Entities.Characters.Heros
{
    // Mergulhador
    public class Diver : Player
    {
        public double ExcellentEquipment { get; set; }

        public Diver(string name)
        {
            Name = name;
            Health = 130;
            Strength = 5;
            ExcellentEquipment = 0.5;
            Defense = IncreaseDefense(20, ExcellentEquipment);
            string descSkill1 = "Atira o arpão, causando dano moderado e penetrando baixa quantidade de armadura";
            string descSkill2 = "Espeta o inimigo com o arpão, causando dano e fazendo o inimigo sangrar";
            Skills = new List<Skill>();
            Skill skill1 = new Skill("Tiro de arpão", DamageType.Puncture, 20, 20, false, descSkill1);
            Skill skill2 = new Skill("Espetada de arpão", DamageType.Bleed, 10, 0, false, descSkill2);
            Skills.Add(skill1);
            Skills.Add(skill2);

            Advantages = new List<DamageType>
                    {
                        (DamageType)1,
                        (DamageType)4
                    };

            Disadvantages = new List<DamageType>
                    {
                        (DamageType)5,
                        (DamageType)7
                    };
        }

        public int IncreaseDefense(int defense, double excellentEquipment)
        {
            double newDefense = defense * excellentEquipment;
            return Convert.ToInt32(newDefense);
        }
    }
}

