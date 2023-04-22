namespace tic_tac_toe{
    internal class Game
{
    public Board Board { get; set; }
    public User User { get; set; }
    public Bot Bot { get; set; }
    public Game()
    {
        Board = new();
        User = new(this);
        Bot = new(this);
    }
    public void Start()
    {
        while(!IsEqual() && !User.HasWon('X') && !Bot.HasWon('O'))
        {
                Bot.Play();
                WriteLine(Board);
                if (!Bot.HasWon('O'))
                {
                    User.Play();
                }
        }
        if(User.HasWon('X'))
            {
                WriteLine(Board);
                WriteLine("You won!");
            }
        else if(Bot.HasWon('O'))
            {
                WriteLine(Board);
                WriteLine("You failed");
            }
            else
            {
                WriteLine(Board);
                WriteLine("Equal!");
            }
    }
    public bool IsEqual()
    {
        for(int i = 0;i<3;i++)
            {
                for(int j = 0;j<3;j++)
                {
                    if (Board[i,j] == ' ')
                    {
                        return false;
                    }
                }
            }
        return true;
    }

}
}