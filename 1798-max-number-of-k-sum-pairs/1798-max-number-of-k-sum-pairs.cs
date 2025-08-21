public class Solution {
    public int MaxOperations(int[] nums, int k) {
        int left=0,right=nums.Length-1;
        int count=0;
        Array.Sort(nums);
        while(left<right){
            if(nums[left]+nums[right]==k){
                count++;
                left++;
                right--;
            }
            else if(nums[left]+nums[right]<k){
                left++;
            }
            else{
                right--;
            }
        }
        return count;
    }
}