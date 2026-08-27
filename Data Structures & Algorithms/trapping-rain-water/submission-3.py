
class Solution:

    def build_prefix_max(self, index, height):
        max_val = 0
        for x in range(0, index):
            if(height[x] > max_val):
                max_val = height[x]
        return max_val

    def build_suffix_max(self, index, height):
        max_val = 0
        for x in range(index + 1, len(height)):
            if(height[x] > max_val):
                max_val = height[x]
        return max_val

    def trap(self, height: List[int]) -> int:
        if len(height) <= 2:
            return 0

        total_water = 0
        
        # Precompute prefix and suffix max to avoid O(n^2) complexity and TLE
        n = len(height)
        prefix_max = [0] * n
        suffix_max = [0] * n
        
        curr_max = 0
        for i in range(n):
            prefix_max[i] = curr_max
            curr_max = max(curr_max, height[i])
            
        curr_max = 0
        for i in range(n - 1, -1, -1):
            suffix_max[i] = curr_max
            curr_max = max(curr_max, height[i])

        for i in range(0, len(height)):
            if(i == 0 or i == len(height) - 1):
                continue
            max_l = prefix_max[i]
            max_r = suffix_max[i]
            water_trapped = min(max_l, max_r) - height[i]
            if(water_trapped > 0):
                total_water += water_trapped

        return total_water
