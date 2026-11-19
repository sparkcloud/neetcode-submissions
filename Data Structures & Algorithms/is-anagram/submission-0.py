class Solution:
    def isAnagram(self, s: str, t: str) -> bool:
        
        if len(s) != len(t):
            return False

        sortedS = {}
        sortedT = {}

        for x in range(len(s)):
            sortedS[s[x]] = 1 + sortedS.get(s[x],0)
            sortedT[t[x]] = 1 + sortedT.get(t[x],0)
        for x in sortedS:
            if sortedS[x] != sortedT.get(x,0):
                return False
        return True

        