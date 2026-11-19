public class Solution {
    public int CalPoints(string[] operations) {
        
        Stack<int> stack = new Stack<int>();

        foreach (var x in operations){

            if (x == "+"){
                int top = stack.Pop();
                int newTop = top + stack.Peek();
                stack.Push(top);
                stack.Push(newTop);
            } else if (x == "D") {
                stack.Push(2 * stack.Peek());
            }else if (x == "C"){
                stack.Pop();
            }else
                stack.Push(int.Parse(x));

        }

        int total = 0;
        foreach (var val in stack) {
            total += val;
        }

        return total;
    }
}