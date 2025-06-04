public class Solution {
    public string AnswerString(string word, int numFriends) {
        if(numFriends==1){
            return word;
        }
        int maxLen=word.Length-numFriends+1;
        string lrgLex="", str;
        int ind=0;
        while(ind<word.Length){
            str=word.Substring(ind,Math.Min(maxLen,word.Length-ind));
            if(String.Compare(str, lrgLex) > 0){
                Console.WriteLine($"max - {str}");
                
                lrgLex=str;
            }
            ind++;
        }
        return lrgLex;
    }
}