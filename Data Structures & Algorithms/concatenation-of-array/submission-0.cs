public class Solution {
    public int[] GetConcatenation(int[] nums) {
        int[] ans = new int [nums.Length * 2];

        for(int index = 0; index < nums.Length; index++){
            ans[index] = nums[index];
        }

        int i = 0;
        for(int index = nums.Length; index < ans.Length; index++){
            ans[index] = nums[i];
            i++;
        }

        return ans;
    }
}