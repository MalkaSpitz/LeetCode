class Solution:
    def firstUniqChar(self, s: str) -> int:
        d = {}
        for c in s:
            d[c] = d.get(c,0)+1
        for c in range(len(s)):
            if d[s[c]] == 1:
                return c
        return -1
