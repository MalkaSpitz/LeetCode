public class Solution {
    public int StrStr(string haystack, string needle) {
        for(int i=0;i<haystack.Length;i++){
            if(haystack.Substring(i).StartsWith(needle)){
                return i;
            }
        }
        return -1;
    }
}