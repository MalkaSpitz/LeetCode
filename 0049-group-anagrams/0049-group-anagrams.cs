public class Solution {
    public IList<IList<string>> GroupAnagrams(string[] strs) {
        //sort func/syntax
        //dict.add ->k-sorted word v-word (add to list)
        Dictionary<string,IList<string>> words=new();
        foreach(var str in strs){
            char[] charArray = str.ToCharArray();
            Array.Sort(charArray);
            string sortedString = new string(charArray);
            if(!words.TryAdd(sortedString,new List<string>(){str})){
                words[sortedString].Add(str);
            }
        }
        //return dict.Values
        return words.Values.ToList();
    }
}