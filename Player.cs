
namespace tic_tac_toe{
    internal class Player
{
    public Game Game;
    public Player(Game game)
    {
        Game = game;
    }
    public bool HasWon(char c)
        {
            //horizontal
            if (Game.Board[0,0] == c && Game.Board[0,1] == c && Game.Board[0, 2] == c)
            {
                return true;
            }
            if (Game.Board[1, 0] == c && Game.Board[1, 1] == c && Game.Board[1, 2] == c)
            {
                return true;
            }
            if (Game.Board[2, 0] == c && Game.Board[2, 1] == c && Game.Board[2, 2] == c)
            {
                return true;
            }
            //vertical
            if (Game.Board[0, 0] == c && Game.Board[1,0] == c && Game.Board[2,0] == c)
            {
                return true;
            }
            if (Game.Board[0, 1] == c && Game.Board[1, 1] == c && Game.Board[2, 1] == c)
            {
                return true;
            }
            if (Game.Board[0, 2] == c && Game.Board[1, 2] == c && Game.Board[2, 2] == c)
            {
                return true;
            }
            //other
            if (Game.Board[0, 0] == c && Game.Board[1, 1] == c && Game.Board[2, 2] == c)
            {
                return true;
            }
            if (Game.Board[0, 2] == c && Game.Board[1, 1] == c && Game.Board[2, 0] == c)
            {
                return true;
            }
            return false;
        }
}
}