public class Solution
{
    public bool JudgeCircle(string moves)
    {
        var movimentos = moves.ToCharArray();
        int x = 0;
        int y = 0;

        foreach (var movimento in movimentos)
        {
            switch (movimento)
            {
                case 'U':
                    y++;
                    break;

                case 'D':
                    y--;
                    break;

                case 'L':
                    x--;
                    break;

                case 'R':
                    x++;
                    break;

                default:
                    break;
            }
        }

        return x == 0 && y == 0;
    }
}
