using static System.Console;
using static System.Convert;
namespace tic_tac_toe
{
    internal class PlayGround {
        static void main(string[] args)
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
    internal class Game
    {
        private char[,] board;
        private User user;
        private Bot bot;
        public Game(char[,] board)
        {
            this.board = board;
        }
        public Game() {
            this.board = new char[3,3] ;
        }
    }
}