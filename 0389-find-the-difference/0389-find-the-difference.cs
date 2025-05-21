public class Solution {
    public char FindTheDifference(string s, string t) {
        s=String.Concat(s.OrderBy(c => c));
        t=String.Concat(t.OrderBy(c => c));
        for(int i=0;i<s.Length;i++){
            if(s[i]!=t[i]){
                return t[i];
            }
        }
        return t[t.Length-1];
    }
}