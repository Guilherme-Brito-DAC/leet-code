public class Solution {
    public int MaximumWealth(int[][] accounts) {
       return return accounts.Select(c => c.Sum()).Max();
    }
}