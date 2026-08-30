class Solution:
    def topKFrequent(self, nums: List[int], k: int) -> List[int]:
        
        if len(nums) <= 1: 
            return nums

        count = {}

        for n in nums:
            count[n] = count.get(n,0) +1
        final_list = sorted(count, key=count.get)

        return final_list[-k:]

            
