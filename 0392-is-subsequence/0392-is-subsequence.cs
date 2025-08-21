public class Solution {
    public bool IsSubsequence(string s, string t) {
        int inds=0, indt=0;
        while(inds<s.Length&&indt<t.Length){
            if(s[inds]==t[indt]){
                inds++;
                indt++;
            }
            else indt++;
        }
        return inds==s.Length;
    }
}