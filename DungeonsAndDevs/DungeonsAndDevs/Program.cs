using DungeonsAndDevs.Application.Game;
using System;

namespace DungeonsAndDevs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GameStart game = new GameStart();

            game.Start();
            Console.ReadKey();
        }
    }
}
