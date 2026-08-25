class Solution:
    def maxProfit(self, prices: List[int]) -> int:
        min = prices[0]
        profit = 0
        for x in range(1,len(prices)):
            print(f"loop {x}")
            if(min > prices[x]):
                #Assign new min, meaning we buy stock
                min = prices[x]
            #In this stage, we analyze the current value and compare what profit we make
            current = prices[x]

            print(f"min={min}")
            print(f"max={current}")
            if(current-min > profit):
                profit = current-min

            print(profit)
        return profit
                     
        