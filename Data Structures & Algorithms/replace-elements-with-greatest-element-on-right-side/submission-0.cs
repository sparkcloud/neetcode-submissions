public class Solution {
    public int[] ReplaceElements(int[] arr) {
        int maxRight = -1; // Tracks the greatest element seen to the right

        // Traverse backwards from the last element to the first
        for (int i = arr.Length - 1; i >= 0; i--) {
            int current = arr[i];   // Save the original value before overwriting
            arr[i] = maxRight;      // Replace with the greatest element to the right
            if (current > maxRight){
                maxRight = current; // Update the running maximum
            }
        }

        return arr;
    }
}