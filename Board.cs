namespace tic_tac_toe{
    internal class Board
{
    public char[,] Elements { get; set; }
    public Board()
    {
        Elements = new char[3, 3];
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                Elements[i, j] = ' ';
            }
        }
    }
    public char this[int i, int j] { get { return Elements[i, j]; } set { Elements[i, j] = value; } }
    public override string ToString()
    {
        return $" --- --- --- \n" +
               $"| {Elements[0, 0]} | {Elements[0, 1]} | {Elements[0, 2]} |\n" +
               $"|---|---|---|\n" +
               $"| {Elements[1, 0]} | {Elements[1, 1]} | {Elements[1, 2]} |\n" +
               $"|---|---|---|\n" +
               $"| {Elements[2, 0]} | {Elements[2, 1]} | {Elements[2, 2]} |\n" +
               $" --- --- --- \n";
    }
}
}