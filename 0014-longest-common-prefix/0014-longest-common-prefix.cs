public class Solution {
    public string LongestCommonPrefix(string[] strs) {
        string common = strs[0];
        for(int i=1;i<strs.Length;i++){
            common=CommonPrefix(common,strs[i]);
            if(common=="") return common;
        }
        return common;
    }

    private string CommonPrefix(string s1,string s2){
        string res="";
        int i=0;
        while(s1.Length>i&&s2.Length>i&&s1[i]==s2[i]){
            res=res+s1[i++];
        }
            
        return res;
    }
}