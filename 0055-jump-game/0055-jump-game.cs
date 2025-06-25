public class Solution {
    public bool CanJump(int[] nums) {
        int maxCan=0;
        int ind=0;
        while(ind<=maxCan){
            maxCan=Math.Max(maxCan,ind+nums[ind++]);
            if(maxCan>=nums.Length-1){
                return true;
            }
        }
        return false;
    }
}