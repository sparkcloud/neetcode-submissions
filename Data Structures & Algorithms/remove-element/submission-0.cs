public class Solution {
    public int RemoveElement(int[] nums, int val) {
        int k = 0; // Tracks the index for non-val elements

        for (int i = 0; i < nums.Length; i++) {
            // If the current element is not the value we want to remove
            if (nums[i] != val) {
                nums[k] = nums[i]; // Place it at the next available position
                k++;               // Increment our counter/pointer
            }
        }

        return k; // k represents the count of elements not equal to val
    }
}