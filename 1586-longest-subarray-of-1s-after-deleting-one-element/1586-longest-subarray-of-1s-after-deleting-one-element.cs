public class Solution {
    public int LongestSubarray(int[] nums) {
        int max=0;
        int right=0,left=0;
        bool hasZero=false;
        for(;left<nums.Length;left++){
            if(nums[left]==0){
                if(hasZero){
                    while(nums[right]!=0){
                        right++;
                    }
                    right++;
                }
                else hasZero=true;
            }
            max=Math.Max(max,left-right);
        }
        return max;
    }
}