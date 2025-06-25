public class Solution {
    public int MinSubArrayLen(int target, int[] nums) {
        int min=nums.Length+1;
        int sum=0;
        int l=0,r=0;
        while(r<nums.Length){
            if(sum<target){
                sum+=nums[r++];
            }
            else{
                min=Math.Min(min,r-l);
                sum-=nums[l++];
            }
        }
        while(sum>=target){
            min=Math.Min(min,r-l);
            sum-=nums[l++];
        }
        return min==nums.Length+1?0:min;
    }
}