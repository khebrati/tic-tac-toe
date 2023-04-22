namespace tic_tac_toe{
    internal class Bot : Player
{
    public Bot(Game game) : base(game) { }
    public void Play()
    {
            while(true)
            {
                Random rand = new();
                int row = rand.Next(0, 3);
                int col = rand.Next(0, 3);
                if (Game.Board[row,col] == ' ')
                {
                    Game.Board[row, col] = 'O';
                    break;
                }
            }
        }
}
}