import pprint

class Solution:
    def groupAnagrams(self, strs: List[str]) -> List[List[str]]:
        anagrams = {}
        x = 0
        j = 0

        for string in strs:
            key ="".join(sorted(string))
            if(key not in anagrams.keys()):
                anagrams[key] = list()
                anagrams.get(key).append(string)
            else:
                anagrams.get(key).append(string)
                continue

        final = [anagrams[value] for value in anagrams.keys()]
        # print(final)
        return final