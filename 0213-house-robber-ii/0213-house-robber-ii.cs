public class Solution {
    public int Rob(int[] nums) {
        if(nums.Length==1){
            return nums[0];
        }
        return Math.Max(
            Rob_H(nums.Skip(1).Take(nums.Length-1).ToArray()),
            Rob_H(nums.Skip(0).Take(nums.Length-1).ToArray()));
    }
    private int Rob_H(int[] nums){
        if(nums.Length==0){
            return 0;
        }
        if(nums.Length==1){
            return nums[0];
        }
        int[] max=new int[nums.Length];
        max[0]=nums[0];
        max[1]=Math.Max(nums[0],nums[1]);
        for(int i=2;i<max.Length;i++){
            max[i]=Math.Max(max[i-1],nums[i]+max[i-2]);
        }
        return max[max.Length-1];
    }
}
