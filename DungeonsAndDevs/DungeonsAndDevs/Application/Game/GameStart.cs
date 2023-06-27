using System;
using System.Threading;
using DungeonsAndDevs.Application.Game.Batles;
using DungeonsAndDevs.Application.Game.ImgsAsc;
using DungeonsAndDevs.Entidades.Characters.Players;
using DungeonsAndDevs.Entities.Characters;
using DungeonsAndDevs.Utils;

namespace DungeonsAndDevs.Application.Game
{
    public class GameStart
    {
        public GameStart() { }

        ImagesAsc imgsAsc = new ImagesAsc() { };
        Batle batles = new Batle();

        public void Start()
        {
            //imgsAsc.Logo();
            //string initTxt = "Em um mundo vasto e misterioso, um dos três destemidos aventureiros " +
            //                 "- o mergulhador experiente, o artilheiro especialista em explosivos e o mosqueteiro habilidoso " +
            //                 "- embarcam em uma expedição em busca do lendário \"Tesouro das Profundezas\". ";


            //DisplayTextLetterByLetter(initTxt, 1);
            //int choose = ChangeCharacter();

            //escolha do personagem e definição do nome
            Player player = new Player();
            player.PlayerClass = (PlayerClass)1;
            //player.Name = ChangeName();
            player.Name = "Teste";
            player.SetInitialStats();
            string showPlayer = $"Esses são os dados do seu herói: \n";
            batles.ShowPlayer(player); 

            DisplayTextLetterByLetter(showPlayer, 1);

            string fase1 = $"Rumores dizem que o tesouro está escondido em uma ilha remota, cercada de perigosas criaturas marinhas." +
                $"Nossos heróis partem em um barco robusto, navegando pelos mares tempestuosos até alcançarem a ilha lendária. " +
                $"No entanto, durante o trajeto, eles são confrontados por inimigos formidáveis que protegem ferozmente o tesouro.\n" +
                $"O primeiro desafio é enfrentar o Megalodon, um gigantesco tubarão pré-histórico que ameaça afundar o barco com seus " +
                $"poderosos ataques. O mergulhador mergulha nas profundezas, " +
                $"enfrentando o Megalodon em um combate tenso e mortal.";

            ShowPlayer(player); 
            DisplayTextLetterByLetter(fase1, 1);

            imgsAsc.Megalodon();

            string txt1 = $"Para impedir que você chegue ao tesouro Megalodon envia seu exercito de tubarões brancos para ataca-lo\n" +
                          $"Você precisa reagir escolha uma habilidae para ataca-lo tambem: ";

            DisplayTextLetterByLetter(txt1, 1);
            player.Health = player.TakeSkillDamage(ChangeSkill(player), player.Defense, player.Health);

            ShowPlayer(player);
            //metodo de batalha
            Console.ReadLine();



            //FASE 1:MEGALODON ENVIA TUBAROES BRANCOS


            //FASE 1: BOSS MEGALODON

            //FASE 2: SEREIA ENVIA CARDUME DE TAINHA

            //FASE 2: BOSS SEREIA

            //FASE 3: POLVO GIGA ENVIA AGUAS VIVAS

            //FASE 3: BOSS POLVO GIGA

            //EXIBIR XP, PONTOS, VIDA ETC...

            Console.WriteLine();
        }
    }
}
