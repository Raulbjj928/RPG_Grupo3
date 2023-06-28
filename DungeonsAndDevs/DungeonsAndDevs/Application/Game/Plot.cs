using DungeonsAndDevs.Application.Game.Batles;
using DungeonsAndDevs.Application.Game.ImgsAsc;
using DungeonsAndDevs.Entidades.Characters.Players;
using DungeonsAndDevs.Entities.Characters.Enemies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonsAndDevs.Application.Game
{
    public class Plot
    {
        ImagesAsc imgsAsc = new ImagesAsc() { };
        Batle batles = new Batle();

        Enemy shark = new Shark();
        public Player StartOfTheAdventure(Player player) 
        {
            imgsAsc.Logo();
            string initTxt = "Em um mundo vasto e misterioso, um dos três destemidos aventureiros " +
                             "- o mergulhador experiente, o artilheiro especialista em explosivos e o mosqueteiro habilidoso " +
                             "- embarcam em uma expedição em busca do lendário \"Tesouro das Profundezas\". ";


            batles.DisplayTextLetterByLetter(initTxt, 1);
            int choose = batles.ChangeCharacter();

            //escolha do personagem e definição do nome
            player.PlayerClass = (PlayerClass)1;
            player.Name = batles.ChangeName();
            //player.Name = "Teste";
            player.SetInitialStats();
            string showPlayer = $"Esses são os dados do seu herói: \n";
            batles.ShowPlayer(player);

            batles.DisplayTextLetterByLetter(showPlayer, 1);
            return player;
        }

        public void FirstPhase()
        {

        }

    }
}
