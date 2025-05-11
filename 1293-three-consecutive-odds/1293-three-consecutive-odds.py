class Solution:
    def threeConsecutiveOdds(self, arr: List[int]) -> bool:
        for i in range(len(arr)-2):
            if arr[i]%2==1 and arr[1+i]%2==1 and arr[2+i]%2==1:
                return True
        return False
        