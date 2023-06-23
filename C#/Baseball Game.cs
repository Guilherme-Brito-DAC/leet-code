using System.Collections.Generic;

public class Solution
{
    public int CalPoints(string[] operations)
    {
        int total = 0;
        List<int> pontos = new List<int>();

        for (int i = 0; i < operations.Length; i++)
        {
            string operacao = operations[i];

            switch (operacao)
            {
                case "C":
                    pontos.RemoveAt(pontos.Count - 1);
                    break;

                case "D":
                    pontos.Add(pontos.Last() * 2);
                    break;

                case "+":
                    pontos.Add(pontos.SkipLast(1).Last() + pontos.Last());
                    break;

                default:
                    pontos.Add(int.Parse(operacao));
                    break;
            }
        }

        return pontos.Sum();
    }
}