public class Solution {
    public int FindMaxConsecutiveOnes(int[] nums) {
        int numOfCons = 0;
        int maxCons = 0;
        
        foreach (int x in nums) {
            if (x == 1) {
                numOfCons++;
                maxCons = Math.Max(maxCons, numOfCons);
            } else {
                numOfCons = 0;
            }
        }
        
        return maxCons;
    }
}