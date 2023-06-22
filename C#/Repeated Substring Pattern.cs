public class Solution
{
    public bool RepeatedSubstringPattern(string s)
    {
        if (s.Length <= 1 || string.IsNullOrWhiteSpace(s))
            return false;

        for (int i = 0; i < s.Length / 2; i++)
        {
            string possivelParte = s.Substring(0, i + 1);
            string[] parte = s.Split(possivelParte, StringSplitOptions.RemoveEmptyEntries);

            if (!parte.Any()) return true;
        }

        return false;
    }
}