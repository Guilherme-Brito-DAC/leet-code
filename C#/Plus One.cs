using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

public class Solution
{
    public int[] PlusOne(int[] digits)
    {
        BigInteger numero = BigInteger.Parse(string.Join("", digits));

        numero++;

        return numero.ToString().ToCharArray().Select(c => int.Parse(c.ToString())).ToArray();
    }
}