using System.Linq;

public class Solution
{
	public bool IsMonotonic(int[] nums)
	{
		bool Aumentando = true;
		bool Descendo = true;

		for (int i = 0; i < nums.Length - 1; i++)
		{
			if (nums[i] < nums[i + 1])
				Descendo = false;
			else if (nums[i] > nums[i + 1])
				Aumentando = false;
		}

		return Aumentando || Descendo;
	}
}