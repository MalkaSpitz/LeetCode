public class Solution {
    public IList<int> FindKDistantIndices(int[] nums, int key, int k) {
        HashSet<int> inds=new();
        for(int i=0;i<nums.Length;i++){
            if(nums[i]==key){
                inds.Add(i);
            }
        }
        List<int> res=new();
        foreach(int i in inds){
            for(int j=Math.Max(0,i-k);j<=Math.Min(i+k,nums.Length-1);j++){
                res.Add(j);
            }
        }
        return res.Distinct().OrderBy(o=>o).ToList();
    }
}