class Solution:
    def isAnagram(self, s: str, t: str) -> bool:
        
        if(len(s) != len(t)):
            return False

        #Use hashmaps to count
        sh = {}
        th = {}
        for c in s:
            sh[c] = sh.get(c, 0) + 1

        for c in t:
            th[c] = th.get(c, 0) + 1

        for key in sh:
            if(sh[key] != th.get(key, 0)):
                return False

        return True
