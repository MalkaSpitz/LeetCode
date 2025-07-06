public class FindSumPairs {
    Dictionary<int, int> map=new();
    int[] nums;
    public FindSumPairs(int[] nums1, int[] nums2) {
        map=new();
        foreach(var num in nums1){
            if(!map.TryAdd(num,1)){
                map[num]++;
            }
        }
        int ind=0;
        nums=new int[nums2.Length];
        foreach(var num in nums2){
            nums[ind++]=num;
        }
    }
    
    public void Add(int index, int val) {
        nums[index]+=val;
    }
    
    public int Count(int tot) {
        int res=0;
        foreach(var num in nums){
            if(map.ContainsKey(tot-num)){
                res+=map[tot-num];
            }
        }
        return res;
    }
}

/**
 * Your FindSumPairs object will be instantiated and called as such:
 * FindSumPairs obj = new FindSumPairs(nums1, nums2);
 * obj.Add(index,val);
 * int param_2 = obj.Count(tot);
 */