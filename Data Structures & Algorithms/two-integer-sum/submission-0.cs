public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        //Two pointer approach
        int[] indexes = new int[2];
        int i = 0;
        int j = nums.Length-1;

        while(nums[i] + nums[j] != target){

            if (nums[i] + nums[j] != target){
                j--;
                if(i == j){
                    i++;
                    j = nums.Length-1;
                }
            }

        }
        indexes[0] = i;
        indexes[1] = j;
        return indexes;
    }
}
