public class Solution {
    public int RemoveDuplicates(int[] nums) {
        int reader=2;
        int writer=2;
        while(reader<nums.Length){
            if(nums[writer-2]!=nums[reader]){
                nums[writer++]=nums[reader++];
            }
            else reader++;
        }
        return Math.Min(writer,nums.Length);
    }
}