public class Solution {
    public int Jump(int[] nums) {
        int[] dp = new int[nums.Length];
        for(int i=1;i<nums.Length;i++){
            for(int j = 0; j < i; j++){
                if(nums[j]+j>=i){
                    dp[i]= dp[j]+1;
                    break;
                }
                
            }
        }
        return dp[dp.Length-1];
    }
}