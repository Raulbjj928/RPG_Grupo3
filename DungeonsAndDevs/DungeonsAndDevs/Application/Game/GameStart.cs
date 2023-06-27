using System;
using System.Threading;
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
            ShowPlayer(player); 

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
        public void DisplayTextLetterByLetter(string txt, int vel)
        {
            foreach (char letter in txt)
            {
                Console.Write(letter);
                Thread.Sleep(vel);
            }

            Console.WriteLine();
        }
        private int ChangeCharacter()
        {
            while (true)
            {
                string txt = $"Escolha o herói que deseja para embarcar nessa aventura:\n" +
                            $"   0 - Mergulhador\n" +
                            $"   1 - Artilheiro\n" +
                            $"   2 - Mosqueteiro\n";

                DisplayTextLetterByLetter(txt, 5);

                int option = int.Parse(Console.ReadLine());

                if (option == 0 || option == 1 || option == 2)
                {
                    return option;
                }
                else
                {
                    Console.WriteLine("Escolha uma opção valida!");
                }
            }
        }
        private string ChangeName()
        {
            string txt = " Digite o nome do seu Herói lendario: ";
            DisplayTextLetterByLetter(txt, 10);
            string name = Console.ReadLine();

            return name;
        }
        private void ShowPlayer(Player player)
        {
            Console.WriteLine($" =+=+=+=+=+=+=+=+ Estatisticas do Sr(a) {player.Name} =+=+=+=+=+=+=+=+\n\n" +
                                $"                  Classe : {player.PlayerClass}\n" +
                                $"                  Vida : {player.Health} \n" +
                                $"                  Defesa : {player.Defense} \n" +
                                $"                  Força : {player.Strength} \n");

            Console.WriteLine("=+=+=+=+=+=+=+=+ Habilidades =+=+=+=+=+=+=+=+\n");

            foreach (var item in player.Skills)
            {
                Console.WriteLine($"*********** {item.Name} *********** \n" +
                                  $"                Tipo : {item.Type}\n" +
                                  $"                Dano em armadura: {item.ArmorPenetration}\n");
            }

            Console.WriteLine("=+=+=+=+=+=+=+=+ Vantagens =+=+=+=+=+=+=+=+");
            foreach (var item in player.Advantages)
            {
                Console.WriteLine(item.ToString());
            }

            Console.WriteLine("=+=+=+=+=+=+=+=+ Desvantagens =+=+=+=+=+=+=+=+");
            foreach (var item in player.Disadvantages)
            {
                Console.WriteLine(item.ToString());
            }
            Console.WriteLine("=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+\n");
        }
        private Skill ChangeSkill(Player player)
        {
            while (true)
            {
                string txt = $"Escolha a habilidade que deseja usar:\n" +
                            $"   0 - {player.Skills[0].Name}" +
                            $"   1 - {player.Skills[1].Name}\n";

                DisplayTextLetterByLetter(txt, 1);

                int option = int.Parse(Console.ReadLine());

                if (option == 0 || option == 1)
                {
                    if (option == 0) return player.Skills[0];
                    else return player.Skills[1];
                }
                else
                {
                    Console.WriteLine("Escolha uma opção valida!");
                }
            }
        }
    }
}
