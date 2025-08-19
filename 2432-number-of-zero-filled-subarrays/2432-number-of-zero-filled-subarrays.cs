public class Solution {
    public long ZeroFilledSubarray(int[] nums) {
        Dictionary<int,int> counter=new();
        bool isOnSub=false;
        int zeros=0;
        for(int i=0;i<=nums.Length;i++){
            if(i!=nums.Length&&nums[i]==0){
                isOnSub=true;
                zeros++;
            }
            else{
                if(isOnSub){
                    if(!counter.TryAdd(zeros,1)){
                        counter[zeros]++;
                    }
                    zeros=0;
                    isOnSub=false;
                }
            }
        }
        long totalSubarrays=0;
        foreach(KeyValuePair<int,int> kvp in counter){
            Console.WriteLine($"key {kvp.Key} val {kvp.Value}");
            long subarrays=(long)kvp.Key * (kvp.Key + 1) / 2;
            Console.WriteLine($"sub {subarrays}");
            totalSubarrays += subarrays*kvp.Value;
            Console.WriteLine($"total {totalSubarrays}");
        }
        return totalSubarrays;
    }
}