using System;
using System.Collections.Generic;
using DungeonsAndDevs.Utils;



namespace DungeonsAndDevs.Entities.Characters
{
    public abstract class Character
    {
        public string Name { get; set; }
        public int Health { get; set; }
        public int Strength { get; set; }
        public int Defense { get; set; }
        public List<Skill> Skills { get; set; }
        public List<DamageType> Advantages { get; set; }
        public List<DamageType> Disadvantages { get; set; }
        public List<DOT> ActiveDOTs { get; set; }
        public List<int> DOTTurnsToWearOff { get; set; }

        public int TakeSkillDamage(Skill skill, int targetDefense, int targetHealth)
        {
            ApplyDOT(skill.Type);
            double calcDamage = skill.BaseDmg;
            foreach (DamageType dt in Disadvantages)
            {
                if (dt == skill.Type)
                {
                    calcDamage *= 1.20;
                }
            }
            foreach (DamageType dt in Advantages)
            {
                if (dt == skill.Type)
                {
                    calcDamage *= 0.80;
                }
            }
            double damageReduction = targetDefense / (targetDefense + 40);
            double finalHealth = targetHealth - (calcDamage - (calcDamage * damageReduction));
            targetHealth = (int)finalHealth;
            return targetHealth;
        }
        //Fire = 70%
        //Bleed = 60%
        //Poison = 50%
        protected void ApplyDOT(DamageType damageType)
        {
            Random random = new Random();
            int proc = 0;
            switch (damageType)
            {
                case DamageType.Fire:
                    proc = random.Next(100);
                    if (proc < 70)
                    {
                        ActiveDOTs.Add(DOT.Fire);
                        DOTTurnsToWearOff.Add(3);
                    }
                    break;
                case DamageType.Bleed:
                    proc = random.Next(100);
                    if (proc < 60)
                    {
                        ActiveDOTs.Add(DOT.Bleed);
                        DOTTurnsToWearOff.Add(5);
                    }
                    break;
                case DamageType.Poison:
                    proc = random.Next(100);
                    if (proc < 50)
                    {
                        ActiveDOTs.Add(DOT.Poison);
                        DOTTurnsToWearOff.Add(7);
                    }
                    break;
            }
        }
        public void UpdateDOTs()
        {
            for (int i = 0; i < ActiveDOTs.Count; i++)
            {
                switch (ActiveDOTs[i])
                {
                    case DOT.Fire:
                        Health -= 10;
                        DOTTurnsToWearOff[i]--;
                        if (DOTTurnsToWearOff[i] == 0)
                        {
                            ActiveDOTs.Remove(ActiveDOTs[i]);
                            DOTTurnsToWearOff.Remove(DOTTurnsToWearOff[i]);
                        }
                        break;
                    case DOT.Bleed:
                        Health -= 8;
                        DOTTurnsToWearOff[i]--;
                        if (DOTTurnsToWearOff[i] == 0)
                        {
                            ActiveDOTs.Remove(ActiveDOTs[i]);
                            DOTTurnsToWearOff.Remove(DOTTurnsToWearOff[i]);
                        }
                        break;
                    case DOT.Poison:
                        Health -= 5;
                        DOTTurnsToWearOff[i]--;
                        if (DOTTurnsToWearOff[i] == 0)
                        {
                            ActiveDOTs.Remove(ActiveDOTs[i]);
                            DOTTurnsToWearOff.Remove(DOTTurnsToWearOff[i]);
                        }
                        break;
                }
            }
        }
    }
}
