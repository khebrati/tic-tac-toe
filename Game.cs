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
        WriteLine(Board);
        while(!IsEqual() && !User.HasWon('X') && !Bot.HasWon('O'))
        {
            StartOneRound();
        }
        if(User.HasWon('X'))
            {
                WriteLine("You won!");
            }
        else if(Bot.HasWon('O'))
            {
                WriteLine("You failed");
            }
            else
            {
                WriteLine("Equal!");
            }
    }
    public void StartOneRound()
    {
        Bot.Play();
        User.Play();
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