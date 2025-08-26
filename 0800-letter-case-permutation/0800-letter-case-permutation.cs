public class Solution {
    public IList<string> LetterCasePermutation(string s) {
        List<string> res=new(){s};
        for(int i=0;i<s.Length;i++){
            if(Char.IsDigit(s[i])){
                continue;
            }
            else{
                List<string> temp=new();
                foreach(var word in res){
                    char c=Char.ToLower(s[i]);
                    StringBuilder sb = new StringBuilder(word);
                    sb[i] = c;
                    temp.Add(sb.ToString());
                    sb = new StringBuilder(word);
                    sb[i] = Char.ToUpper(s[i]);;
                    temp.Add(sb.ToString());
                }
                res=temp;
            }
        }
        return res;
    }
}