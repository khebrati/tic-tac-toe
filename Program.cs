global using static System.Console;
global using static System.Convert;
global using System;
namespace tic_tac_toe
{
    internal class PlayGround {
        static void Main(string[] args)
        {
            WriteLine("welcome!");
            WriteLine("what do you want to do?");
            WriteLine("1.start a new game");
            if (ToInt32(ReadLine()) == 1){
                Game game = new();
                game.Start();
            }
        }
    }
    
    
    
    
    
}