public class Solution {
    public string[] DivideString(string s, int k, char fill) {
        int len=(s.Length/k)+(s.Length%k>0?1:0);
        int ind=0;
        string[] res=new string[len];
        while(s.Length>=k){
            res[ind++]=s.Substring(0,k);
            s=s.Substring(k);
        }
        if(s.Length>0){
            while(s.Length!=k){
                s=s+fill;
            }
            res[res.Length-1]=s;
        }
        return res;
    }
}