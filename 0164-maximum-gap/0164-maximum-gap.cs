public class Solution {
    public int MaximumGap(int[] nums) {
        if(nums.Length==1) return 0;
        Array.Sort(nums);
        int max=0;
        for(int i=0;i<nums.Length-1;i++){
            max=Math.Max(nums[i+1]-nums[i],max);
        }
        return max;
    }
}