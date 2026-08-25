public class Solution {
    public void SortColors(int[] nums) {
        int[] counts = [0,0,0];
        foreach(int num in nums){
            if (num == 0)
                counts[0]++;
            else if(num == 1)
                counts[1]++;
            else
                counts[2]++;
        }

        int i = 0;
        for(int n = 0; n < counts.Length; n++){
            for(int j = 0; j < counts[n]; j++){
                nums[i] = n;
                i++;
            }
        }
    }
}