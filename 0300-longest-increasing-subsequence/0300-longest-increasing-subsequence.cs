public class Solution {
    public int LengthOfLIS(int[] nums) {
        int[] l=new int[nums.Length];
        for(int i=0;i<l.Length;i++){
            int max=1;
            for(int j=0;j<i;j++){
                if(nums[j]<nums[i]){
                    max=Math.Max(l[j]+1,max);
                }
            }
            l[i]=max;
        }
        return l.Max();
    }
}