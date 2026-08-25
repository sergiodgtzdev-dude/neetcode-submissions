public class Solution {
    public int RemoveElement(int[] nums, int val) 
    {
        int writeIndex = 0;
        for(int readIndex = 0; readIndex < nums.Length; readIndex++){
            
            Console.WriteLine(String.Join(" ", nums));
            Console.WriteLine("readIndex = " + readIndex);
            Console.WriteLine("writeIndex= " + writeIndex);
            if (nums[readIndex] != val){
                nums[writeIndex] = nums[readIndex];
                writeIndex++;
            }
        }

        return writeIndex;
    }

}