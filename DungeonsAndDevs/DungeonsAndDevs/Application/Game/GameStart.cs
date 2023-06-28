using System;
using System.Threading;
using DungeonsAndDevs.Application.Game.Batles;
using DungeonsAndDevs.Application.Game.ImgsAsc;
using DungeonsAndDevs.Entidades.Characters.Players;
using DungeonsAndDevs.Entities.Characters;
using DungeonsAndDevs.Entities.Characters.Enemies;
using DungeonsAndDevs.Utils;

namespace DungeonsAndDevs.Application.Game
{
    public class GameStart
    {
        public GameStart() { }

        ImagesAsc imgsAsc = new ImagesAsc() { };
        Batle batles = new Batle();
        Plot plot = new Plot();

        Enemy shark = new Shark();  

        public void Start()
        {            
            //escolha do personagem e definição do nome
            //Player player = plot.StartOfTheAdventure(new Player());
            Player player = new Player();
            player.PlayerClass = (PlayerClass)1;
            //player.Name = ChangeName();
            player.Name = "Teste";
            player.SetInitialStats();
            string showPlayer = $"Esses são os dados do seu herói: \n";
            batles.ShowPlayer(player);

            //FASE 1:MEGALODON ENVIA TUBAROES BRANCOS
            player = plot.SecondPhase(player, new Mullet(), new Mermaid());
            
            batles.ShowPlayer(player);
            //FASE 1: BOSS MEGALODON


           

            //FASE 3: POLVO GIGA ENVIA AGUAS VIVAS

            //FASE 3: BOSS POLVO GIGA

            //EXIBIR XP, PONTOS, VIDA ETC...

            Console.ReadLine();
        }
    }
}
