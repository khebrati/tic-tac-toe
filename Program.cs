using static System.Console;
using static System.Convert;
namespace tic_tac_toe
{
    internal class PlayGround {
        static void Main(string[] args)
        {
            WriteLine("welcome!");
            WriteLine("what do you want to do?");
            WriteLine("1.start a new game");
            WriteLine();
            if (ToInt32(ReadLine()) == 1){
                Game game = new();
            }
        }
    }
    internal class Player
    {
        
    }
    internal class Bot : Player { }
    internal class User : Player { }
    internal class Board {
        public char[,] elements { get; set; }
        public char this[char c0,char c1] { get { return elements[c0,c1]; } set { elements[c0,c1] = value; } }
        
    }
    internal class Game
    {
        public Board board { get; set; }
        public User user { get; set; }
        public Bot bot { get; set; }
        
        
    }
}