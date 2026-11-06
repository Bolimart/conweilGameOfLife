// See https://aka.ms/new-console-template for more information

using System;

namespace ConweilGameOfLife
{
    static class Program
    {
        static void Main()
        {
            Console.CursorVisible = false;
            Game game = new Game(11, 5);
            game.RunGameConsole();
        }
    }
}