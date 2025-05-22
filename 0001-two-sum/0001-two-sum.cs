public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        Dictionary<int,int> d=new();
        for(int i=0;i<nums.Length;i++){
            if(d.ContainsKey(target-nums[i])){
                return new int[]{i,d[target-nums[i]]};
            }
            d[nums[i]]=i;
        }
        return new int[]{};
    }
}