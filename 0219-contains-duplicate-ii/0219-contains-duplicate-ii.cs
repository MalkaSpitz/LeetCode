public class Solution {
    public bool ContainsNearbyDuplicate(int[] nums, int k) {
        Dictionary<int,List<int>> map=new();
        for(int i=0;i<nums.Length;i++){
            if(!map.TryAdd(nums[i],new List<int>(){i})){
                map[nums[i]].Add(i);
            }
        }
        foreach(var kvp in map){
            int[] arr =kvp.Value.ToArray();
            Array.Sort(arr);
            for(int i=0;i<arr.Length-1;i++){
                if(arr[i+1]-arr[i]<=k) return true;
            }
        }
        return false;
    }
}