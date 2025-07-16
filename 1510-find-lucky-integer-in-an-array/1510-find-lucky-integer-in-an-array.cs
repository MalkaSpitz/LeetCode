public class Solution {
    public int FindLucky(int[] arr) {
        Dictionary<int,int> map=new();
        foreach(int val in arr){
            if(!map.TryAdd(val,1)){
                map[val]++;
            }
        }
        int max=-1;
        foreach(KeyValuePair<int,int> kv in map){
            if(kv.Key==kv.Value){
                if(kv.Key>max){
                    max=kv.Key;
                }
            }
        }
        return max;
    }
}