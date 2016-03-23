using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FantasyRPG
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetWindowSize(64, 48);
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Game game = new Game();
            game.StartGame();
        }
    }
}
