namespace tic_tac_toe{
    internal class User : Player
{
    public User(Game game) : base( game) { }
    public void Play()
    {
            while(true)
            {
                int row;
                int col;
                Write("select: ");
                int read = ToInt32(ReadLine());
                col = read % 10;
                row = (read - col) / 10;
                if (Game.Board[row,col] != ' ')
                {
                    WriteLine("It's not empty");
                }
                else
                {
                    Game.Board[row, col] = 'X';
                    break;
                }
            }
    }
}
}