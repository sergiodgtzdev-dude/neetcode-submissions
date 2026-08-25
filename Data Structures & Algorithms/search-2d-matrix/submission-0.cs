public class Solution {
    public bool SearchMatrix(int[][] matrix, int target) {
        bool contains_target = false;
        foreach(int[] arr in matrix){
            Console.WriteLine("target =" + target);
            Console.WriteLine("arr[arr.Length-1] =" + arr[arr.Length-1]);
            if(target > arr[arr.Length-1])
                continue;
            else{
                Console.WriteLine("array_chosen = " + string.Join(" ", arr));
                contains_target = BinarySearch(arr, target);
                if(contains_target == true)
                    return true;
            }
        }
        return contains_target;
    }

    public bool BinarySearch(int[] arr, int target){
        int l = 0;
        int r = arr.Length -1;

        while(l <= r){
            
            int mid = (l+r) / 2;
            Console.WriteLine("arr[" + mid +"] = " +arr[mid]);
            if(target > arr[mid]){
                l = mid + 1;
            }
            else if(target < arr[mid]){
                r = mid - 1;
            }
            else
                return true;
        }
        return false;
    }
}
