// See https://aka.ms/new-console-template for more information

using System;

namespace ConweilGameOfLife
{
    static class Program
    {
        static void Main()
        {
            Game game = new Game(4, 10);
            game.RunGameConsole();
        }
    }
}