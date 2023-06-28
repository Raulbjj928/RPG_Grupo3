using System;
using DungeonsAndDevs.Application.Game.ImgsAsc;
using DungeonsAndDevs.Entidades.Characters.Players;
using DungeonsAndDevs.Entities.Characters.Enemies;

namespace DungeonsAndDevs.Application.Game
{
    public class GameStart
    {
        public GameStart() { }

        ImagesAsc imgsAsc = new ImagesAsc() { };
        Plot plot = new Plot();

        public void Start()
        {
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.White;
            Player player = new Player();
            player = plot.StartOfTheAdventure(player);

            Console.BackgroundColor = ConsoleColor.DarkMagenta;
            Console.ForegroundColor = ConsoleColor.White;
            player = plot.FirstPhase(player, new Shark(), new Megalodon());
            
            Console.BackgroundColor = ConsoleColor.DarkGray;
            Console.ForegroundColor = ConsoleColor.White;
            player = plot.SecondPhase(player, new Mullet(), new Mermaid());

            Console.BackgroundColor = ConsoleColor.Red;
            Console.ForegroundColor = ConsoleColor.White;
            player = plot.ThirdPhase(player, new Jellyfish(), new Oktopus());

            Console.BackgroundColor = ConsoleColor.Green;
            imgsAsc.Win();


            Console.ReadLine();
        }
    }
}
