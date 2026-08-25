public class Solution {
    public int ClimbStairs(int n) {     
        int curr = 1;
        int prev = 0;
        int steps = 0;
        int tmp = curr;

        for(int i = n; i > 0; i--)
        {
            tmp = curr;
            curr = curr + prev;
            prev = tmp;
            Console.WriteLine("curr " + curr);
            Console.WriteLine("prev " + prev);
        }
        return curr;
    }
}
