using DungeonsAndDevs.Entities.Characters;
using DungeonsAndDevs.Utils;
using System;
using System.Collections.Generic;

namespace DungeonsAndDevs.Entidades.Characters.Players
{
    public enum PlayerClass
    {
        Diver, Bombardier, Musketeer
    };

    public class Player : Character
    {
        public PlayerClass PlayerClass { get; set; }
        public void SetInitialStats()
        {
            if (string.IsNullOrWhiteSpace(Name))
            {
                pickName();
            }

            switch (PlayerClass)
            {
                case PlayerClass.Diver:
                    Health = 130;
                    Strength = 5;
                    Defense = 20;
                    Skills = new List<Skill>();
                    Skill skill1 = new Skill("Tiro de arpão", DamageType.Puncture, 20, 20, false);
                    Skill skill2 = new Skill("Espetada de arpão", DamageType.Bleed, 10, 0, false);
                    Skills.Add(skill1);
                    Skills.Add(skill2);

                    Advantages = new List<DamageType>
                    {
                        (DamageType)2,
                        (DamageType)1
                    };

                    Disadvantages = new List<DamageType>
                    {
                        (DamageType)5,
                        (DamageType)7
                    };
                    break;

                case PlayerClass.Bombardier:
                    Health = 100;
                    Strength = 10;
                    Defense = 5;
                    Skills.Add(new Skill("Dinamite", DamageType.Explosion, 25, 0, true));
                    Skills.Add(new Skill("Molotov", DamageType.Fire, 5, 0, true));
                    Skills.Add(new Skill("Granada de Ferro", DamageType.Explosion, 15, 50, true));
                    Advantages.Add(DamageType.Fire);
                    Disadvantages.Add(DamageType.Cut);
                    Disadvantages.Add(DamageType.Puncture);
                    break;

                case PlayerClass.Musketeer:
                    Health = 100;
                    Strength = 12;
                    Defense = 10;
                    Skills.Add(new Skill("Tiro de Concussão", DamageType.Impact, 20, 0, false));
                    Skills.Add(new Skill("Tiro Penetrante", DamageType.Puncture, 16, 50, false));
                    Skills.Add(new Skill("Tiro Inflamável", DamageType.Explosion, 10, 0, false));
                    Advantages.Add(DamageType.Impact);
                    Advantages.Add(DamageType.Puncture);
                    Disadvantages.Add(DamageType.Bleed);
                    Disadvantages.Add(DamageType.Fire);
                    break;
            }
        }
        private void pickName()
        {
            Random random = new Random();
            switch (PlayerClass)
            {
                case PlayerClass.Diver:
                    int pickedDiverName = random.Next(4);
                    switch (pickedDiverName)
                    {
                        case 0:
                            Name = "Orion Deepwater";
                            break;
                        case 1:
                            Name = "Coraline Deepsea";
                            break;
                        case 2:
                            Name = "Nauticus Stormrider";
                            break;
                        case 3:
                            Name = "Triton Wavebreaker";
                            break;
                    }
                    break;

                case PlayerClass.Bombardier:
                    int pickedBombName = random.Next(4);
                    switch (pickedBombName)
                    {
                        case 0:
                            Name = "Ember Blaststone";
                            break;
                        case 1:
                            Name = "Magnus Thunderstrike";
                            break;
                        case 2:
                            Name = "Flint Ironsides";
                            break;
                        case 3:
                            Name = "Archer Duskwood";
                            break;
                    }
                    break;

                case PlayerClass.Musketeer:
                    int pickedMuskName = random.Next(5);
                    switch (pickedMuskName)
                    {
                        case 0:
                            Name = "Valeria Silverthorn";
                            break;
                        case 1:
                            Name = "Griffin Blackwood";
                            break;
                        case 2:
                            Name = "Roderick Swiftblade";
                            break;
                        case 3:
                            Name = "Isabella Moonshadow";
                            break;
                        case 4:
                            Name = "Victor Crossfire";
                            break;
                    }
                    break;
            }
        }
    }
}
