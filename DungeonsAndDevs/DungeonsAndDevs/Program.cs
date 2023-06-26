using DungeonsAndDevs.Application.Game;
using DungeonsAndDevs.Application.Game.ImgsAsc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonsAndDevs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GameStart game = new GameStart();
            ImagesAsc image = new ImagesAsc();

            game.Start();
            Console.ReadKey();
        }
    }
}
