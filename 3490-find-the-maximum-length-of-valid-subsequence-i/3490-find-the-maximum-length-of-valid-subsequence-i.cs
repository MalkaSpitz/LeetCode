public class Solution {
    public int MaximumLength(int[] nums) {
        int countOdd=0;
        int countEven=0;
        int countZig=0;
        int check=0;
        for(int i=0;i<nums.Length;i++){
            if(nums[i]%2==0)
                countEven++;
            else countOdd++;

            if(i==0){
                check=nums[i]%2;
                countZig++;
            }
            else{
                if(Math.Abs(check-1)==nums[i]%2){
                    countZig++;
                    check=Math.Abs(check-1);
                }
            }
        }
        return Math.Max(Math.Max(countEven,countOdd),countZig);
    }
}