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

        public Player FirstPhase(Player player, Enemy monster, Enemy boss)
        {
            string phaseText = $"Rumores dizem que o tesouro está escondido em uma ilha remota, cercada de perigosas criaturas marinhas." +
                               $"Nossos heróis partem em um barco robusto, navegando pelos mares tempestuosos até alcançarem a ilha lendária. " +
                               $"No entanto, durante o trajeto, eles são confrontados por inimigos formidáveis que protegem ferozmente o tesouro.\n" +
                               $"O primeiro desafio é enfrentar o Megalodon, um gigantesco tubarão pré-histórico que ameaça afundar o barco com seus " +
                               $"poderosos ataques. O mergulhador mergulha nas profundezas, " +
                               $"enfrentando o Megalodon em um combate tenso e mortal.";

            batles.DisplayTextLetterByLetter(phaseText, 1);

            player = batles.Combat(player, monster);

            imgsAsc.Megalodon();

            string txt1 = $"Para impedir que você chegue ao tesouro Megalodon envia seu exercito de tubarões brancos para ataca-lo\n" +
                          $"Você precisa reagir escolha uma habilidae para ataca-lo tambem: ";

            batles.DisplayTextLetterByLetter(txt1, 1);

            player.Health = player.TakeSkillDamage(batles.ChangeSkill(player), player.Defense, player.Health);

            //metodo de batalha



            //FASE 1:MEGALODON ENVIA TUBAROES BRANCOS

            //player = batles.Combat(player, new Shark());
            //batles.ShowPlayer(player);

            //FASE 1: BOSS MEGALODON
            player = batles.Combat(player, boss);
            batles.ShowPlayer(player);

            return player;
        }
        public Player SecondPhase(Player player, Enemy monster, Enemy boss)
        {
            string phaseText = $"Após derrotar o Megalodon, os heróis continuam sua jornada e se deparam com a Sereia Encantada, " +
                               $"uma criatura bela e traiçoeira que tenta seduzir e enfeitiçar a tripulação. ";

            batles.DisplayTextLetterByLetter(phaseText, 1);

            player = batles.Combat(player, monster);

            imgsAsc.Mermaid();

            string txt1 = $"Para impedir que você chegue ao tesouro Megalodon envia seu exercito de tubarões brancos para ataca-lo\n" +
                          $"Você precisa reagir escolha uma habilidae para ataca-lo tambem: ";

            batles.DisplayTextLetterByLetter(txt1, 1);

            player.Health = player.TakeSkillDamage(batles.ChangeSkill(player), player.Defense, player.Health);

            //metodo de batalha



            //FASE 1:MEGALODON ENVIA TUBAROES BRANCOS

            //player = batles.Combat(player, new Shark());
            //batles.ShowPlayer(player);

            //FASE 1: BOSS MEGALODON
            player = batles.Combat(player, boss);
            batles.ShowPlayer(player);

            return player;
        }

    }
}
