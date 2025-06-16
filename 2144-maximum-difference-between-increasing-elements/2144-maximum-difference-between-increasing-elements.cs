public class Solution {
    public int MaximumDifference(int[] nums) {
        int max=-1;
        for(int i=0;i<nums.Length;i++){
            for(int j=0;j<nums.Length;j++){
                if(j>i){
                    max=Math.Max(max,nums[j]-nums[i]);
                }
            }
        }
        return max<=0?-1:max;
    }
}