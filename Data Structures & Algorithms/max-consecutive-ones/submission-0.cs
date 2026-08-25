public class Solution {
    public int FindMaxConsecutiveOnes(int[] nums) {
        int max = 0;
        int curr = 0;
        foreach(int num in nums)
        {
            
            if (num == 1)
            {
                curr++;
                Console.WriteLine("cur ==" + curr);
                if (curr >= max)
                {
                    max = curr;
                }
            }
            else
            {
                curr = 0;
            }
        }
        return max;
    }
}