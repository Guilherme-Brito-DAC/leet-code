using System.Collections.Generic;
using System.Linq;

public class Solution
{
    public char FindTheDifference(string s, string t)
    {
        List<char> letrasT = t.ToCharArray().ToList();

        for (int i = 0; i < s.Length; i++)
        {
            if (letrasT.Contains(s[i]))
                letrasT.Remove(s[i]);
        }

        return letrasT.First();
    }
}