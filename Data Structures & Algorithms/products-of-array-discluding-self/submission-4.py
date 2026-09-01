class Solution:
    def productExceptSelf(self, nums: List[int]) -> List[int]:
        i = 0
        j = 0
        results = []
        tmp = 1
        total = 1
        zero_count = 0
        
        for x in nums:
            if x != 0:
                total *= x
            if x == 0:
                zero_count += 1

        # print(total)

        #Creating the list
        for x in nums:
            if x == 0:
                results.append(total if zero_count == 1 else 0)
            elif zero_count > 0:
                results.append(0)
            else:
                results.append(total // x)

        # print(results)
        
        return results
