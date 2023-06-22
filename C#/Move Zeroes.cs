public class Solution
{
    public int LengthOfLastWord(string s)
    {
        s = s.TrimStart().TrimEnd();

        s = string.Join(" ", s.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries));

        return s.Split(' ').Last().Length;
    }
}