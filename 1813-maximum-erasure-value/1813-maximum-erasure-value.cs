public class Solution {
    public int MaximumUniqueSubarray(int[] nums) {
        int max=0;
        int sum=0;
        HashSet<int> subNums=new();
        int l=0;
        int r=0;
        while(r<nums.Length){
            while(l<r&&subNums.Contains(nums[r])){
                subNums.Remove(nums[l]);
                sum-=nums[l];
                l++;
            }
            subNums.Add(nums[r]);
            sum+=nums[r];
            r++;
            max=Math.Max(max,sum);
        }
        return max;
    }
}