public class Solution {
    public IList<string> LetterCombinations(string digits) {
        if(digits=="") return new List<string>();
        List<string> res=new(){""};
        Dictionary<char,List<char>> map=new();
        map.Add('2',new List<char>(){'a','b','c'});
        map.Add('3',new List<char>(){'d','e','f'});
        map.Add('4',new List<char>(){'g','h','i'});
        map.Add('5',new List<char>(){'j','k','l'});
        map.Add('6',new List<char>(){'m','n','o'});
        map.Add('7',new List<char>(){'p','q','r','s'});
        map.Add('8',new List<char>(){'t','u','v'});
        map.Add('9',new List<char>(){'w','x','y','z'});
        
        foreach(char c in digits){
            var lst=map[c];
            List<string> temp=new();
            for(int i=0;i<map[c].Count;i++){
                foreach(var word in res){
                    temp.Add(word+lst[i]);
                }
            }
            res=temp;
        }
        return res;
    }
}