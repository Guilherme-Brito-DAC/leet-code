using System.Linq;

public class Solution
{
    public string MergeAlternately(string word1, string word2)
    {
        string output = "";
        int longerLenght = word1.Length >= word2.Length ? word1.Length : word2.Length;

        for (int x = 0; x < longerLenght; x++)
        {
            if (x < word1.Length)
                output += word1[x];

            if (x < word2.Length)
                output += word2[x];
        }

        return output;
    }
}