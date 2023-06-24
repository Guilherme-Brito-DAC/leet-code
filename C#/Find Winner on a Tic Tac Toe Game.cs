using System.Collections.Generic;
using System.Linq;

public class Solution
{
    public string Tictactoe(int[][] moves)
    {
        if (moves.Count() < 5)
            return "Pending";

        int[][] A = moves.Where((s, i) => i % 2 == 0).ToArray();
        int[][] B = moves.Where((s, i) => i % 2 != 0).ToArray();

        if (VerificaGanhador(A))
            return "A";

        if (VerificaGanhador(B))
            return "B";

        if (moves.Count() == 9)
            return "Draw";
        else
            return "Pending";
    }

    public bool VerificaGanhador(int[][] Marcados)
    {
        for (int i = 0; i <= 2; i++)
        {
            if (Marcados.Where(g => ((g[0] == 0 && g[1] == i) ||
                        (g[0] == 1 && g[1] == i) ||
                        (g[0] == 2 && g[1] == i))).Count() == 3)
            {
                return true;
            }
        }

        for (int i = 0; i <= 2; i++)
        {
            if (Marcados.Where(g => ((g[0] == i && g[1] == 0) ||
                        (g[0] == i && g[1] == 1) ||
                        (g[0] == i && g[1] == 2))).Count() == 3)
            {
                return true;
            }
        }

        if (Marcados.Where(g => ((g[0] == 0 && g[1] == 0) ||
            (g[0] == 1 && g[1] == 1) ||
            (g[0] == 2 && g[1] == 2))).Count() == 3)
        {
            return true;
        }

        if (Marcados.Where(g => ((g[0] == 2 && g[1] == 0) ||
            (g[0] == 1 && g[1] == 1) ||
            (g[0] == 0 && g[1] == 2))).Count() == 3)
        {
            return true;
        }

        return false;
    }
}
