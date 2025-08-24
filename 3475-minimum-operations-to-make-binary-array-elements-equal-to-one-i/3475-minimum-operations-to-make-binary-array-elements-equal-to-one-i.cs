public class Solution {
    public int MinOperations(int[] nums) {
        int oper=0;
        for(int i=0;i<nums.Length-2;i++){
            if(nums[i]==0){
                nums[i]=1;
                nums[i+1]=Math.Abs(nums[i+1]-1);
                nums[i+2]=Math.Abs(nums[i+2]-1);
                oper++;
            }
        }
        if(nums[nums.Length-1]==0||nums[nums.Length-2]==0){
            return -1;
        }
        return oper;
    }
}