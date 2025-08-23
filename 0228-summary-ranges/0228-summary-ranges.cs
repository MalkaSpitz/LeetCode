public class Solution {
    public IList<string> SummaryRanges(int[] nums) {
        List<string> res=new();
        if(nums.Length==0) return res;
        int start=nums[0];
        for(int i=1;i<=nums.Length;i++){
            if(i!=nums.Length&&nums[i]==nums[i-1]+1){
                continue;
            }
            else{
                if(nums[i-1]==start){
                    res.Add($"{start}");
                }
                else res.Add($"{start}->{nums[i-1]}");
                if(i!=nums.Length)
                    start=nums[i];
            }
        }
        return res;
    }
}