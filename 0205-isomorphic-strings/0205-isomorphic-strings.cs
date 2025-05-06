public class Solution {
    public bool IsIsomorphic(string s, string t) {
        Dictionary<char,char> swtch=new();
        HashSet<char> used=new();
        for(int i=0;i<s.Length;i++){
            if(swtch.ContainsKey(s[i])){
                if(swtch[s[i]]==t[i]){
                    continue;
                }
                else return false;
            }
            else if(used.Contains(t[i])){
                return false;
            }
            used.Add(t[i]);
            swtch.Add(s[i],t[i]);
        }
        return true;
    }
}