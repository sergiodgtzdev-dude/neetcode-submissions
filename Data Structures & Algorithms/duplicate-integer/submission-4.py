class Solution:
    def hasDuplicate(self, nums: List[int]) -> bool:
        if len(nums) <=1:
            return False
        reviewed = set()
        prev = 0
        curr = 0
        count = 0

        for x in nums:
            if x in reviewed:
                return True
            else:
                reviewed.add(x)

        return False
            
