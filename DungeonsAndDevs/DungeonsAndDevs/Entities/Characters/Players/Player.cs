using DungeonsAndDevs.Entities.Characters;
using DungeonsAndDevs.Entities.Characters.Heros;
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
                    Diver diver = new Diver(Name);
                    FillData(diver);
                    break;

                case PlayerClass.Bombardier:
                    Bombardier bombardier = new Bombardier(Name);
                    FillData(bombardier);
                    break;

                case PlayerClass.Musketeer:
                    Musketeer musketeer = new Musketeer(Name);
                    FillData(musketeer);
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

        private void FillData(Player player)
        {
            Name = player.Name;
            Health = player.Health;
            Strength = player.Strength;
            Defense = player.Defense;
            Skills = player.Skills;
            Advantages = player.Advantages;
            Disadvantages = player.Disadvantages;

        }
    }
}
