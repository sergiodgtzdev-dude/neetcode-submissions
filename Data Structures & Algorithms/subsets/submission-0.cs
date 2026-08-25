public class Solution {
    public List<List<int>> Subsets(int[] nums) {
        List<List<int>> subsets = new List<List<int>>();
        subsets.Add(new List<int>());

        foreach (int num in nums) {
            int currentSize = subsets.Count;
            for (int i = 0; i < currentSize; i++) {
                List<int> newList = new List<int>(subsets[i]);
                newList.Add(num);
                subsets.Add(newList);
            }
        }

        return subsets;
    }
}