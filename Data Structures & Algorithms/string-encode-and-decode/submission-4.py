class Solution:
    def encode(self, strs: List[str]) -> str:
        if not strs:
            return chr(257)

        encoded_str = ""
        for string in strs:
            tmp = ""
            for c in string:
                t = ord(c)
                t += 2
                if t > 256:
                    t = t % 256
                tmp += chr(t)
            encoded_str += str(len(tmp)) + ":" + tmp

        return encoded_str

    def decode(self, s: str) -> List[str]:
        if s == chr(257):
            return []

        strs = []
        i = 0
        while i < len(s):
            j = s.find(":", i)
            length = int(s[i:j])
            word_encoded = s[j+1:j+1+length]
            word = ""
            for c in word_encoded:
                tmp = ord(c)
                tmp -= 2
                if tmp < 0:
                    tmp += 256
                word += chr(tmp)
            
            strs.append(word)
            i = j + 1 + length
        
        return strs