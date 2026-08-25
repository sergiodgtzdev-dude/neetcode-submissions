public class Solution {
    public int[] ReplaceElements(int[] arr) {
        //Use dual index approach
        int max = 0;
        for(int i=0; i < arr.Length; i++)
        {
            max = 0;
            if(i == arr.Length -1)
            {
                arr[i] = -1;
                break;
            }

            for(int j = i+1; j < arr.Length; j++)
            {
                if(arr[j] > max)
                {
                    max = arr[j];
                }
            }
            arr[i] = max;
        }
        return arr;
    }
}