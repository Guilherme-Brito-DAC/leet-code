using System.Linq;

public class Solution
{
	public int ArraySign(int[] nums)
	{
		if (nums.Any(c => c.Equals(0)))
			return 0;

		if (nums.Where(c => c <= -1).Count() % 2 == 0)
			return 1;
		else
			return -1;
	}
}