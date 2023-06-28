using DungeonsAndDevs.Application.Game.Batles;
using DungeonsAndDevs.Application.Game.ImgsAsc;
using DungeonsAndDevs.Entidades.Characters.Players;
using DungeonsAndDevs.Entities.Characters.Enemies;
using System;

namespace DungeonsAndDevs.Application.Game
{
    public class Plot
    {
        ImagesAsc imgsAsc = new ImagesAsc() { };
        Batle batles = new Batle();
        public Player StartOfTheAdventure(Player player) 
        {
            imgsAsc.Logo();

            imgsAsc.GP3();

            string initTxt = "Em um mundo vasto e misterioso, um dos três destemidos aventureiros ....\n" +
                             "o MERGULHADOR experiente, o ARTILHEIRO especialista em explosivos e o MOSQUETEIRO habilidoso \n" +
                             "embarcam em uma expedição em busca do lendário \"Tesouro das Profundezas\".\n ";

            batles.DisplayTextLetterByLetter(initTxt, 1);

            int choose = batles.ChangeCharacter();

            player.PlayerClass = (PlayerClass)choose;

            player.Name = batles.ChangeName();

            player.SetInitialStats();

            string showPlayer = $"Esses são os dados do seu herói: \n";

            batles.DisplayTextLetterByLetter(showPlayer, 1);

            batles.ShowPlayer(player);

            return player;
        }

        public Player FirstPhase(Player player, Enemy monster, Enemy boss)
        {
            string phaseText = $"Rumores dizem que o tesouro está escondido em uma ilha remota, cercada de perigosas criaturas marinhas." +
                               $"Nossos heróis partem em um barco robusto, navegando pelos mares tempestuosos até alcançarem a ilha lendária. " +
                               $"No entanto, durante o trajeto, eles são confrontados por inimigos formidáveis que protegem ferozmente o tesouro.\n" +
                               $"O primeiro desafio é enfrentar o Megalodon, um gigantesco tubarão pré-histórico que ameaça afundar o barco com seus " +
                               $"poderosos ataques. Você ira enfrentar um combate tenso e mortal.";

            batles.DisplayTextLetterByLetter(phaseText, 1);

            imgsAsc.Megalodon();

            player = batles.Combat(player, monster);
            player.Health += 50;
            Console.WriteLine($"Você recebeu o elixir da vida, restaurando sua vida em 50 pontos...");
            Console.WriteLine($"VIDA : {player.Health}");

            Console.WriteLine($"XP Adquirido/ XP total: {monster.EnemyBaseXP}/ {player.XP} ");

            player = batles.Combat(player, boss);

            player.Health += 50;
            Console.WriteLine($"Você recebeu o elixir da vida, restaurando sua vida em 50 pontos...");
            Console.WriteLine($"VIDA : {player.Health}");

            batles.ShowPlayer(player);

            Console.WriteLine($"XP Adquirido/ XP total: {monster.EnemyBaseXP}/ {player.XP} ");

            return player;
        }
        public Player SecondPhase(Player player, Enemy monster, Enemy boss)
        {
            string phaseText = $"Após derrotar o Megalodon, os heróis continuam sua jornada e se deparam com a Sereia Encantada, " +
                               $"uma criatura bela e traiçoeira que tenta seduzir e enfeitiçar a tripulação. ";

            batles.DisplayTextLetterByLetter(phaseText, 1);

            imgsAsc.Mermaid();

            player = batles.Combat(player, monster);

            Console.WriteLine($"XP Adquirido/ XP total: {monster.EnemyBaseXP}/ {player.XP} ");

            player = batles.Combat(player, boss);

            Console.WriteLine($"XP Adquirido/ XP total: {monster.EnemyBaseXP}/ {player.XP} ");

            player = batles.Combat(player, boss);
            batles.ShowPlayer(player);

            return player;
        }
        
        public Player ThirdPhase(Player player, Enemy monster, Enemy boss)
        {
            string phaseText = $"O {player.PlayerClass} utiliza suas habilidades especiais para proteger seus companheiros contra os encantamentos da sereia e " +
                $"vence seus guardiões marinhos..." +
                $"\nFinalmente, ao se aproximarem da ilha, um Polvo Gigante furioso emerge das profundezas, com seus tentáculos poderosos ameaçando destruir o barco. " +
                $"Os heróis precisam unir suas habilidades e estratégias para enfrentar o monstro ...\n";

            batles.DisplayTextLetterByLetter(phaseText, 1);

            imgsAsc.Oktopus();

            player = batles.Combat(player, monster);

            Console.WriteLine($"XP Adquirido/ XP total: {monster.EnemyBaseXP}/ {player.XP} ");

            player = batles.Combat(player, boss);

            Console.WriteLine($"XP Adquirido/ XP total: {monster.EnemyBaseXP}/ {player.XP} ");

            player = batles.Combat(player, boss);
            batles.ShowPlayer(player);

            return player;
        }

    }
}
