public class Solution {
    public int FirstUniqChar(string s) {
        Dictionary<char,int> d=new();

        foreach(var c in s){
            if(!d.TryAdd(c,1)){
                d[c]++;
            }
        }
        foreach(var c in s){
            if(d[c]==1){
                return s.IndexOf(c);
            }
        }
        return -1;
    }
}