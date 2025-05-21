public class Solution {
    public char FindTheDifference(string s, string t) {
        s=s+t;
        Dictionary<char,int> d=new();
        foreach(char c in s){
            if(!d.TryAdd(c,1)){
                d[c]++;
            }
        }
        foreach(KeyValuePair<char,int> dd in d){
            if(dd.Value%2==1){
                return dd.Key;
            }
        }
        return 'x';
    }
}