public class Solution {
    IList<IList<string>> lsts = new List<IList<string>>();
    public IList<IList<string>> Partition(string s) {
        Partition(new List<string>(),s);
        return lsts;
    }
    public void Partition(List<string> lst,string s) {
        if(s.Equals("")){
            lsts.Add(new List<string>(lst));
            return;
        }
        for(int i=0;i<s.Length;i++){
            if(IsPalindrome(s.Substring(0,i+1))){
                lst.Add(s.Substring(0,i+1));
                Partition(lst,s.Substring(i+1));
                lst.RemoveAt(lst.Count - 1);
            }
        }
    }
    public bool IsPalindrome(string s){
        string rev= new string(s.Reverse().ToArray());
        return s.Equals(rev);
    }
}